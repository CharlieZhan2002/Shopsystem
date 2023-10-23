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
    public partial class UserCheckout : Form
    {
        private User _currentUser;
        public UserCheckout(User user)
        {
            InitializeComponent();
            _currentUser = user;

        }


    }
}
