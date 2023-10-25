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
    public partial class OOSlist : Form
    {
        private MyDbContext _context;
        private List<Product> zeroStockProducts;
        public OOSlist()
        {
            InitializeComponent();
            _context = new MyDbContext();
            LoadZeroStockProducts();
        }

        private void LoadZeroStockProducts()
        {
            zeroStockProducts = _context.Products.Where(p => p.Stock == 0).ToList();
            listBox1.DataSource = zeroStockProducts;
            listBox1.DisplayMember = "ProductName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedProducts = listBox1.SelectedItems;

            int addedStockValue = (int)numericUpDown1.Value;

            foreach (Product selectedProduct in selectedProducts)
            {
                selectedProduct.Stock += addedStockValue;
                _context.SaveChanges();
            }

            LoadZeroStockProducts();
        }
    }
}
