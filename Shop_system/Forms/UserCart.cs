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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Shop_system.Forms
{
    public partial class UserCart : Form
    {
        private User _currentUser;
        private List<Product> _products;
        private List<CartProduct> _cartProducts;


        internal UserCart(User user)
        {

            _currentUser = user;
            InitializeComponent();
            label2.Text = "Current user: " + _currentUser.Username;
            ConfigureGridView();

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

        private void UpdateCartButtonText()
        {
            button3.Text = string.Format("Cart ({0})", _cartProducts.Count());
        }

        private void ConfigureGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn ProductId = new DataGridViewTextBoxColumn
            {
                Name = "ProductId",
                DataPropertyName = "ProductId",
                HeaderText = "ProductId",
                Visible = false
            };

            DataGridViewTextBoxColumn CartId = new DataGridViewTextBoxColumn
            {
                Name = "CartId",
                DataPropertyName = "CartId",
                HeaderText = "CartId",
                Visible = false
            };


            DataGridViewTextBoxColumn ProductName = new DataGridViewTextBoxColumn
            {
                Name = "ProductName",
                DataPropertyName = "ProductName",
                HeaderText = "ProductName",
                Visible = true
            };

            DataGridViewTextBoxColumn ProductPrice = new DataGridViewTextBoxColumn
            {
                Name = "Price",
                DataPropertyName = "Price",
                HeaderText = "Price",
                Visible = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            };

            DataGridViewTextBoxColumn ProductQuantity = new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                DataPropertyName = "ProductQuantity",
                HeaderText = "Quantity",
                Visible = true
            };

            DataGridViewTextBoxColumn ItemTotal = new DataGridViewTextBoxColumn
            {
                Name = "ItemTotal",
                DataPropertyName = "ItemTotal",
                HeaderText = "ItemTotal",
                Visible = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            };

            DataGridViewTextBoxColumn RemoveItem = new DataGridViewTextBoxColumn
            {
                Name = "RemoveItem",
                DataPropertyName = "RemoveItem",
                HeaderText = "RemoveItem",
                Visible = true
            };

            using (var db = new MyDbContext())
            {
                int userId = _currentUser.UserId;

                var userCart =

                // Retrieve CartProduct data for the current user's cart
                var cartProducts = db.CartProducts
                    .Where(cp => cp.Cart.UserId == userId)
                    .ToList();

                // Create a ViewModel to hold the data you want to display
                var viewModel = cartProducts.Select(cp => new
                {
                    cp.Product.ProductId,
                    cp.Product.ProductName,
                    cp.Product.Price,
                    cp.ProductQuantity,
                    ItemTotal = cp.Product.Price * cp.ProductQuantity
                }).ToList();

                // Bind the ViewModel to the DataGridView
                dataGridView1.DataSource = viewModel;
            }


        }

    }


}