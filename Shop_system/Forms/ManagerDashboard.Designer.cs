namespace Shop_system.Forms
{
    partial class ManagerDashboard
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            lblUsername = new Label();
            lblUserRole = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(386, 138);
            button1.Name = "button1";
            button1.Size = new Size(138, 49);
            button1.TabIndex = 0;
            button1.Text = "Manage inventory";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(386, 255);
            button2.Name = "button2";
            button2.Size = new Size(138, 49);
            button2.TabIndex = 1;
            button2.Text = "Out of stock list";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(171, 138);
            button3.Name = "button3";
            button3.Size = new Size(128, 49);
            button3.TabIndex = 2;
            button3.Text = "Manage product";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(171, 255);
            button4.Name = "button4";
            button4.Size = new Size(128, 49);
            button4.TabIndex = 3;
            button4.Text = "Category management";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(94, 84, 142);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblUserRole);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 65);
            panel1.TabIndex = 10;
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
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = SystemColors.ControlLightLight;
            lblUsername.Location = new Point(428, 29);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(74, 17);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username: ";
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.ForeColor = SystemColors.ControlLightLight;
            lblUserRole.Location = new Point(584, 31);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(41, 17);
            lblUserRole.TabIndex = 1;
            lblUserRole.Text = "Role: ";
            // 
            // ManagerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ManagerDashboard";
            Text = "ManagerDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private LinkLabel linkLabel2;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label lblUsername;
        private Label lblUserRole;
    }
}