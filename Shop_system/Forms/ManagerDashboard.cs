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
            UpdateOutOfStockNotification();
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

        private void UpdateOutOfStockNotification()
        {
            using (var context = new MyDbContext())
            {
                int zeroStockCount = context.Products.Where(p => p.Stock == 0).Count();
                if (zeroStockCount > 0)
                {
                    lblOutOfStockNotification.Text = "Inventory warning: Some items are low on stock！";
                    lblOutOfStockNotification.ForeColor = Color.Red;
                    lblOutOfStockNotification.Visible = true;
                }
                else
                {
                    lblOutOfStockNotification.Text = "";
                    lblOutOfStockNotification.Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OOSlist oOSlist = new OOSlist();
            oOSlist.FormClosed += (s, args) =>
            {
                UpdateOutOfStockNotification(); // Update notification when OOSlist form is closed
            };
            oOSlist.ShowDialog();
        }

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
