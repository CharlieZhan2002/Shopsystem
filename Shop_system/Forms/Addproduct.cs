using Microsoft.EntityFrameworkCore;
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
    public partial class Addproduct : Form
    {
        private MyDbContext _context;
        public Addproduct()
        {
            InitializeComponent();
            _context = new MyDbContext();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cmbCategory.DataSource = _context.ProductCategories.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text) ||
               string.IsNullOrEmpty(txtPrice.Text) ||
               string.IsNullOrEmpty(txtStock.Text) ||
               cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                Product product = new Product
                {
                    ProductName = txtProductName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Stock = int.Parse(txtStock.Text),
                    CategoryId = (int)cmbCategory.SelectedValue
                };

                _context.Products.Add(product);
                _context.SaveChanges();

                MessageBox.Show("Product added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
