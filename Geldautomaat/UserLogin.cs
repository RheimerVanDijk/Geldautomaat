using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geldautomaat.forms;
using GeldautomaatClassLibrary;

namespace Geldautomaat
{
    public partial class UserLogin : Form
    {
        UserActions userActions = new UserActions();
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string acc_number = txbAccountNr.Text;
            string pin = txbPincode.Text;

            if (userActions.userLogin(acc_number, pin))
            {
                var userDashboard = new UserDashboard();
                userDashboard.Show();
                this.Hide();
            }
        }
    }
}
