using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_system.form
{
    public partial class AddcustomerForm : Form
    {
        public AddcustomerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Both Customer ID and Password are required!");
                return;
            }

            using (UserContext db = new UserContext())
            {
                // 检查是否已经存在具有相同用户名的用户
                if (db.Users.Any(u => u.Username == textBox1.Text))
                {
                    MessageBox.Show("Customer ID already exists!");
                    return;
                }

                Customer newCustomer = new Customer
                {
                    Username = textBox1.Text,
                    PasswordHash = textBox2.Text, // 在实际应用中，您应该使用一个加密函数而不是直接保存明文密码
                    Role = UserRole.Customer
                };

                db.Users.Add(newCustomer);
                db.SaveChanges();
            }

            MessageBox.Show("Customer added successfully!");
            this.Close();
        }
    }
}
