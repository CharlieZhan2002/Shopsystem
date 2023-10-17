using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_system.Model;

namespace Shop_system.form
{
    public partial class UserList : Form
    {
        private MyDbContext _context;

        public UserList()
        {
            InitializeComponent();
            _context = new MyDbContext();
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                // Query all users from the database using Entity Framework
                var users = _context.Users.ToList();

                // Use a DataTable as a data source for the DataGridView
                DataTable dtUsers = new DataTable();
                dtUsers.Columns.Add("UserID");
                dtUsers.Columns.Add("Username");
                dtUsers.Columns.Add("Password");
                dtUsers.Columns.Add("Role");

                foreach (var user in users)
                {
                    dtUsers.Rows.Add(user.UserId, user.Username, user.PasswordHash, user.Role.ToString());
                }

                dataGridViewUsers.DataSource = dtUsers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
}
