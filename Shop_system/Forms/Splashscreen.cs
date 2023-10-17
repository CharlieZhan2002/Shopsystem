using app_dev_dotNet_AT2.Forms;
using Shop_system.form;

namespace Shop_system
{
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addadminform addAdminForm = new addadminform();
            addAdminForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddcustomerForm addCustomerForm = new AddcustomerForm();
            addCustomerForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserList UserListForm = new UserList();
            UserListForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }
    }

}