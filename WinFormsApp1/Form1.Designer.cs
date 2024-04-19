namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            labelDrag = new Label();
            label1 = new Label();
            addBtn = new Button();
            saveBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(labelDrag);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(881, 586);
            panel1.TabIndex = 0;
            // 
            // labelDrag
            // 
            labelDrag.AutoSize = true;
            labelDrag.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDrag.ForeColor = SystemColors.ControlDarkDark;
            labelDrag.Location = new Point(364, 276);
            labelDrag.Name = "labelDrag";
            labelDrag.Size = new Size(145, 30);
            labelDrag.TabIndex = 2;
            labelDrag.Text = "drag and drop";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Gainsboro;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(364, 288);
            label1.Name = "label1";
            label1.Size = new Size(88, 0);
            label1.TabIndex = 1;
            label1.Text = "Drag and drop";
            // 
            // addBtn
            // 
            addBtn.Enabled = false;
            addBtn.Location = new Point(12, 604);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(155, 23);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add New";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Enabled = false;
            saveBtn.Location = new Point(736, 604);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(155, 23);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 639);
            Controls.Add(saveBtn);
            Controls.Add(addBtn);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button addBtn;
        private Button saveBtn;
        private Label labelDrag;
    }
}
