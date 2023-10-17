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
    public partial class addadminform : Form
    {
        public addadminform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Both User ID and Password are required!");
                return;
            }

            using (UserContext db = new UserContext())
            {
                // Check whether a user with the same username already exists
                if (db.Users.Any(u => u.Username == textBox1.Text))
                {
                    MessageBox.Show("User ID already exists!");
                    return;
                }

                Admin newAdmin = new Admin
                {
                    Username = textBox1.Text,
                    PasswordHash = textBox2.Text, // In practice, you should use an encryption function instead of saving the plaintext password directly
                    Role = UserRole.Admin
                };

                db.Admins.Add(newAdmin);
                db.SaveChanges();
            }

            MessageBox.Show("Admin added successfully!");
            this.Close();
        }
    }
}
