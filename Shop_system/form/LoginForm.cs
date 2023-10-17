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
    public partial class LoginForm : Form
    {
        private UserContext _context;

        public LoginForm()
        {
            InitializeComponent();
            _context = new UserContext();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var username = usernameTextBox.Text;
            var password = passwordTextBox.Text;

            var user = _context.Users
                       .Where(u => u.Username == username && u.PasswordHash == password)
                       .FirstOrDefault();

            if (user != null)
            {
                if (user.Role == UserRole.Admin)
                {
                    // Open Admin Dashboard
                    AdminDashboard adminDashboard = new AdminDashboard(user.Username, user.Role);
                    adminDashboard.Show();
                    this.Hide();
                }
                else if (user.Role == UserRole.Customer)
                {
                    // Open Customer Dashboard
                    CustomerDashboard customerDashboard = new CustomerDashboard(user.Username, user.Role);
                    customerDashboard.Show();
                    this.Hide();
                }
            }
            else
            {
                // Invalid credentials
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
