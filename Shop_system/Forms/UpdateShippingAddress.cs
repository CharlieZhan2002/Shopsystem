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
    public partial class UpdateShippingAddress : Form
    {

        private string _street;
        private string _city;
        private string _state;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _street= textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _city= textBox2.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
