namespace WinFormsApp1
{
    public partial class EditForm : Form
    {
        private Product product;

        public EditForm(Product product)
        {
            InitializeComponent();
            this.product = product;
            
            idText.Text = product.id ?? string.Empty;
            nameText.Text = product.name ?? string.Empty;
            brandText.Text = product.brand ?? string.Empty;
            priceText.Text = product.price.ToString() ?? string.Empty;
            salesText.Text = product.sales ?? string.Empty;
            descriptionText.Text = product.description ?? string.Empty;
            availibleCheckBox.Checked = product.available;

            characteristicsNameText.Text = string.Join(Environment.NewLine, product.characteristics?.Select(characteristics => characteristics.name) ?? Enumerable.Empty<string>());
            characteristicsValueText.Text = string.Join(Environment.NewLine, product.characteristics?.Select(characteristics => characteristics.value) ?? Enumerable.Empty<string>());
            imagesText.Text = string.Join(Environment.NewLine, product.images?.Select(image => image.src) ?? Enumerable.Empty<string>());
            this.Text = product.name ?? "Новий товар";
            saveButton.Click += SaveButton_Click;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            product.id = idText.Text;
            product.name = nameText.Text;
            product.brand = brandText.Text;

            if (decimal.TryParse(priceText.Text, out decimal price))
            {
                product.price = price;
            }
            product.sales = salesText.Text;
            product.description = descriptionText.Text;
            product.available = availibleCheckBox.Checked;

            var characteristicNames = characteristicsNameText.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            var characteristicValues = characteristicsValueText.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            product.characteristics = characteristicNames.Zip(characteristicValues, (name, value) => new CharacteristicsData { name = name, value = value }).ToArray();
            product.images = imagesText.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).Select(src => new ImageData { src = src }).ToArray();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Product GetUpdatedProduct()
        {
            return product;
        }
    }

    
}
