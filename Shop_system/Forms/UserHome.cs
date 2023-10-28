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
    public partial class UserHome : Form, IDisplaysDataCustomer
    {
        private Customer _currentUser;

        internal UserHome(Customer user)
        {
            InitializeComponent();
            _currentUser = user;

            label2.Text = "Current user: " + _currentUser.Username;
            Helper.UpdateCartButtonText(_currentUser, button3);
            CheckForShoppingHistory();
        }

        // Navigate to order product form
        private void button2_Click(object sender, EventArgs e)
        {
            UserProduct destination = new UserProduct(_currentUser);

            Helper.NavigateNextWindowCustomer(this, destination);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserSettings destination = new UserSettings(_currentUser);

            Helper.NavigateNextWindowCustomer(this, destination);
        }
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

        // Inherited from interface
        public void ConfigureGridView<T>(List<T> items)
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

            dataGridView1.DataSource = items;


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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["ViewOrder"].Index && e.RowIndex >= 0)
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                if (value is int)
                {
                    int orderId = (int)value;

                    UserViewOrder destination = new UserViewOrder(orderId, _currentUser);
                    Helper.NavigateNextWindowCustomer(this, destination);
                }
            }


        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
