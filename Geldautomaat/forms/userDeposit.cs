using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geldautomaat.msgForms;
using GeldautomaatClassLibrary;

namespace Geldautomaat.forms
{
    public partial class userDeposit : Form
    {
        UserActions userActions = new UserActions();
        public userDeposit()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
           

            if(userActions.deposit(txbAmount.Text))
            {
                var successDeposit = new successDeposit();
                successDeposit.Show();
                this.Hide();
            }

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var UserDashboard = new UserDashboard();
            UserDashboard.Show();
            this.Hide();
        }
    }
}
