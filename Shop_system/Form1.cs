using Shop_system.form;

namespace Shop_system
{
    public partial class Form1 : Form
    {
        public Form1()
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
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }

}