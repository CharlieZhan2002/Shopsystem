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
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard(string username, UserRole role)
        {
            InitializeComponent();
            lblUsername.Text = "Welcome, " + username;
            lblUserRole.Text = "Role: " + role.ToString();
        }
    }
}
