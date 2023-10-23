using Microsoft.EntityFrameworkCore;
using Shop_system.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Shop_system.Forms
{
    public partial class UserCart : Form
    {
        private User _currentUser;
        private List<CartProductViewModel> _cartProductsView;


        internal UserCart(User user)
        {

            _currentUser = user;
            InitializeComponent();
            label2.Text = "Current user: " + _currentUser.Username;
            _cartProductsView = GetCartProducts();
            SetTotalLabel();
            ConfigureGridView();

        }

        private List<CartProductViewModel> GetCartProducts()
        {
            using (MyDbContext db = new MyDbContext())
            {
                int userId = _currentUser.UserId;

                Cart cart = db.Carts.FirstOrDefault(c => c.UserId == userId);

                if (cart != null)
                {

                    List<CartProductViewModel> cartProducts = db.CartProducts
                    .Where(cp => cp.CartId == cart.CartId)
                    .Select(cp => new CartProductViewModel
                    {
                        ProductId = cp.Product.ProductId,
                        CartId = cp.Cart.CartId,
                        ProductName = cp.Product.ProductName,
                        Price = cp.Product.Price,
                        ProductQuantity = cp.ProductQuantity,
                        ItemTotal = cp.Product.Price * cp.ProductQuantity
                    })
                    .ToList();


                    return cartProducts;
                }
                else
                {

                    return null;
                }
            }
        }

        private void SetTotalLabel()
        {
            decimal total = 0;
            foreach (CartProductViewModel viewModel in _cartProductsView)
            {
                total += viewModel.Price * viewModel.ProductQuantity;
            }

            string totalText = string.Format("Total: ${0}", total);

            label4.Text = totalText;
        }

        // Just for cart button
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
            button3.Text = string.Format("Cart ({0})", _cartProductsView.Count());
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
                Visible = true,
                ReadOnly = true
            };

            DataGridViewTextBoxColumn ProductPrice = new DataGridViewTextBoxColumn
            {
                Name = "Price",
                DataPropertyName = "Price",
                HeaderText = "Price",
                Visible = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" },
                ReadOnly = true
            };

            DataGridViewTextBoxColumn ProductQuantity = new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                DataPropertyName = "ProductQuantity",
                HeaderText = "Quantity",
                Visible = true,
                ReadOnly = false
            };

            DataGridViewTextBoxColumn ItemTotal = new DataGridViewTextBoxColumn
            {
                Name = "Item Total",
                DataPropertyName = "ItemTotal",
                HeaderText = "ItemTotal",
                Visible = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" },
                ReadOnly = true
            };

            DataGridViewCheckBoxColumn RemoveItem = new DataGridViewCheckBoxColumn
            {
                Name = "RemoveItem",
                DataPropertyName = "RemoveItem",
                HeaderText = "Remove Item?",
                Visible = true,
                ReadOnly = true
            };

            dataGridView1.Columns.Add(ProductId);
            dataGridView1.Columns.Add(CartId);
            dataGridView1.Columns.Add(ProductName);
            dataGridView1.Columns.Add(ProductPrice);
            dataGridView1.Columns.Add(ProductQuantity);
            dataGridView1.Columns.Add(ItemTotal);
            dataGridView1.Columns.Add(RemoveItem);

            dataGridView1.DataSource = _cartProductsView;


        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Quantity"].Index)
            {
                // Get the edited quantity value
                int newQuantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                // Retrieve the corresponding CartProductViewModel
                var cartProductView = _cartProductsView[e.RowIndex];

                // Update the ItemTotal based on the new quantity
                decimal newPrice = cartProductView.Price;
                decimal newItemTotal = newQuantity * newPrice;
                cartProductView.ItemTotal = newItemTotal;

                // Update the ProductQuantity in the ViewModel
                cartProductView.ProductQuantity = newQuantity;

                // Update the display in the DataGridView
                dataGridView1.Rows[e.RowIndex].Cells["Item Total"].Value = newItemTotal;

                dataGridView1.Refresh();
                SetTotalLabel();

                // You can also save the changes to your database if needed.

                using (MyDbContext db = new MyDbContext())
                {
                    var cartProduct = db.CartProducts.Find(cartProductView.CartId, cartProductView.ProductId);

                    if (cartProduct != null)
                    {
                        cartProduct.ProductQuantity = newQuantity;
                        db.SaveChanges();
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["RemoveItem"].Index)
            {
                string productName = dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();

                string message = string.Format("You are about to remove '{0}' from the cart. \nAre you sure?", productName);
                DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    var cartProductView = _cartProductsView[e.RowIndex];

                    // Perform the removal in the ViewModel
                    _cartProductsView.Remove(cartProductView);
                    SetTotalLabel();

                    // Update the DataGridView
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = _cartProductsView;

                    // If you want to remove it from the database as well, do it here
                    using (MyDbContext db = new MyDbContext())
                    {
                        var cartProduct = db.CartProducts.Find(cartProductView.CartId, cartProductView.ProductId);

                        if (cartProduct != null)
                        {
                            db.CartProducts.Remove(cartProduct); // Remove the item from the database
                            db.SaveChanges(); // Save changes to the database
                        }
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserProduct userProduct = new UserProduct(_currentUser);
            this.Hide();
            userProduct.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserSettings userSettings = new UserSettings(_currentUser);
            this.Hide();
            userSettings.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }


}