using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_system.Model;

namespace Shop_system.Forms
{
    public partial class ProductManagement : Form
    {
        private MyDbContext _context;
        public ProductManagement()
        {
            InitializeComponent();
            _context = new MyDbContext();

            LoadCategories();
            LoadProducts();
        }

        private void LoadCategories()
        {
            cmbCategories.DataSource = _context.ProductCategories.ToList();
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryId";
            cmbCategories.SelectedIndex = -1;
        }

        private void LoadProducts()
        {
            var products = _context.Products.ToList();

            if (cmbCategories.SelectedIndex != -1 && cmbCategories.SelectedValue is int selectedCategoryId)
            {
                products = products.Where(p => p.CategoryId == selectedCategoryId).ToList();
            }

            dataGridViewProducts.DataSource = products;
        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            Addproduct addproduct = new Addproduct();
            addproduct.ShowDialog();
        }

        private void btnDeleteProduct_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            var selectedProduct = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;

            _context.Products.Remove(selectedProduct);
            _context.SaveChanges();

            LoadProducts();
        }

        private void cmbCategories_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
