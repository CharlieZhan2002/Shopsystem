using Microsoft.VisualBasic.ApplicationServices;
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
        private Customer _currentUser;
        private List<CartProductViewModel> _cart;
        private List<long> _paymentNums;
        private Dictionary<string, Payment> _comboTextToPayment;

        internal UserCheckout(Customer customer, List<CartProductViewModel> cartProductViewModel)
        {
            InitializeComponent();
            _currentUser = customer;
            _cart = cartProductViewModel;
            label5.Text = _currentUser.ShippingAddress;

            _comboTextToPayment = new Dictionary<string, Payment>();

            ConfigureGridView();
            ConfigureComboBox();
            SetTotalLabel();

            this.FormClosed += (s, e) =>
            {
                if (Application.OpenForms["UserHome"] is UserHome userHomeForm)
                {
                    userHomeForm.Show();
                }
            };

        }
        private void ConfigureComboBox()
        {
            List<Payment> paymentMethods = SetPayment();

            List<string> cardNumsCombo = new List<string>();

            foreach (Payment payment in paymentMethods)
            {
                string displayedCardNumber = "Card ending in " + (payment.CardNum % 10000);

                cardNumsCombo.Add(displayedCardNumber);

                _comboTextToPayment[displayedCardNumber] = payment;
            }

            comboBox1.DataSource = cardNumsCombo;
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
                ReadOnly = true
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
            decimal total = GetOrderTotal();
            string totalText = string.Format("Total: ${0}", total);

            label6.Text = totalText;
        }

        private decimal GetOrderTotal()
        {
            decimal total = 0;
            foreach (CartProductViewModel viewModel in _cart)
            {
                total += viewModel.Price * viewModel.ProductQuantity;
            }

            return total;
        }

        private List<Payment> SetPayment()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                using (MyDbContext db = new MyDbContext())
                {
                    Payment payment = _comboTextToPayment[comboBox1.Text];

                    Order order = new Order
                    {
                        PaymentId = payment.PaymentId,
                        Date = DateTime.Now,
                        ShippingAddress = label5.Text,
                        Status = Order.OrderStatus.Paid,
                        UserId = _currentUser.UserId,
                        OrderTotal = GetOrderTotal()
                    };

                    db.Orders.Add(order);
                    db.SaveChanges();

                    foreach (CartProductViewModel product in _cart)
                    {
                        OrderProduct orderProduct = new OrderProduct
                        {
                            ProductId = product.ProductId,
                            OrderId = order.OrderId,
                            ProductQuantity = product.ProductQuantity
                        };

                        Product productEntity = db.Products.Find(product.ProductId);
                        if (productEntity != null)
                        {
                            productEntity.Stock -= product.ProductQuantity;
                        }

                        db.OrderProducts.Add(orderProduct);
                    }

                    // Clean up cart

                    Cart cart = db.Carts.FirstOrDefault(x => x.UserId == _currentUser.UserId);

                    if (cart != null)
                    {
                        var cartProducts = db.CartProducts.Where(cp => cp.CartId == cart.CartId);
                        db.CartProducts.RemoveRange(cartProducts);


                        db.Carts.Remove(cart);
                    }

                    db.SaveChanges();

                    MessageBox.Show("Order successful");

                    UserHome userHome = new UserHome(_currentUser);

                    this.Hide();

                    userHome.Show();
                }
            }
            else
            {
                MessageBox.Show("Please select a payment method.", "Error");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserCart userCart = new UserCart(_currentUser);
            this.Hide();
            userCart.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserUpdateShipping userUpdateShipping = new UserUpdateShipping(_currentUser);
            userUpdateShipping.Show();
            this.Close();
        }
    }
}
