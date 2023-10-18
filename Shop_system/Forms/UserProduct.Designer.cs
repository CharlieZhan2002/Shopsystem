namespace app_dev_dotNet_AT2.Forms
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            button5 = new Button();
            groupBox1 = new GroupBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)newChangesBindingSource).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(1196, 35);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(60, 20);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Signout";
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
            panel1.Size = new Size(1281, 76);
            panel1.TabIndex = 2;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(1098, 35);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(62, 20);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(800, 35);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(528, 38);
            label1.TabIndex = 3;
            label1.Text = "Supermarket Ordering System - Ordering";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(1281, 63);
            panel2.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(446, 0);
            button4.Name = "button4";
            button4.Size = new Size(217, 63);
            button4.TabIndex = 4;
            button4.Text = "Shopping History";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1063, 0);
            button3.Name = "button3";
            button3.Size = new Size(217, 63);
            button3.TabIndex = 2;
            button3.Text = "Cart";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(223, 0);
            button2.Name = "button2";
            button2.Size = new Size(217, 63);
            button2.TabIndex = 1;
            button2.Text = "Order Products";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(217, 63);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 229);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "Filter:";
            // 
            // button5
            // 
            button5.Location = new Point(197, 53);
            button5.Name = "button5";
            button5.Size = new Size(152, 42);
            button5.TabIndex = 6;
            button5.Text = "Add to cart";
            button5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox2);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(325, 219);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(631, 474);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Products";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 31;
            listBox2.Location = new Point(434, 104);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(113, 345);
            listBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(17, 104);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(330, 345);
            listBox1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(434, 53);
            label6.Name = "label6";
            label6.Size = new Size(67, 31);
            label6.TabIndex = 1;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 53);
            label5.Name = "label5";
            label5.Size = new Size(77, 31);
            label5.TabIndex = 0;
            label5.Text = "Name";
            // 
            // UserProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 705);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)newChangesBindingSource).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button button4;
        private Label label3;
        private Button button5;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}