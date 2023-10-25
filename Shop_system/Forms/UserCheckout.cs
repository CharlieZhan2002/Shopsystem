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
            decimal total = 0;
            foreach (CartProductViewModel viewModel in _cart)
            {
                total += viewModel.Price * viewModel.ProductQuantity;
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. 验证支付方式是否已选择
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("请先选择支付方式。", "错误");
                return;
            }

            using (MyDbContext db = new MyDbContext())
            {
                Payment payment = _comboTextToPayment[comboBox1.Text];

                // 2. 从库存中减少商品数量
                foreach (var cartProductView in _cart)
                {
                    var productInDb = db.Products.FirstOrDefault(p => p.ProductId == cartProductView.ProductId);
                    if (productInDb != null)
                    {
                        productInDb.Stock -= cartProductView.ProductQuantity;
                    }
                }

                // 3. 创建新的订单记录
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

                foreach (CartProductViewModel product in _cart)
                {
                    OrderProduct orderProduct = new OrderProduct
                    {
                        ProductId = product.ProductId,
                        OrderId = order.OrderId,
                        ProductQuantity = product.ProductQuantity
                    };

                    db.OrderProducts.Add(orderProduct);
                }

                // 4. 清空购物车
                Cart cart = db.Carts.FirstOrDefault(x => x.UserId == _currentUser.UserId);
                if (cart != null)
                {
                    var cartProducts = db.CartProducts.Where(cp => cp.CartId == cart.CartId);
                    db.CartProducts.RemoveRange(cartProducts);
                    db.Carts.Remove(cart);
                }

                // 保存所有数据库更改
                db.SaveChanges();

                // 5. 提示用户订单已成功
                MessageBox.Show("订单成功", "提示");

                UserHome userHome = new UserHome(_currentUser);
                this.Hide();
                userHome.Show();
            }
        }
    }
}
