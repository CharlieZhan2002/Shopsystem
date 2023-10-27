
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
    public partial class UserUpdatePayment : Form
    {
        Customer _currentUser;
        List<Payment> _paymentList;
        UserCheckout _userCheckout;

        internal UserUpdatePayment(Customer customer)
        {
            _currentUser = customer;
            _paymentList = GetPaymentInfo();
            InitializeComponent();
            initialiseDataGrid();
        }

        // Used if updating information from user checkout
        internal UserUpdatePayment(Customer customer, UserCheckout userCheckout)
        {
            _currentUser = customer;
            _userCheckout = userCheckout;
            _paymentList = GetPaymentInfo();
            InitializeComponent();
            initialiseDataGrid();
        }

        private List<Payment> GetPaymentInfo()
        {
            using(MyDbContext db = new MyDbContext())
            {
                List<Payment> paymentsForUser = db.Payments.Where(p => p.UserId == _currentUser.UserId).ToList();
                return paymentsForUser;
            }
            
        }

        private void initialiseDataGrid()
        {
            if (_paymentList.Count == 0)
            {
                dataGridView1.Visible = false;
            }
            else
            {
                label3.Visible = false;

                dataGridView1.AutoGenerateColumns = false;

                // Define columns
                DataGridViewTextBoxColumn paymentId = new DataGridViewTextBoxColumn
                {
                    Name = "Payment Id",
                    DataPropertyName = "PaymentId",
                    HeaderText = "PaymentId",
                    Visible = false
                };

                DataGridViewTextBoxColumn holderName = new DataGridViewTextBoxColumn
                {
                    Name = "Holder name",
                    DataPropertyName = "CardName",
                    HeaderText = "Card Holder Name",
                    Visible = true
                };

                DataGridViewTextBoxColumn cardNumber = new DataGridViewTextBoxColumn
                {
                    Name = "Card Number",
                    DataPropertyName = "CardNum",
                    HeaderText = "Card Number",
                    Visible = true
                };

                DataGridViewTextBoxColumn cvv = new DataGridViewTextBoxColumn
                {
                    Name = "CVV",
                    DataPropertyName = "CVV",
                    HeaderText = "CVV",
                    Visible = true
                };

                dataGridView1.Columns.Add(paymentId);
                dataGridView1.Columns.Add(holderName);
                dataGridView1.Columns.Add(cardNumber);
                dataGridView1.Columns.Add(cvv);

                dataGridView1.DataSource = _paymentList;
            }
        }

        // Add payment method
        private void button1_Click(object sender, EventArgs e)
        {
            UserAddPayment addPayment = new UserAddPayment(_currentUser);
            this.Hide(); 
            addPayment.Show();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string valueInFirstColumn = selectedRow.Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you wish to delete this payment method?", "Confirmation", MessageBoxButtons.OKCancel);

                // Check the user's choice
                if (result == DialogResult.OK)
                {
                    using (MyDbContext db = new MyDbContext())
                    {
                        int uniqueIdentifier = int.Parse(valueInFirstColumn);

                        var recordToDelete = db.Payments.FirstOrDefault(record => record.PaymentId == uniqueIdentifier);

                        if (recordToDelete != null)
                        {
                            db.Payments.Remove(recordToDelete);
                            db.SaveChanges();

                            // Refresh the DataGridView
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = db.Payments.ToList();
                        }
                    }
                }

                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            else if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select one payment method row to delete.");
            }
            else
            {
                MessageBox.Show("You can only delete one payment method at a time.");
            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserSettings userSettings = new UserSettings(_currentUser);
            this.Hide();
            userSettings.Show();
        }
    }
}
