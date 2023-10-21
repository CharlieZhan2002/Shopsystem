namespace Shop_system.Forms
{
    partial class UserUpdatePayment
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 59);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(146, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(370, 196);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(215, 45);
            label2.Name = "label2";
            label2.Size = new Size(221, 38);
            label2.TabIndex = 2;
            label2.Text = "Update Payment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 204);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 3;
            label3.Text = "No payment methods.";
            // 
            // button1
            // 
            button1.Location = new Point(405, 353);
            button1.Name = "button1";
            button1.Size = new Size(165, 51);
            button1.TabIndex = 4;
            button1.Text = "Add payment method";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(94, 353);
            button2.Name = "button2";
            button2.Size = new Size(165, 51);
            button2.TabIndex = 5;
            button2.Text = "Delete payment method";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(32, 45);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(40, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // UserUpdatePayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 450);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "UserUpdatePayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Payment";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private LinkLabel linkLabel1;
    }
}