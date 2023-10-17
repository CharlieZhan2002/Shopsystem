using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_system.Model;

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
                // Check whether a user with the same username already exists
                if (db.Users.Any(u => u.Username == textBox1.Text))
                {
                    MessageBox.Show("Customer ID already exists!");
                    return;
                }

                Customer newCustomer = new Customer
                {
                    Username = textBox1.Text,
                    PasswordHash = textBox2.Text, // In practice, you should use an encryption function instead of simply saving plain text passwords
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
