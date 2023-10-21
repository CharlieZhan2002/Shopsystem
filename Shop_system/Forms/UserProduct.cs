﻿using Microsoft.EntityFrameworkCore;
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

namespace Shop_system.form
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
            LoadProductsIntoDataGridView();

        }

        private void LoadProductsIntoDataGridView()
        {
            using (MyDbContext context = new MyDbContext())
            {
                var products = context.Products.Include(p => p.Category).ToList();

                dataGridView1.DataSource = products.Select(p => new
                {
                    p.ProductId,
                    p.ProductName,
                    p.Price,
                    Category = p.Category.CategoryName
                }).ToList();

                dataGridView1.Columns["ProductId"].HeaderText = "Product ID";
                dataGridView1.Columns["ProductName"].HeaderText = "Product Name";
                dataGridView1.Columns["Price"].HeaderText = "Price";
                dataGridView1.Columns["Category"].HeaderText = "Category";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DisplayProductNames()
        {
            foreach (Product product in _products)
            {
                listBox1.Items.Add(product.ProductName);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
