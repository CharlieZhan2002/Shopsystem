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
    public partial class ManagerDashboard : Form
    {
        public ManagerDashboard(string username, UserRole role)
        {
            InitializeComponent();
            lblUsername.Text = "Welcome, " + username;
            lblUserRole.Text = "Role: " + role.ToString();
            // Capture the FormClosed event
            this.FormClosed += (s, e) =>
            {
                // Show the Login form when this form is closed
                Application.OpenForms["Login"].Show();
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductCategoryForm productCategory = new ProductCategoryForm();
            productCategory.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stockcontrol stockcontrol = new stockcontrol();
            stockcontrol.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OOSlist oOSlist = new OOSlist();
            oOSlist.ShowDialog();
        }
    }
}
