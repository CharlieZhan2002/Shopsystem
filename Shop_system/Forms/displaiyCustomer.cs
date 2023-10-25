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
    public partial class displaiyCustomer : Form
    {
        public displaiyCustomer()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            using (var context = new MyDbContext())
            {
                var allUsers = context.Users.ToList(); // First, get all users from the database.
                var customers = allUsers.OfType<Customer>().ToList(); // Then, filter them in memory.
                dataGridViewCustomers.DataSource = customers;
            }
        }
    }
}
