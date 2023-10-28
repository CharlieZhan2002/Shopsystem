using Shop_system.Model;

namespace Shop_system.Forms
{
    public partial class Login : Form
    {
        private string Username;
        private string Password;

        public Login()
        {
            InitializeComponent();
            label5.Text = string.Empty;
            this.VisibleChanged += Login_VisibleChanged;
        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                label5.Text = string.Empty; 
                label5.ForeColor = Color.Black; 
            }
        }

        private User FindUser()
        {
            using (var context = new MyDbContext())
            {
                return context.Users.FirstOrDefault(u => u.Username == Username && u.PasswordHash == Password);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Username = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Password = textBox2.Text;
        }

        private void ClearFields()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label5.ForeColor= Color.Black;
            label5.Text = "Logging in...";
            Cursor = Cursors.WaitCursor;

            User foundUser = await Task.Run(() => FindUser());

            if (foundUser != null)
            {
                if (foundUser is Admin)
                {
                    AdminDashboard adminDashboard = new AdminDashboard(foundUser.Username, foundUser.Role);
                    adminDashboard.Show();
                    this.Hide();
                    ClearFields();
                }
                else if (foundUser is Customer)
                {
                    UserHome userHome = new UserHome((Customer)foundUser);
                    userHome.Show();
                    this.Hide();
                    ClearFields();
                }
                else if (foundUser is Manager)
                {
                    ManagerDashboard managerDashboard = new ManagerDashboard(foundUser.Username, foundUser.Role);
                    managerDashboard.Show();
                    this.Hide();
                    ClearFields();
                }
            }
            else
            {
                label5.ForeColor = Color.Red;
                label5.Text = "Details incorrect. Try again.";
            }

            Cursor = Cursors.Default;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddcustomerForm addCustomerForm = new AddcustomerForm();
            addCustomerForm.Show();
        }

    }
}