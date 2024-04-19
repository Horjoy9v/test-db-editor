using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Product[] products;
        private string filePath;

        public Form1()
        {
            InitializeComponent();
            panel1.AllowDrop = true;
            panel1.DragEnter += Panel_DragEnter;
            panel1.DragDrop += Panel_DragDrop;
        }

        private void Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void Panel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                filePath = files[0];

                if (Path.GetExtension(filePath).Equals(".json", StringComparison.OrdinalIgnoreCase))
                {
                    string fileContent = File.ReadAllText(filePath);
                    products = JsonConvert.DeserializeObject<Product[]>(fileContent);
                    labelDrag.Enabled = true;
                    addBtn.Enabled = true;
                    saveBtn.Enabled = true;
                    this.Text = filePath;
                    DisplayProductsAsync();
                }
                else
                {
                    MessageBox.Show("Помилка: Файл не має розширення .json", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task DisplayProductsAsync()
        {
            panel1.Controls.Clear();

            int y = 10;

            panel1.VerticalScroll.Enabled = false;
            Cursor = Cursors.WaitCursor;
            List<Task> loadingTasks = new List<Task>();

            try
            {
                foreach (var product in products)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Size = new Size(100, 100);
                    pictureBox.Location = new Point(10, y);
                    panel1.Controls.Add(pictureBox);

                    Label nameLabel = new Label();
                    nameLabel.Text = product.name;
                    nameLabel.AutoSize = true;
                    nameLabel.Location = new Point(120, y);
                    panel1.Controls.Add(nameLabel);

                    Button deleteButton = new Button();
                    deleteButton.Text = "Видалити";
                    deleteButton.Tag = product;
                    deleteButton.Location = new Point(470, y);
                    deleteButton.Click += DeleteButton_Click;
                    panel1.Controls.Add(deleteButton);

                    Button detailsButton = new Button();
                    detailsButton.Text = "Деталі";
                    detailsButton.Tag = product;
                    detailsButton.Location = new Point(350, y);
                    detailsButton.Click += DetailsButton_Click;
                    panel1.Controls.Add(detailsButton);

                    loadingTasks.Add(LoadAndSetImageAsync(product.images[0].src, pictureBox));

                    y += 120;
                }

                await Task.WhenAll(loadingTasks);
            }
            finally
            {
                panel1.VerticalScroll.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            Button deleteButton = sender as Button;
            if (deleteButton != null)
            {
                Product product = (Product)deleteButton.Tag;
                if (product != null)
                {
                    products = products.Where(p => p != product).ToArray();
                    SaveUpdatedFile();
                    string fileContent = File.ReadAllText(filePath);
                    products = JsonConvert.DeserializeObject<Product[]>(fileContent);
                    await DisplayProductsAsync();
                }
            }
        }


        private async Task LoadAndSetImageAsync(string imageUrl, PictureBox pictureBox)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    byte[] bytes = await wc.DownloadDataTaskAsync(imageUrl);
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        pictureBox.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження зображення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            Product product = (Product)((Button)sender).Tag;

            using (EditForm editForm = new EditForm(product))
            {
                DialogResult result = editForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    product = editForm.GetUpdatedProduct();
                }
            }
        }

        private void SaveUpdatedFile()
        {
            string json = JsonConvert.SerializeObject(products, Formatting.Indented);

            File.WriteAllText(filePath, json);

            MessageBox.Show("Файл успішно збережено", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void saveBtn_Click_1(object sender, EventArgs e)
        {
            SaveUpdatedFile();
            string fileContent = File.ReadAllText(filePath);
            products = JsonConvert.DeserializeObject<Product[]>(fileContent);
            await DisplayProductsAsync();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product
            {
                id = null,
                name = null,
                available = false,
                description = null,
                brand = null,
                price = 0,
                sales = null,
                characteristics = new CharacteristicsData[0],
                images = new ImageData[0]
            };

            using (EditForm editForm = new EditForm(newProduct))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    List<Product> productList = products.ToList();
                    productList.Add(newProduct);
                    products = productList.ToArray();

                    DisplayProductsAsync();
                }
            }
        }
    }

    public class Product
    {
        public string id { get; set; }
        public string name { get; set; }
        public bool available { get; set; }
        public string description { get; set; }
        public string brand { get; set; }
        public decimal price { get; set; }
        public string sales { get; set; }
        public CharacteristicsData[] characteristics { get; set; }
        public ImageData[] images { get; set; }
    }

    public class ImageData
    {
        public string src { get; set; }
        public string alt { get; set; }
    }
    public class CharacteristicsData
    {
        public string name { get; set; }
        public string value { get; set; }
    }
}
