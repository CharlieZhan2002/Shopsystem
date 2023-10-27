namespace Shop_system.Forms
{
    partial class UserCheckout
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
            label5 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            label6 = new Label();
            linkLabel2 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(276, 22);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 0;
            label1.Text = "Checkout";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(97, 94);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 1;
            label2.Text = "Delivery Address: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(97, 157);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 2;
            label3.Text = "Payment Method:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(97, 218);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 3;
            label4.Text = "Review Items:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(273, 99);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(273, 155);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 25);
            comboBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(99, 255);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(488, 160);
            dataGridView1.TabIndex = 6;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(416, 99);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(151, 17);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Update delivery address";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(466, 420);
            button1.Name = "button1";
            button1.Size = new Size(112, 25);
            button1.TabIndex = 9;
            button1.Text = "Place your order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(346, 423);
            label6.Name = "label6";
            label6.Size = new Size(40, 17);
            label6.TabIndex = 10;
            label6.Text = "Total:";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(31, 33);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(36, 17);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Back";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // UserCheckout
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 488);
            Controls.Add(linkLabel2);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserCheckout";
            Text = "UserCheckout";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private LinkLabel linkLabel1;
        private Button button1;
        private Label label6;
        private LinkLabel linkLabel2;
    }
}