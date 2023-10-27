namespace Shop_system.Forms
{
    partial class Addproduct
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
            txtProductName = new TextBox();
            cmbCategory = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            txtPrice = new NumericUpDown();
            txtStock = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 72);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
            label1.TabIndex = 0;
            label1.Text = "Product name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(276, 69);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(100, 23);
            txtProductName.TabIndex = 1;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(276, 195);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 25);
            cmbCategory.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 195);
            label2.Name = "label2";
            label2.Size = new Size(107, 17);
            label2.TabIndex = 3;
            label2.Text = "select a category";
            // 
            // button1
            // 
            button1.Location = new Point(276, 279);
            button1.Name = "button1";
            button1.Size = new Size(121, 33);
            button1.TabIndex = 4;
            button1.Text = "Add product";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 113);
            label3.Name = "label3";
            label3.Size = new Size(37, 17);
            label3.TabIndex = 5;
            label3.Text = "price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 148);
            label4.Name = "label4";
            label4.Size = new Size(40, 17);
            label4.TabIndex = 6;
            label4.Text = "Stock";
            // 
            // txtPrice
            // 
            txtPrice.DecimalPlaces = 2;
            txtPrice.Location = new Point(276, 107);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(120, 23);
            txtPrice.TabIndex = 7;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(276, 146);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(120, 23);
            txtStock.TabIndex = 8;
            // 
            // Addproduct
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 395);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(cmbCategory);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            Name = "Addproduct";
            Text = "Addproduct";
            ((System.ComponentModel.ISupportInitialize)txtPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductName;
        private ComboBox cmbCategory;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private NumericUpDown txtPrice;
        private NumericUpDown txtStock;
    }
}