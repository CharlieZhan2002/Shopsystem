using app_dev_dotNet_AT2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_dev_dotNet_AT2.Forms
{
    public partial class Login : Form
    {
        private string Username;
        private string Password;

        public Login()
        {
            InitializeComponent();
            label5.Text = string.Empty;
        }

        private User FindUser()
        {
            var context = new MyDbContext();
            var users = context.Users.ToList();

            foreach (User user in users)
            {
                if (Username.Equals(user.Email) && Password.Equals(user.Password))
                {
                    return user;;
                }
            }

            return null;


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Username
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Username = textBox1.Text;
        }

        // Password
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Password = textBox2.Text;
        }

        // Submit    
        private async void button1_Click(object sender, EventArgs e)
        {

            label5.Text = "Logging in...";
            Cursor = Cursors.WaitCursor;

            User foundUser = await Task.Run(() => FindUser());

            if (foundUser != null)
            {
                //label5.ForeColor = Color.Green;
                //label5.Text = "Details correct. Logging in.";

                UserHome userHome = new UserHome(foundUser); // pass user into session.
                this.Hide();
                userHome.Show();
            }
            else
            {
                label5.ForeColor = Color.Red;
                label5.Text = "Details incorrect. Try again.";
            }

            Cursor = Cursors.Default;


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            this.Hide();
            signup.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
