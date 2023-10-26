namespace Shop_system.Forms
{
    partial class addadminform
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 153);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 1;
            label1.Text = "User ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 198);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 2;
            label2.Text = "password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(224, 195);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(215, 295);
            button1.Name = "button1";
            button1.Size = new Size(109, 54);
            button1.TabIndex = 4;
            button1.Text = "Submit to add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 243);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 5;
            label3.Text = "email";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(224, 237);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // addadminform
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 449);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "addadminform";
            Text = "addadminform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private TextBox textBox3;
    }
}