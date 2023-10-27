namespace Shop_system.Forms
{
    partial class OOSlist
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
            listBox1 = new ListBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            panel1 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(157, 88);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(195, 157);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 277);
            label1.Name = "label1";
            label1.Size = new Size(137, 17);
            label1.TabIndex = 1;
            label1.Text = "Select increased stock";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(196, 307);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(196, 350);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Add stock";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(94, 84, 142);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 49);
            panel1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(6, 9);
            label6.Name = "label6";
            label6.Size = new Size(163, 30);
            label6.TabIndex = 3;
            label6.Text = "Out of stock list";
            // 
            // OOSlist
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "OOSlist";
            Text = "OOSlist";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Panel panel1;
        private Label label6;
    }
}