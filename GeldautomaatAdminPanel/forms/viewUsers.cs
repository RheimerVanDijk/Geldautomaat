using GeldautomaatClassLibrary;
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
    public partial class viewUsers : Form
    {
        UserManagment userManagment = new UserManagment();
        public viewUsers()
        {
            InitializeComponent();
        }

        private void viewUsers_Load(object sender, EventArgs e)
        {
            userManagment.GetAllUsers(dgvUsers);

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var editUser = new editUser();
                string rowID = dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                editUser.fillData(rowID);
                editUser.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string username = txbName.Text;
            string accountNumber = txbAccountNumber.Text;

            if (username == "" && accountNumber == "")
            {
                userManagment.GetAllUsers(dgvUsers);
            } else
            {
                userManagment.searchUser(username, accountNumber, dgvUsers);

            }
        }
    }
}
