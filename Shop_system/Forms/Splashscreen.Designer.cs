﻿namespace Shop_system.Forms
{
    partial class Splashscreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(164, 104);
            button1.Name = "button1";
            button1.Size = new Size(125, 48);
            button1.TabIndex = 0;
            button1.Text = "Add admin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(433, 104);
            button2.Name = "button2";
            button2.Size = new Size(125, 48);
            button2.TabIndex = 1;
            button2.Text = "Add customer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(164, 234);
            button4.Name = "button4";
            button4.Size = new Size(125, 48);
            button4.TabIndex = 3;
            button4.Text = "show all user";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(433, 234);
            button3.Name = "button3";
            button3.Size = new Size(125, 48);
            button3.TabIndex = 4;
            button3.Text = "login";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(288, 342);
            button5.Name = "button5";
            button5.Size = new Size(125, 48);
            button5.TabIndex = 5;
            button5.Text = "exit";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(303, 163);
            button6.Name = "button6";
            button6.Size = new Size(123, 63);
            button6.TabIndex = 6;
            button6.Text = "addmanager";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Splashscreen
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Splashscreen";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button6;
    }
}