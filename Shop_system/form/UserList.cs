using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_system.form
{
    public partial class UserList : Form
    {
        private UserContext _context;

        public UserList()
        {
            InitializeComponent();
            _context = new UserContext();
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
                dtUsers.Columns.Add("Email");  // Adding an Email column
                dtUsers.Columns.Add("Role");

                foreach (var user in users)
                {
                    dtUsers.Rows.Add(user.UserId, user.Username, user.Email, user.Role.ToString());  // Use the Email property
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

