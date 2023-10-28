namespace Shop_system.Forms
{
    partial class UserProduct
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
            components = new System.ComponentModel.Container();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            linkLabel2 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            newChangesBindingSource = new BindingSource(components);
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)newChangesBindingSource).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(1046, 26);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(48, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Signout";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(94, 84, 142);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1121, 57);
            panel1.TabIndex = 2;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(961, 26);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(49, 15);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Settings";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(700, 26);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(10, 16);
            label1.Name = "label1";
            label1.Size = new Size(416, 30);
            label1.TabIndex = 3;
            label1.Text = "Supermarket Ordering System - Ordering";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(1121, 48);
            panel2.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(930, 0);
            button3.Name = "button3";
            button3.Size = new Size(190, 48);
            button3.TabIndex = 2;
            button3.Text = "Cart";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(195, 0);
            button2.Name = "button2";
            button2.Size = new Size(190, 48);
            button2.TabIndex = 1;
            button2.Text = "Order Products";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(190, 48);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(231, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(575, 217);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(241, 147);
            label4.Name = "label4";
            label4.Size = new Size(139, 30);
            label4.TabIndex = 10;
            label4.Text = "Product line";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 159);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 11;
            label3.Text = "Filter categories:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(685, 154);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Location = new Point(830, 154);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 13;
            button4.Text = "Reset filter";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // UserProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 529);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)newChangesBindingSource).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel linkLabel1;
        private Panel panel1;
        private Label label1;
        private BindingSource newChangesBindingSource;
        private Label label2;
        private Panel panel2;
        private System.CodeDom.CodeTypeReference guna2Button1;
        private Button button1;
        private Button button3;
        private Button button2;
        private LinkLabel linkLabel2;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private ComboBox comboBox1;
        private Button button4;
    }
}