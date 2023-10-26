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
            LogoutLabel = new LinkLabel();
            label1 = new Label();
            lblUsername = new Label();
            lblUserRole = new Label();
            lblOutOfStockNotification = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(443, 138);
            button1.Name = "button1";
            button1.Size = new Size(138, 49);
            button1.TabIndex = 0;
            button1.Text = "Manage inventory";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Location = new Point(443, 255);
            button2.Name = "button2";
            button2.Size = new Size(138, 49);
            button2.TabIndex = 1;
            button2.Text = "Out of stock list";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Location = new Point(171, 138);
            button3.Name = "button3";
            button3.Size = new Size(128, 49);
            button3.TabIndex = 2;
            button3.Text = "Manage product";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Location = new Point(171, 255);
            button4.Name = "button4";
            button4.Size = new Size(128, 49);
            button4.TabIndex = 3;
            button4.Text = "Category management";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(94, 84, 142);
            panel1.Controls.Add(LogoutLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblUserRole);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 65);
            panel1.TabIndex = 10;
            // 
            // LogoutLabel
            // 
            LogoutLabel.AutoSize = true;
            LogoutLabel.LinkColor = Color.White;
            LogoutLabel.Location = new Point(720, 31);
            LogoutLabel.Name = "LogoutLabel";
            LogoutLabel.Size = new Size(49, 17);
            LogoutLabel.TabIndex = 6;
            LogoutLabel.TabStop = true;
            LogoutLabel.Text = "Logout";
            LogoutLabel.LinkClicked += LogoutLabel_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(10, 18);
            label1.Name = "label1";
            label1.Size = new Size(404, 37);
            label1.TabIndex = 3;
            label1.Text = "Supermarket Ordering System";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = SystemColors.ControlLightLight;
            lblUsername.Location = new Point(443, 31);
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
            // lblOutOfStockNotification
            // 
            lblOutOfStockNotification.AutoSize = true;
            lblOutOfStockNotification.Location = new Point(443, 322);
            lblOutOfStockNotification.Name = "lblOutOfStockNotification";
            lblOutOfStockNotification.Size = new Size(0, 17);
            lblOutOfStockNotification.TabIndex = 11;
            // 
            // ManagerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 468);
            Controls.Add(lblOutOfStockNotification);
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
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Label label1;
        private Label lblUsername;
        private Label lblUserRole;
        private LinkLabel LogoutLabel;
        private Label lblOutOfStockNotification;
    }
}