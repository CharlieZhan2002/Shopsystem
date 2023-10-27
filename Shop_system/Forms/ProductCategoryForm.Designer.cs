namespace Shop_system.Forms
{
    partial class ProductCategoryForm
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
            txtCategoryName = new TextBox();
            lstCategories = new ListBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(189, 318);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(220, 23);
            txtCategoryName.TabIndex = 1;
            // 
            // lstCategories
            // 
            lstCategories.FormattingEnabled = true;
            lstCategories.ItemHeight = 17;
            lstCategories.Location = new Point(127, 87);
            lstCategories.Name = "lstCategories";
            lstCategories.Size = new Size(282, 140);
            lstCategories.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(189, 366);
            button1.Name = "button1";
            button1.Size = new Size(220, 23);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(127, 233);
            button2.Name = "button2";
            button2.Size = new Size(282, 23);
            button2.TabIndex = 4;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(211, 287);
            label1.Name = "label1";
            label1.Size = new Size(105, 17);
            label1.TabIndex = 6;
            label1.Text = "Add a categorie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(189, 67);
            label2.Name = "label2";
            label2.Size = new Size(171, 17);
            label2.TabIndex = 7;
            label2.Text = "Select a category to delete";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 321);
            label3.Name = "label3";
            label3.Size = new Size(101, 17);
            label3.TabIndex = 8;
            label3.Text = "Categorie name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(94, 84, 142);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 49);
            panel1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(6, 9);
            label5.Name = "label5";
            label5.Size = new Size(187, 30);
            label5.TabIndex = 3;
            label5.Text = "Category Manage";
            // 
            // ProductCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 450);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lstCategories);
            Controls.Add(txtCategoryName);
            Name = "ProductCategoryForm";
            Text = "ProductCategory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategoryName;
        private ListBox lstCategories;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label5;
    }
}