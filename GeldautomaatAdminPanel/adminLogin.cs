using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminPanel.forms;
using GeldautomaatClassLibrary;

namespace AdminPanel
{
    public partial class adminLogin : Form
    {

        UserManagment userManagment = new UserManagment();
        PasswordConvert passwordConvert = new PasswordConvert();
        public adminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txbUsername.Text;
            string pincode = passwordConvert.ComputeSha256Hash(txbPassword.Text);

            if (userManagment.adminLogin(email, pincode))
            {
                var adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Hide();
                
            }
        }
    }
}
