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
    public partial class UserAddPayment : Form
    {
        List<string> months = new List<string> { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
        List<string> years = new List<string> { "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030" };

        private string _name;
        private long _cardNo;
        private string _expiryMonth;
        private string _expiryYear;
        private int _cvv;
        private User _currentUser;

        public UserAddPayment(User user)
        {
            InitializeComponent();
            comboBox1.DataSource = months;
            comboBox2.DataSource = years;
            _expiryMonth = comboBox1.Text; // In case the user does not change these values.
            _expiryYear = comboBox2.Text;
            _currentUser = user;
        }
        // Submit button
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;

            int currentYear = currentDate.Year;
            int currentMonth = currentDate.Month;

            int expiryYear = int.Parse(_expiryYear);
            int expiryMonth = int.Parse(_expiryMonth);

            if (string.IsNullOrEmpty(textBox1.Text) || !long.TryParse(textBox2.Text, out _cardNo))
            {
                MessageBox.Show("One of the mandatory fields is empty");
                return;
            }

            /*if (_cardNo.ToString().Length < 13 || _cardNo.ToString().Length > 19)
            {
                MessageBox.Show("Invalid card number length. Please check.");
                return;
            } */

            if (expiryYear < currentYear || (expiryYear == currentYear && expiryMonth < currentMonth))
            {
                MessageBox.Show("Card has expired. " + currentYear + " " + expiryYear + " " + currentMonth + " " + expiryYear);
                return;
            }

            Payment newPayment = new Payment
            {
                UserId = _currentUser.UserId,
                CardName = _name,
                CardNum = _cardNo,
                CVV = _cvv,
                ExpiryMonth = _expiryMonth,
                ExpiryYear = _expiryYear
            };

            using (MyDbContext db = new MyDbContext())
            {

                db.Payments.Add(newPayment);
                db.SaveChanges();
            }

            MessageBox.Show("Payment added successfully.");

            ClearFormFields();
        }

        private void ClearFormFields()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;

        }

        // Name on card textbox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                _cardNo = long.Parse(textBox2.Text);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _expiryMonth = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _expiryYear = comboBox2.Text;
        }

        // So only numbers can be entered.
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != string.Empty)
            {
                _cvv = Convert.ToInt32(textBox3.Text);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserUpdatePayment userUpdatePayment = new UserUpdatePayment(_currentUser);
            this.Hide();
            userUpdatePayment.Show();
        }
    }
}
