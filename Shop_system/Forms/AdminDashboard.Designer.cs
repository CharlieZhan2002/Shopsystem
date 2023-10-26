namespace Shop_system.Forms
{
    partial class AdminDashboard
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
            lblUsername = new Label();
            lblUserRole = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            linkLabel2 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(428, 29);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(74, 17);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username: ";
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Location = new Point(584, 31);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(41, 17);
            lblUserRole.TabIndex = 1;
            lblUserRole.Text = "Role: ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(580, 393);
            button1.Name = "button1";
            button1.Size = new Size(103, 45);
            button1.TabIndex = 2;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(397, 141);
            button3.Name = "button3";
            button3.Size = new Size(123, 63);
            button3.TabIndex = 4;
            button3.Text = "Add customer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(157, 141);
            button4.Name = "button4";
            button4.Size = new Size(123, 63);
            button4.TabIndex = 5;
            button4.Text = "Show all user";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(397, 259);
            button6.Name = "button6";
            button6.Size = new Size(123, 63);
            button6.TabIndex = 7;
            button6.Text = "Add manager";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(157, 259);
            button2.Name = "button2";
            button2.Size = new Size(123, 63);
            button2.TabIndex = 8;
            button2.Text = "Change email";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(94, 84, 142);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblUserRole);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(695, 65);
            panel1.TabIndex = 9;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(961, 30);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(54, 17);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(700, 30);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(10, 18);
            label1.Name = "label1";
            label1.Size = new Size(307, 30);
            label1.TabIndex = 3;
            label1.Text = "Supermarket Ordering System";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(1046, 30);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(52, 17);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Signout";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 450);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsername;
        private Label lblUserRole;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button2;
        private Panel panel1;
        private LinkLabel linkLabel2;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}
