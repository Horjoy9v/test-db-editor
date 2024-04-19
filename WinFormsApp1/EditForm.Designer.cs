namespace WinFormsApp1
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            idText = new TextBox();
            nameText = new TextBox();
            availibleCheckBox = new CheckBox();
            descriptionText = new TextBox();
            label5 = new Label();
            label6 = new Label();
            brandText = new TextBox();
            priceText = new TextBox();
            salesText = new TextBox();
            imagesText = new TextBox();
            label7 = new Label();
            saveButton = new Button();
            characteristicsNameText = new TextBox();
            characteristics = new Label();
            characteristicsValueText = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(12, 204);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(12, 70);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Brand";
            // 
            // idText
            // 
            idText.BackColor = SystemColors.Window;
            idText.BorderStyle = BorderStyle.FixedSingle;
            idText.Location = new Point(108, 9);
            idText.MaximumSize = new Size(400, 23);
            idText.MinimumSize = new Size(150, 23);
            idText.Name = "idText";
            idText.Size = new Size(366, 23);
            idText.TabIndex = 4;
            // 
            // nameText
            // 
            nameText.BackColor = SystemColors.Window;
            nameText.BorderStyle = BorderStyle.FixedSingle;
            nameText.Location = new Point(108, 38);
            nameText.Name = "nameText";
            nameText.Size = new Size(366, 23);
            nameText.TabIndex = 5;
            // 
            // availibleCheckBox
            // 
            availibleCheckBox.AutoSize = true;
            availibleCheckBox.Location = new Point(480, 13);
            availibleCheckBox.Name = "availibleCheckBox";
            availibleCheckBox.Size = new Size(74, 19);
            availibleCheckBox.TabIndex = 6;
            availibleCheckBox.Text = "Available";
            availibleCheckBox.UseVisualStyleBackColor = true;
            // 
            // descriptionText
            // 
            descriptionText.BackColor = SystemColors.Window;
            descriptionText.BorderStyle = BorderStyle.FixedSingle;
            descriptionText.Location = new Point(108, 154);
            descriptionText.Multiline = true;
            descriptionText.Name = "descriptionText";
            descriptionText.ScrollBars = ScrollBars.Horizontal;
            descriptionText.Size = new Size(366, 136);
            descriptionText.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(12, 128);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 8;
            label5.Text = "Sales";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(12, 99);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 9;
            label6.Text = "Price";
            // 
            // brandText
            // 
            brandText.BackColor = SystemColors.Window;
            brandText.BorderStyle = BorderStyle.FixedSingle;
            brandText.Location = new Point(108, 67);
            brandText.Name = "brandText";
            brandText.Size = new Size(366, 23);
            brandText.TabIndex = 10;
            // 
            // priceText
            // 
            priceText.BackColor = SystemColors.Window;
            priceText.BorderStyle = BorderStyle.FixedSingle;
            priceText.Location = new Point(108, 96);
            priceText.Name = "priceText";
            priceText.Size = new Size(366, 23);
            priceText.TabIndex = 11;
            // 
            // salesText
            // 
            salesText.BackColor = SystemColors.Window;
            salesText.BorderStyle = BorderStyle.FixedSingle;
            salesText.Location = new Point(108, 125);
            salesText.Name = "salesText";
            salesText.Size = new Size(366, 23);
            salesText.TabIndex = 12;
            // 
            // imagesText
            // 
            imagesText.BackColor = SystemColors.Window;
            imagesText.BorderStyle = BorderStyle.FixedSingle;
            imagesText.Location = new Point(108, 296);
            imagesText.Multiline = true;
            imagesText.Name = "imagesText";
            imagesText.Size = new Size(366, 291);
            imagesText.TabIndex = 13;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(12, 440);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 14;
            label7.Text = "Images";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(784, 12);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 15;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // characteristicsNameText
            // 
            characteristicsNameText.BorderStyle = BorderStyle.FixedSingle;
            characteristicsNameText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            characteristicsNameText.Location = new Point(480, 296);
            characteristicsNameText.Multiline = true;
            characteristicsNameText.Name = "characteristicsNameText";
            characteristicsNameText.Size = new Size(207, 291);
            characteristicsNameText.TabIndex = 16;
            // 
            // characteristics
            // 
            characteristics.AutoSize = true;
            characteristics.Location = new Point(647, 278);
            characteristics.Name = "characteristics";
            characteristics.Size = new Size(84, 15);
            characteristics.TabIndex = 17;
            characteristics.Text = "Characteristics";
            // 
            // characteristicsValueText
            // 
            characteristicsValueText.BorderStyle = BorderStyle.FixedSingle;
            characteristicsValueText.Location = new Point(693, 296);
            characteristicsValueText.Multiline = true;
            characteristicsValueText.Name = "characteristicsValueText";
            characteristicsValueText.Size = new Size(199, 291);
            characteristicsValueText.TabIndex = 18;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(904, 599);
            ControlBox = false;
            Controls.Add(characteristicsValueText);
            Controls.Add(characteristics);
            Controls.Add(characteristicsNameText);
            Controls.Add(saveButton);
            Controls.Add(label7);
            Controls.Add(imagesText);
            Controls.Add(salesText);
            Controls.Add(priceText);
            Controls.Add(brandText);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(descriptionText);
            Controls.Add(availibleCheckBox);
            Controls.Add(nameText);
            Controls.Add(idText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(920, 638);
            MinimumSize = new Size(920, 638);
            Name = "EditForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox idText;
        private TextBox nameText;
        private CheckBox availibleCheckBox;
        private TextBox descriptionText;
        private Label label5;
        private Label label6;
        private TextBox brandText;
        private TextBox priceText;
        private TextBox salesText;
        private TextBox imagesText;
        private Label label7;
        private Button saveButton;
        private TextBox characteristicsNameText;
        private Label characteristics;
        private TextBox characteristicsValueText;
    }
}