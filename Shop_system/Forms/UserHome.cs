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

namespace Shop_system.form
{
    public partial class UserHome : Form
    {
        private User _currentUser;
        private List<CartProduct> _cartProducts;

        public UserHome(string username, UserRole role)
        {
            InitializeComponent();
            _currentUser = new User
            {
                Username = username,
                Role = role
            };

            label2.Text = "Current user: " + _currentUser.Username;
            _cartProducts = CheckForCart();
        }

        private List<CartProduct> CheckForCart()
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

            return cartProducts;
        }

        // Order product
        private void button2_Click(object sender, EventArgs e)
        {
            UserProduct userProduct = new UserProduct(_currentUser);
            this.Hide();
            userProduct.Show();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserSettings usersettings = new UserSettings(_currentUser);
            this.Hide();
            usersettings.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            UserCart userCart = new UserCart(_currentUser);
            this.Hide();
            userCart.Show();
        }
    }
}
