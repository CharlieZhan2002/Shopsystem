namespace Shop_system.form
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
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(227, 90);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(74, 17);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username: ";
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Location = new Point(395, 90);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(41, 17);
            lblUserRole.TabIndex = 1;
            lblUserRole.Text = "Role: ";
            // 
            // button1
            // 
            button1.Location = new Point(299, 369);
            button1.Name = "button1";
            button1.Size = new Size(103, 31);
            button1.TabIndex = 2;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(155, 155);
            button3.Name = "button3";
            button3.Size = new Size(125, 48);
            button3.TabIndex = 4;
            button3.Text = "Add customer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(155, 255);
            button4.Name = "button4";
            button4.Size = new Size(125, 48);
            button4.TabIndex = 5;
            button4.Text = "show all user";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(395, 148);
            button6.Name = "button6";
            button6.Size = new Size(123, 63);
            button6.TabIndex = 7;
            button6.Text = "addmanager";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(395, 255);
            button2.Name = "button2";
            button2.Size = new Size(125, 48);
            button2.TabIndex = 8;
            button2.Text = "login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 450);
            Controls.Add(button2);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(lblUserRole);
            Controls.Add(lblUsername);
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblUserRole;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button2;
    }
}
