using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
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
            // Load categories from database
            var categories = _context.ProductCategories.ToList();

            // Add an "all" option
            categories.Insert(0, new ProductCategory { CategoryId = -1, CategoryName = "All" });

            cmbCategories.DataSource = categories;
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryId";
            cmbCategories.SelectedIndex = 0; // Default to "All"
        }

        private void LoadProducts()
        {
            var products = _context.Products.ToList();
            foreach (DataGridViewColumn column in dataGridViewProducts.Columns)
            {
                if (column.Name != "Price")
                {
                    column.ReadOnly = true;
                }
            }
            //Undo all unchanged changes
            _context.ChangeTracker.Entries().Where(e => e.State == EntityState.Modified).ToList().ForEach(e => e.Reload());
            // If a category other than "all" is selected, filter products by that category
            if (cmbCategories.SelectedValue is int selectedCategoryId && selectedCategoryId != -1)
            {
                products = products.Where(p => p.CategoryId == selectedCategoryId).ToList();
            }

            dataGridViewProducts.DataSource = products;
            // Hide unwanted columns
            if (dataGridViewProducts.Columns["CategoryId"] != null)
                dataGridViewProducts.Columns["CategoryId"].Visible = false;
            if (dataGridViewProducts.Columns["OrderProducts"] != null)
                dataGridViewProducts.Columns["OrderProducts"].Visible = false;
            if (dataGridViewProducts.Columns["CartProducts"] != null)
                dataGridViewProducts.Columns["CartProducts"].Visible = false;
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
            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                var editedProduct = (Product)row.DataBoundItem;
                var productInDb = _context.Products.FirstOrDefault(p => p.ProductId == editedProduct.ProductId);
                if (productInDb != null && productInDb.Price != editedProduct.Price)
                {
                    productInDb.Price = editedProduct.Price;
                }
            }

            _context.SaveChanges();
            LoadProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dataGridViewProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewProducts.Columns["Price"].Index && e.RowIndex >= 0)
            {
                var editedProduct = (Product)dataGridViewProducts.Rows[e.RowIndex].DataBoundItem;

                // 验证：确保价格不是负数或零
                if (editedProduct.Price <= 0)
                {
                    MessageBox.Show("价格不能为零或负数。", "无效输入", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // 为了让DataGridView恢复到有效状态，我们恢复原始的价格
                    editedProduct.Price = _context.Products.FirstOrDefault(p => p.ProductId == editedProduct.ProductId)?.Price ?? 0;
                    dataGridViewProducts.Refresh();
                }
            }
        }

    }
}
