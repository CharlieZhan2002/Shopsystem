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

namespace app_dev_dotNet_AT2.Forms
{
    public partial class UserProduct : Form
    {
        private User _currentUser;
        private List<Product> _products;
        private List<Product> _cartProducts;


        public UserProduct(User user)
        {

            _currentUser = user;
            InitializeComponent();
            label2.Text = "Current user: " + _currentUser.Username;
            ConfigureGridView();
            _products = GetProducts();
            _cartProducts = new List<Product>();
            //DisplayProductNames();

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
                DataPropertyName = "Name",
                HeaderText = "Product Name",
                Visible = true
            };

            DataGridViewTextBoxColumn productPrice = new DataGridViewTextBoxColumn
            {
                Name = "Price",
                DataPropertyName = "Price",
                HeaderText = "Product Price",
                Visible = true
            };

            productPrice.DefaultCellStyle.Format = "$0.00";


            dataGridView1.Columns.Add(ProductId);
            dataGridView1.Columns.Add(productName);
            dataGridView1.Columns.Add(productPrice);

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Add to Cart";
            buttonColumn.HeaderText = "";
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.Text = "Add to Cart";

            dataGridView1.Columns.Add(buttonColumn);


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            dataGridView1.DataSource = GetProducts();
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
                double productPrice = (double)dataGridView1.Rows[e.RowIndex].Cells["Price"].Value;


                string message = string.Format("Are you sure you want to add {0} to your cart?", productName);

                DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    using (var db = new MyDbContext())
                    {
                        // Check if a cart exists for the current user
                        Order userCart = db.Orders.FirstOrDefault(c => c.UserId == _currentUser.UserId && c.Status == Order.OrderStatus.Cart);

                        if (userCart == null)
                        {
                            // Create a new cart if one doesn't exist
                            userCart = new Order
                            {
                                UserId = _currentUser.UserId,
                                Date = DateTime.Now,
                                Status = Order.OrderStatus.Cart
                            };
                            db.Orders.Add(userCart);
                            db.SaveChanges();
                        }

                        // Create a new OrderProduct entity to associate the product with the cart
                        OrderProduct orderProduct = new OrderProduct
                        {
                            ProductId = productId,
                            OrderId = userCart.OrderId // Use the generated CartId
                        };

                        db.OrderProducts.Add(orderProduct);
                        db.SaveChanges();

                        MessageBox.Show("Product added to cart.");
                    }
                }  


            }
        }
    }
}