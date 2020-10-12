using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeldautomaatClassLibrary;

namespace Geldautomaat.forms
{
    public partial class UserDashboard : Form
    {
        UserActions userActions = new UserActions();
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            lblWelcomeMessage.Text = userActions.welcomeMessage();
        }

        private void btnCheckSaldo_Click(object sender, EventArgs e)
        {
            var userSaldo = new userSaldo();
            userSaldo.Show();
            this.Hide();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            var userDeposit = new userDeposit();
            userDeposit.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            var userHistory = new userHistory();
            userHistory.Show();
            this.Hide();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            var userWithdraw = new userWithdraw();
            userWithdraw.Show();
            this.Hide();
        }
    }

}
