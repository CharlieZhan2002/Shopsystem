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
    public partial class UserChangePassword : Form
    {
        private User _currentUser;
        private string _currentPassword;
        private string _NewPassword;
        private string _ConfirmNewPassword;

        public UserChangePassword(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserSettings userSettings = new UserSettings(_currentUser);
            this.Hide();
            userSettings.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _currentPassword = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _NewPassword = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            _ConfirmNewPassword = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentPassword) || string.IsNullOrEmpty(_NewPassword) || string.IsNullOrEmpty(_ConfirmNewPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error");
            }

            else if (_currentPassword != _currentUser.PasswordHash)
            {
                MessageBox.Show("Current password incorrect. Please try again.", "Error");
            }
            else if (_NewPassword != _ConfirmNewPassword)
            {
                MessageBox.Show("New passwords do not match. Please try again", "Error");
            }
            else
            {
                using (MyDbContext db = new MyDbContext())
                {
                    User user = db.Users.Find(_currentUser.UserId);

                    if (user != null)
                    {
                        user.PasswordHash = _NewPassword;

                        _currentUser.PasswordHash = _NewPassword;

                        db.SaveChanges();

                        MessageBox.Show("Password changed successfully.");

                        UserSettings userSettings = new UserSettings(_currentUser);
                        this.Hide();
                        userSettings.Show();
                    }

                    else
                    {
                        MessageBox.Show("Error changing password.");
                    }
                }
            }
        }
    }
}
