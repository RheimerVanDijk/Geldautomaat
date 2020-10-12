using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.forms
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var addUser = new addUser();

            addUser.Show();
            this.Hide();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            var viewUsers = new viewUsers();

            viewUsers.Show();
            this.Hide();
        }
    }
}
