using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_system.Forms;
using Shop_system.Model;

namespace Shop_system.form
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard(string username, UserRole role)
        {
            InitializeComponent();
            lblUsername.Text = "Welcome, " + username;
            lblUserRole.Text = "Role: " + role.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddcustomerForm addCustomerForm = new AddcustomerForm();
            addCustomerForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addManagerform AddManagerform = new addManagerform();
            AddManagerform.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserList UserListForm = new UserList();
            UserListForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
