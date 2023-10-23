using Shop_system.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_system.Forms
{
    public partial class UserHome : Form
    {
        private User _currentUser;
        private List<CartProduct> _cartProducts;

        public UserHome(User user)
        {
            InitializeComponent();
            _currentUser = user;

            label2.Text = "Current user: " + _currentUser.Username;
            _cartProducts = CheckForCart();
            CheckForShoppingHistory();
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

        private void ConfigureGridView(List<Order> orders)
        {
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn OrderId = new DataGridViewTextBoxColumn
            {
                Name = "OrderId",
                DataPropertyName = "OrderId",
                HeaderText = "Order Id",
                Visible = true,
                ReadOnly = true
            };

            DataGridViewTextBoxColumn Date = new DataGridViewTextBoxColumn
            {
                Name = "Date",
                DataPropertyName = "Date",
                HeaderText = "Date",
                Visible = true,
                ReadOnly = true
            };

            DataGridViewTextBoxColumn ShippingAddress = new DataGridViewTextBoxColumn
            {
                Name = "ShippingAddress",
                DataPropertyName = "ShippingAddress",
                HeaderText = "ShippingAddress",
                Visible = true,
                ReadOnly = true
            };

            DataGridViewTextBoxColumn Status = new DataGridViewTextBoxColumn
            {
                Name = "Status",
                DataPropertyName = "Status",
                HeaderText = "Status",
                Visible = true,
                ReadOnly = true
            };

            DataGridViewButtonColumn ViewOrder = new DataGridViewButtonColumn();
            ViewOrder.Name = "ViewOrder";
            ViewOrder.HeaderText = "";
            ViewOrder.UseColumnTextForButtonValue = true;
            ViewOrder.Text = "View Order";

            dataGridView1.Columns.Add(OrderId);
            dataGridView1.Columns.Add(Date);
            dataGridView1.Columns.Add(ShippingAddress);
            dataGridView1.Columns.Add(Status);
            dataGridView1.Columns.Add(ViewOrder);

            dataGridView1.DataSource = orders;


        }

        private void CheckForShoppingHistory()
        {
            using (MyDbContext db = new MyDbContext())
            {
                List<Order> orders = db.Orders.Where(x => _currentUser.UserId == x.UserId).ToList();

                if (orders.Count > 0)
                {
                    label4.Visible = false;
                    dataGridView1.Visible = true;
                    ConfigureGridView(orders);
                }
                else
                {
                    dataGridView1.Visible = false;
                    label4.Visible = true;
                }
            }
        }
    }


}
