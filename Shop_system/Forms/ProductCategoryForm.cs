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
    public partial class ProductCategoryForm : Form
    {
        private MyDbContext _context;
        public ProductCategoryForm()
        {
            InitializeComponent();
            _context = new MyDbContext();

            LoadCategories();
        }

        private void LoadCategories()
        {
            lstCategories.DataSource = null;  // refresh
            lstCategories.DataSource = _context.ProductCategories.ToList();
            lstCategories.DisplayMember = "CategoryName";
            lstCategories.ValueMember = "CategoryId";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string newCategoryName = txtCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(newCategoryName))
            {
                MessageBox.Show("Please enter a valid category name！");
                return;
            }

            var existingCategory = _context.ProductCategories.FirstOrDefault(c => c.CategoryName == newCategoryName);
            if (existingCategory != null)
            {
                MessageBox.Show("This category already exists！");
                return;
            }

            var newCategory = new ProductCategory { CategoryName = newCategoryName };
            _context.ProductCategories.Add(newCategory);
            _context.SaveChanges();

            LoadCategories();  // updateview
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedCategory = lstCategories.SelectedItem as ProductCategory;
            if (selectedCategory == null)
            {
                MessageBox.Show("Please select a category to delete！");
                return;
            }

            // Check if there are any products in this category
            var productsInCategory = _context.Products.Where(p => p.CategoryId == selectedCategory.CategoryId).ToList();
            if (productsInCategory.Count > 0)
            {
                MessageBox.Show("You cannot delete this category because there are still items under it！");
                return;
            }

            _context.ProductCategories.Remove(selectedCategory);
            _context.SaveChanges();

            LoadCategories();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }
    }
}
