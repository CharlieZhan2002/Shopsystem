using Shop_system.Forms;

namespace Shop_system.Forms
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

        private void button6_Click(object sender, EventArgs e)
        {
            addManagerform AddManagerform = new addManagerform();
            AddManagerform.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            displaiyCustomer displaiyCustomer = new displaiyCustomer();
            displaiyCustomer.ShowDialog();
        }
    }

}