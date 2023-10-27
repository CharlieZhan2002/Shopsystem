using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_system.Helpers;
using Shop_system.Model;

namespace Shop_system.Forms
{
    public partial class ChangeEmail : Form
    {
        public ChangeEmail()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string newEmail = txtEmail.Text;

            // Check if email format is valid
            if (!EmailValidator.IsValid(newEmail))
            {
                MessageBox.Show("Invalid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new MyDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username);
                if (user != null)
                {
                    user.Email = newEmail;
                    context.SaveChanges();

                    MessageBox.Show("Email updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
