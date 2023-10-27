using Shop_system.Helpers;
using Shop_system.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_system.Forms
{
    public partial class addManagerform : Form
    {
        public addManagerform()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Manager ID, Password, and Email are required!");
                return;
            }

            // Use the EmailValidator class to validate the email.
            if (!EmailValidator.IsValid(textBox3.Text))
            {
                MessageBox.Show("Please enter a valid email.");
                return;
            }

            using (MyDbContext db = new MyDbContext())
            {
                // Check whether a user with the same username already exists
                if (db.Users.Any(u => u.Username == textBox1.Text))
                {
                    MessageBox.Show("Manager ID already exists!");
                    return;
                }

                Manager newManager = new Manager
                {
                    Username = textBox1.Text,
                    PasswordHash = textBox2.Text, // In practice, you should use an encryption function instead of simply saving plain text passwords
                    Email = textBox3.Text,        // Add the Email property
                    Role = UserRole.Manager
                };

                db.Users.Add(newManager);
                db.SaveChanges();
            }

            MessageBox.Show("Manager added successfully!");
            this.Close();
        }
    }
}
