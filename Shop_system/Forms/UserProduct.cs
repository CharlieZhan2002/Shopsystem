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
    public partial class UserProduct : Form, IDisplaysDataCustomer
    {
        private Customer _currentUser;
        private List<CartProduct> _cartProducts;


        internal UserProduct(Customer customer)
        {

            _currentUser = customer;
            InitializeComponent();
            label2.Text = "Current user: " + _currentUser.Username;
            ConfigureGridView(GetProducts());
            _cartProducts = Helper.UpdateCartButtonText(_currentUser, button3);
            comboBox1.DataSource = GetCategories();

        }

        // Get categories from db
        private List<string> GetCategories()
        {
            List<string> categories = new List<string>();
            categories.Add("Show All");

            using (MyDbContext db = new MyDbContext())
            {
                foreach (ProductCategory category in db.ProductCategories)
                {
                    categories.Add(category.CategoryName);
                }
            }

            return categories;
        }

        // Inherited from interface
        public void ConfigureGridView<T>(List<T> items)
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


            dataGridView1.DataSource = items;

            dataGridView1.DataBindingComplete += (sender, e) =>
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Set the default quantity value to 1 for each row
                    row.Cells["Quantity"].Value = 1;
                }
            };
        }

        private List<Product> GetProducts()
        {
            using (MyDbContext context = new MyDbContext())
            {
                List<Product> products = context.Products.ToList();
                return products;
            }
        }

        // Add to cart logic
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Add to Cart"].Index && e.RowIndex >= 0)
            {
                // Grab values of row
                int productId = (int)dataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value;
                string productName = dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                int stock = (int)dataGridView1.Rows[e.RowIndex].Cells["Stock"].Value;
                decimal productPrice = (decimal)dataGridView1.Rows[e.RowIndex].Cells["Price"].Value;
                int quantity;

                // Check the quantity is a valid input
                try
                {
                    quantity = (int)dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value;
                }
                catch(Exception)
                {
                    MessageBox.Show("Incorrect quantity format. Please enter a valid number.", "Alert");
                    return;
                }

                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity number invalid. Please enter a number greater than zero.", "Alert");
                    return;
                }

                if (quantity > stock)
                {
                    MessageBox.Show("The quantity you've entered exceeds the available stock", "Alert");
                    return;
                }
               

                string message = string.Format("Are you sure you want to add {0} {1} to your cart?", quantity, productName);

                DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo);

                

                if (result == DialogResult.Yes)
                {
                    using (var db = new MyDbContext())
                    {
                        // Look to see if user has an existing cart already
                        Cart existingCart = db.Carts.FirstOrDefault(c => c.UserId == _currentUser.UserId);

                        // Grab the product object of the corresponding row
                        Product addedProduct = db.Products.FirstOrDefault(c => c.ProductId == productId);

                        if (existingCart == null)
                        {
                            // Create new cart if one does not already exist
                            Cart cart = new Cart
                            {
                                UserId = _currentUser.UserId
                            };
                            db.Carts.Add(cart);
                            db.SaveChanges();

                            // Create new associative record
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

                            // Subtract the quantity from the stock
                            if (addedProduct != null)
                            {
                                addedProduct.Stock -= quantity;
                            }

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

                                if (addedProduct != null)
                                {
                                    addedProduct.Stock -= quantity;
                                }
                            }
                            else
                            {
                                // If the cart already exists add a new product to it
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

                                if (addedProduct != null)
                                {
                                    addedProduct.Stock -= quantity;
                                }

                            }
                            db.SaveChanges();
                        }
                    }
                }

                // Update datagrid
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = GetProducts();
                UpdateCartButtonText();

            }     
        }

        // Cart button
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

        // User home button
        private void button1_Click(object sender, EventArgs e)
        {
            UserHome destination = new UserHome(_currentUser);
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserSettings destination = new UserSettings(_currentUser);
            Helper.NavigateNextWindowCustomer(this, destination);
        }
        // Category filter logic
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBox1.Text;

            using (MyDbContext db = new MyDbContext())
            {
                if (selectedCategory != "Show All")
                {
                    // Grab the category based on category name
                    ProductCategory category = db.ProductCategories.Where(x => x.CategoryName == selectedCategory).FirstOrDefault();

                    // Use the category to find products containing the category id as a foreign key.
                    List<Product> products = db.Products.Where(x => x.CategoryId == category.CategoryId).ToList();

                    // Refresh datagrid
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = products;
                }
                else
                {
                    // Else, show all products as the filter is set to "Show All"
                    List<Product> products = GetProducts();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = products;
                }
            }


        }

        // Filter reset to "Show All"
        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}