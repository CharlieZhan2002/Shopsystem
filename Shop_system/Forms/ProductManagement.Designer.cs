namespace Shop_system.Forms
{
    partial class ProductManagement
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
            cmbCategories = new ComboBox();
            dataGridViewProducts = new DataGridView();
            btnAddProduct = new Button();
            btnDeleteProduct = new Button();
            lblCategory = new Label();
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(198, 79);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(121, 25);
            cmbCategories.TabIndex = 0;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged_1;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(60, 127);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowTemplate.Height = 25;
            dataGridViewProducts.Size = new Size(693, 258);
            dataGridViewProducts.TabIndex = 1;
            dataGridViewProducts.CellEndEdit += dataGridViewProducts_CellEndEdit;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = SystemColors.ButtonFace;
            btnAddProduct.Location = new Point(480, 403);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(102, 23);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "addProduct";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click_1;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = SystemColors.ButtonFace;
            btnDeleteProduct.Location = new Point(615, 403);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(105, 23);
            btnDeleteProduct.TabIndex = 3;
            btnDeleteProduct.Text = "DeleteProduct";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click_1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(82, 82);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(112, 17);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Choice categories";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(82, 391);
            button1.Name = "button1";
            button1.Size = new Size(125, 35);
            button1.TabIndex = 5;
            button1.Text = "Confirm changes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(581, 107);
            label1.Name = "label1";
            label1.Size = new Size(159, 17);
            label1.TabIndex = 6;
            label1.Text = "Select the price to change";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(94, 84, 142);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 49);
            panel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(6, 9);
            label5.Name = "label5";
            label5.Size = new Size(173, 30);
            label5.TabIndex = 3;
            label5.Text = "Product Manage";
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lblCategory);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(dataGridViewProducts);
            Controls.Add(cmbCategories);
            Name = "ProductManagement";
            Text = "ProductManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCategories;
        private DataGridView dataGridViewProducts;
        private Button btnAddProduct;
        private Button btnDeleteProduct;
        private Label lblCategory;
        private Button button1;
        private Label label1;
        private Panel panel1;
        private Label label5;
    }
}