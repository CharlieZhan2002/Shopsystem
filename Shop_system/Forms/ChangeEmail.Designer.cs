namespace Shop_system.Forms
{
    partial class ChangeEmail
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
            btnUpdate = new Button();
            txtUsername = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 154);
            label1.Name = "label1";
            label1.Size = new Size(35, 17);
            label1.TabIndex = 0;
            label1.Text = "User";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(136, 302);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 31);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Change";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(136, 151);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(139, 23);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 207);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 3;
            label2.Text = "New Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(136, 204);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(139, 23);
            txtEmail.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(79, 38);
            label3.Name = "label3";
            label3.Size = new Size(207, 38);
            label3.TabIndex = 5;
            label3.Text = "Email Change";
            // 
            // ChangeEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 408);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Name = "ChangeEmail";
            Text = "ChangeEmail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnUpdate;
        private TextBox txtUsername;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
    }
}