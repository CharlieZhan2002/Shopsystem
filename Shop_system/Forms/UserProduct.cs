﻿using Shop_system.Model;
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
    public partial class UserProduct : Form
    {
        private Customer _currentUser;
        private List<Product> _products;
        private List<CartProduct> _cartProducts;


        internal UserProduct(Customer customer)
        {

            _currentUser = customer;
            InitializeComponent();
            label2.Text = "Current user: " + _currentUser.Username;
            ConfigureGridView();
            _products = GetProducts();
            _cartProducts = CheckForCart();
            //DisplayProductNames();
            this.FormClosed += (s, e) =>
            {
                if (Application.OpenForms["UserHome"] is UserHome userHomeForm)
                {
                    userHomeForm.Show();
                }
            };

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

            DataGridViewTextBoxColumn productName = new DataGridViewTextBoxColumn
            {
                Name = "ProductName",
                DataPropertyName = "ProductName",
                HeaderText = "Product Name",
                ReadOnly = true,
                Visible = true
            };

            DataGridViewTextBoxColumn productPrice = new DataGridViewTextBoxColumn
            {
                Name = "Price",
                DataPropertyName = "Price",
                HeaderText = "Product Price",
                ReadOnly = true,
                Visible = true
            };

            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                //DataPropertyName = "Quantity",
                HeaderText = "Quantity",
                Visible = true
            };

            DataGridViewTextBoxColumn productStock = new DataGridViewTextBoxColumn
            {
                Name = "Stock",
                DataPropertyName = "Stock",
                HeaderText = "Stock",
                ReadOnly = true,
                Visible = true
            };

            productPrice.DefaultCellStyle.Format = "$0.00";


            dataGridView1.Columns.Add(ProductId);
            dataGridView1.Columns.Add(productName);
            dataGridView1.Columns.Add(productPrice);
            dataGridView1.Columns.Add(quantityColumn);
            dataGridView1.Columns.Add(productStock);

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Add to Cart";
            buttonColumn.HeaderText = "";
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.Text = "Add to Cart";

            dataGridView1.Columns.Add(buttonColumn);


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            dataGridView1.DataSource = GetProducts();

            dataGridView1.DataBindingComplete += (sender, e) =>
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Set the default quantity value to 1 for each row
                    row.Cells["Quantity"].Value = 1;
                }
            };
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private List<Product> GetProducts()
        {
            using (MyDbContext context = new MyDbContext())
            {
                List<Product> products = context.Products.ToList();
                return products;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Add to Cart"].Index && e.RowIndex >= 0)
            {
                int productId = (int)dataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value;
                string productName = dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                int stock = (int)dataGridView1.Rows[e.RowIndex].Cells["Stock"].Value;
                decimal productPrice = (decimal)dataGridView1.Rows[e.RowIndex].Cells["Price"].Value;
                int quantity;

                if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString(), out quantity))
                {
                    quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString());

                }
                else if (quantity <= 0)
                {
                    MessageBox.Show("Quantity number invalid. Please enter a number greater than zero.", "Alert");
                    return;
                }
                else
                {
                    MessageBox.Show("Incorrect quantity format. Please enter a valid number.", "Alert");
                    return;
                }

                if (quantity > stock)
                {
                    MessageBox.Show("The quantity you've entered exceeds the available stock. Please reduce the quantity.", "Alert");
                    return;
                }

                string message = string.Format("Are you sure you want to add {0} {1} to your cart?", quantity, productName);

                DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    using (var db = new MyDbContext())
                    {
                        Cart existingCart = db.Carts.FirstOrDefault(c => c.UserId == _currentUser.UserId);
                        Product addedProduct = db.Products.FirstOrDefault(c => c.ProductId == productId);

                        if (existingCart == null)
                        {
                            Cart cart = new Cart
                            {
                                UserId = _currentUser.UserId
                            };
                            db.Carts.Add(cart);
                            db.SaveChanges();

                            CartProduct cartProduct = new CartProduct
                            {
                                ProductId = productId,
                                CartId = cart.CartId,
                                Product = addedProduct,
                                Cart = existingCart,
                                ProductQuantity = quantity
                            };
                            _cartProducts.Add(cartProduct);
                            db.CartProducts.Add(cartProduct);
                            db.SaveChanges();
                        }
                        else
                        {
                            // Check if product already exists in the cart
                            CartProduct existingCartProduct = db.CartProducts.FirstOrDefault(cp =>
                                cp.ProductId == productId && cp.CartId == existingCart.CartId);

                            if (existingCartProduct != null)
                            {
                                existingCartProduct.ProductQuantity += quantity;
                            }
                            else
                            {
                                CartProduct cartProduct = new CartProduct
                                {
                                    ProductId = productId,
                                    CartId = existingCart.CartId,
                                    Product = addedProduct,
                                    Cart = existingCart,
                                    ProductQuantity = quantity
                                };
                                _cartProducts.Add(cartProduct);
                                db.CartProducts.Add(cartProduct);

                            }
                            db.SaveChanges();
                        }

                        MessageBox.Show("Product added to cart.");
                    }
                }


            }
            UpdateCartButtonText();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserSettings usersettings = new UserSettings(_currentUser);
            this.Hide();
            usersettings.Show();
        }
    }
}