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
    public partial class userSaldo : Form
    {
        UserActions userActions = new UserActions();

        public userSaldo()
        {
            InitializeComponent();
        }

        private void userSaldo_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = userActions.returnSaldo();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var userDashbaord = new UserDashboard();
            userDashbaord.Show();
            this.Hide();
        }
    }
}
