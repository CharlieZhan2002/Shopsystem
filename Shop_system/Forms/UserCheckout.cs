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
    public partial class UserCheckout : Form
    {
        private User _currentUser;
        private List<CartProductViewModel> _cart;

        public UserCheckout(User user, List<CartProductViewModel> cartProductViewModel)
        {
            InitializeComponent();
            _currentUser = user;
            _cart = cartProductViewModel;
            label5.Text = _currentUser.ShippingAddress;
            comboBox1.DataSource = SetProducts();
            ConfigureGridView();
            SetTotalLabel();

        }

        private void ConfigureGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

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
                Name = "ItemTotal",
                DataPropertyName = "ItemTotal",
                HeaderText = "Item Total",
                Visible = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" },
                ReadOnly = true
            };

            dataGridView1.Columns.Add(ProductName);
            dataGridView1.Columns.Add(ProductPrice);
            dataGridView1.Columns.Add(ProductQuantity);
            dataGridView1.Columns.Add(ItemTotal);

            dataGridView1.DataSource = _cart;
        }

        private void SetTotalLabel()
        {
            decimal total = 0;
            foreach (CartProductViewModel viewModel in _cart)
            {
                total += viewModel.Price * viewModel.ProductQuantity;
            }

            string totalText = string.Format("Total: ${0}", total);

            label6.Text = totalText;
        }

        private List<Payment> SetProducts()
        {
            using (MyDbContext db = new MyDbContext())
            {
                int userId = _currentUser.UserId;

                List<Payment> userPayments = db.Payments
                    .Where(payment => payment.UserId == userId)
                    .ToList();

                return userPayments;
            }
        }
    }
}
