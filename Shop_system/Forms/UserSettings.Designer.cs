﻿namespace Shop_system.Forms
{
    partial class UserSettings
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
            button5 = new Button();
            button6 = new Button();
            panel3 = new Panel();
            button7 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)newChangesBindingSource).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(1121, 65);
            panel1.TabIndex = 2;
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
            label1.Size = new Size(405, 30);
            label1.TabIndex = 3;
            label1.Text = "Supermarket Ordering System - Settings";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(1121, 54);
            panel2.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(930, 0);
            button3.Name = "button3";
            button3.Size = new Size(190, 54);
            button3.TabIndex = 2;
            button3.Text = "Your cart";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(195, 0);
            button2.Name = "button2";
            button2.Size = new Size(190, 54);
            button2.TabIndex = 1;
            button2.Text = "Products";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(190, 54);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(28, 310);
            button5.Name = "button5";
            button5.Size = new Size(142, 28);
            button5.TabIndex = 4;
            button5.Text = "Update Payment Info";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(419, 310);
            button6.Name = "button6";
            button6.Size = new Size(142, 28);
            button6.TabIndex = 5;
            button6.Text = "Change Password";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button7);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(button5);
            panel3.Location = new Point(279, 179);
            panel3.Name = "panel3";
            panel3.Size = new Size(579, 351);
            panel3.TabIndex = 6;
            // 
            // button7
            // 
            button7.Location = new Point(221, 310);
            button7.Name = "button7";
            button7.Size = new Size(142, 28);
            button7.TabIndex = 11;
            button7.Text = "Update Shipping Info";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(168, 173);
            label9.Name = "label9";
            label9.Size = new Size(43, 17);
            label9.TabIndex = 10;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(28, 173);
            label8.Name = "label8";
            label8.Size = new Size(105, 15);
            label8.TabIndex = 9;
            label8.Text = "Shipping Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(154, 121);
            label7.Name = "label7";
            label7.Size = new Size(43, 17);
            label7.TabIndex = 8;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 121);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 7;
            label6.Text = "Payment Info:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(92, 70);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 70);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 1;
            label4.Text = "Email: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(245, 20);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 0;
            label3.Text = "Account Details";
            // 
            // UserSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 599);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)newChangesBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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
        private Button button5;
        private Button button6;
        private Panel panel3;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label8;
        private Button button7;
    }
}