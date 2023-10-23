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
    public partial class UserUpdateShipping : Form
    {
        private User _currentUser;

        private List<string> States = new List<string> { "NSW", "VIC", "ACT", "SA", "WA", "NT" };
        private string _address;
        private string _postcode;
        private string _suburb;
        private string _state;



        public UserUpdateShipping(User user)
        {
            InitializeComponent();
            comboBox1.DataSource = States;
            _currentUser = user;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _address = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _postcode = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            _suburb = textBox3.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _state = comboBox1.Text;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullAddress = string.Format("{0}, {1}, {2}, {3}", _address, _suburb, _state, _postcode);


            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text)
                && !string.IsNullOrEmpty(comboBox1.Text))
            {
                using (MyDbContext dbContext = new MyDbContext())
                {
                    User user = dbContext.Users.Find(_currentUser.UserId);
                    user.ShippingAddress = fullAddress;
                    dbContext.SaveChanges();

                    MessageBox.Show("Shipping information updated successfully.");

                    UserSettings userSettings = new UserSettings(_currentUser);
                    this.Hide();
                    userSettings.Show();

                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }
    }
}
