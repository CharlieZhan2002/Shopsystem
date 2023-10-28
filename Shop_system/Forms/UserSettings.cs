using Microsoft.VisualBasic.ApplicationServices;
using Shop_system.Forms;
using Shop_system.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = Shop_system.Model.User;

namespace Shop_system.Forms
{
    public partial class UserSettings : Form
    {
        private Customer _currentUser;
        private MyDbContext _db = new MyDbContext();
        private List<Payment> paymentInfo;

        internal UserSettings(Customer user)
        {

            InitializeComponent();
            _currentUser = user;
            paymentInfo = GetPaymentInfo();
            label5.Text = _currentUser.Username;
            label2.Text = "Current user: " + _currentUser.Username;
            label9.Text = _currentUser.ShippingAddress;
            Helper.UpdateCartButtonText(_currentUser, button3);
            if (paymentInfo.Count == 0)
            {
                label7.Text = "No linked payment methods.";
            }
            else
            {
                label7.Text = string.Format("You have {0} cards linked to your account", paymentInfo.Count);
            }
        }

        private List<Payment> GetPaymentInfo()
        {
            List<Payment> paymentsForUser = _db.Payments.Where(p => p.UserId == _currentUser.UserId).ToList();
            return paymentsForUser;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserUpdatePayment destination = new UserUpdatePayment(_currentUser);
            Helper.NavigateNextWindowCustomer(this, destination);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserUpdateShipping destination= new UserUpdateShipping(_currentUser);
            Helper.NavigateNextWindowCustomer(this, destination);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserChangePassword destination = new UserChangePassword(_currentUser);
            Helper.NavigateNextWindowCustomer(this, destination);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Get the reference to the login form
            Form loginForm = null;
            if (Application.OpenForms["Login"] is Form foundForm)
            {
                loginForm = foundForm;
            }

            // Close all forms
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form != loginForm)
                    form.Close();
            }

            // Show the login form if it was found and is not currently displayed
            if (loginForm != null && !loginForm.Visible)
            {
                loginForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserProduct destination = new UserProduct(_currentUser);
            Helper.NavigateNextWindowCustomer(this, destination);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserHome destination = new UserHome(_currentUser);
            Helper.NavigateNextWindowCustomer(this, destination);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                Cart cart = db.Carts.Where(x => _currentUser.UserId == x.UserId).FirstOrDefault();

                if (cart != null)
                {
                    UserCart destination = new UserCart(_currentUser);
                    Helper.NavigateNextWindowCustomer(this, destination);
                }
                else
                {
                    MessageBox.Show("You have no items in your cart.", "Error");
                }
            }
        }
    }
}