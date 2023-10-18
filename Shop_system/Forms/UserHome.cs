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

namespace app_dev_dotNet_AT2.Forms
{
    public partial class UserHome : Form
    {
        private User _currentUser;

        public UserHome(User user)
        {
            _currentUser = user;
            InitializeComponent();
            label2.Text = "Current user: " + _currentUser.Username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Order product
        private void button2_Click(object sender, EventArgs e)
        {
            UserProduct userProduct = new UserProduct(_currentUser);
            this.Hide();
            userProduct.Show();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserSettings usersettings = new UserSettings(_currentUser);
            this.Hide();
            usersettings.Show();
        }
    }
}
