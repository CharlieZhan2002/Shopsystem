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

namespace Shop_system.Forms
{
    public partial class UserViewOrder : Form
    {
        private int _orderId;
        private Customer _currentUser;

        internal UserViewOrder(int orderId, Customer customer)
        {
            InitializeComponent();
            _orderId = orderId;
            _currentUser = customer;
            ConfigureGridView();
            label1.Text = $"Order #{orderId}";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserHome userHome = new UserHome(_currentUser);
            this.Hide();
            userHome.Show();
        }

        private void ConfigureGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            List<OrderProduct> orderProducts = new List<OrderProduct>();
            List<OrderProductViewModel> dataGridViewModel = new List<OrderProductViewModel>();

            using (MyDbContext db = new MyDbContext())
            {
                orderProducts = db.OrderProducts
                .Include(op => op.Product)
                .Where(x => x.OrderId == _orderId)
                .ToList();
            }

            MessageBox.Show(orderProducts[0].Product.ProductName);

            foreach (OrderProduct orderProduct in orderProducts)
            {
                OrderProductViewModel orderProductViewModel = new OrderProductViewModel
                {
                    ProductName = orderProduct.Product.ProductName,
                    Price = orderProduct.Product.Price,
                    Quantity = orderProduct.ProductQuantity,
                    ItemTotal = orderProduct.Product.Price * orderProduct.ProductQuantity
                };

                dataGridViewModel.Add(orderProductViewModel);
            }

            DataGridViewTextBoxColumn ProductName = new DataGridViewTextBoxColumn
            {
                Name = "ProductName",
                DataPropertyName = "ProductName",
                HeaderText = "Product Name",
                Visible = true
            };

            DataGridViewTextBoxColumn Price = new DataGridViewTextBoxColumn
            {
                Name = "Price",
                DataPropertyName = "Price",
                HeaderText = "Price",
                Visible = true
            };

            DataGridViewTextBoxColumn Quantity = new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                DataPropertyName = "Quantity",
                HeaderText = "Quantity",
                Visible = true
            };

            DataGridViewTextBoxColumn ItemTotal = new DataGridViewTextBoxColumn
            {
                Name = "ItemTotal",
                DataPropertyName = "ItemTotal",
                HeaderText = "Item Total",
                Visible = true
            };

            dataGridView1.Columns.Add(ProductName);
            dataGridView1.Columns.Add(Price);
            dataGridView1.Columns.Add(Quantity);
            dataGridView1.Columns.Add(ItemTotal);

            dataGridView1.DataSource = dataGridViewModel;


        }
    }
}
