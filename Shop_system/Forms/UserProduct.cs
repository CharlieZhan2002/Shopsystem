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
    public partial class UserProduct : Form
    {
        private User _currentUser;
        private List<Product> _products;


        public UserProduct(User user)
        {

            _currentUser = user;
            InitializeComponent();
            label2.Text = "Current user: " + _currentUser.Username;
            _products = GetProducts();
            //DisplayProductNames();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DisplayProductNames()
        {
            foreach (Product product in _products)
            {
                listBox1.Items.Add(product.Name);
            }
        }

        private List<Product> GetProducts()
        {
            using (MyDbContext context = new MyDbContext())
            {
                List<Product> products = context.Products.ToList();
                return products;
            }
        }
    }
}
