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
    public partial class stockcontrol : Form
    {
        private MyDbContext _context;

        private void LoadData()
        {
            dataGridView1.DataSource = _context.Products.ToList();
            dataGridView2.DataSource = _context.Products.ToList();
        }
        public stockcontrol()
        {
            InitializeComponent();
            _context = new MyDbContext();
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            if (numericUpDown.Value > 0) // Checking if the value is positive
            {
                numericUpDown.Value = 0; // Resetting to the maximum allowed value (0 in this case)
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the products you'd like to stock up on！");
                return;
            }
            var selectedProduct = dataGridView1.SelectedRows[0].DataBoundItem as Product;
            int quantityToAdd = (int)numericUpDown1.Value;
            selectedProduct.Stock += quantityToAdd;
            _context.SaveChanges();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the products you'd like to return！");
                return;
            }
            var selectedProduct = dataGridView2.SelectedRows[0].DataBoundItem as Product;
            int quantityToReturn = (int)numericUpDown2.Value;
            if (quantityToReturn > selectedProduct.Stock)
            {
                MessageBox.Show("The return quantity cannot exceed current inventory！");
                return;
            }
            selectedProduct.Stock -= quantityToReturn;
            _context.SaveChanges();
            LoadData();
        }
    }
}
