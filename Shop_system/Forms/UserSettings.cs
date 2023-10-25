﻿using Microsoft.VisualBasic.ApplicationServices;
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
        private User _currentUser;
        private MyDbContext _db = new MyDbContext();
        private List<Payment> paymentInfo;

        internal UserSettings(User user)
        {

            InitializeComponent();
            _currentUser = user;
            paymentInfo = GetPaymentInfo();
            label5.Text = _currentUser.Username;
            label2.Text = _currentUser.Username;
            label9.Text = _currentUser.ShippingAddress;
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

        private void CheckForCart()
        {
            List<CartProduct> cartProducts = new List<CartProduct>();

            using (MyDbContext db = new MyDbContext())
            {
                Cart existingCart = db.Carts.FirstOrDefault(c => c.UserId == _currentUser.UserId);
                if (existingCart != null)
                {

                    foreach (CartProduct cartProduct in db.CartProducts)
                    {
                        if (existingCart.CartId == cartProduct.CartId)
                        {
                            cartProducts.Add(cartProduct);
                        }
                    }

                    string cartMessage = string.Format("Cart ({0})", cartProducts.Count());

                    button3.Text = cartMessage;

                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserUpdatePayment updatePayment = new UserUpdatePayment(_currentUser);
            this.Hide();
            updatePayment.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserUpdateShipping updateShipping = new UserUpdateShipping(_currentUser);
            this.Hide();
            updateShipping.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserHome home = new UserHome(_currentUser);
            this.Hide();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserProduct product = new UserProduct(_currentUser);
            this.Hide();
            product.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                Cart cart = db.Carts.Where(x => _currentUser.UserId == x.UserId).FirstOrDefault();

                if (cart != null)
                {
                    UserCart userCart = new UserCart(_currentUser);
                    this.Hide();
                    userCart.Show();
                }
                else
                {
                    MessageBox.Show("You have no items in your cart.", "Error");
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserChangePassword userChangePassword = new UserChangePassword(_currentUser);
            this.Hide();
            userChangePassword.Show();
        }
    }
}