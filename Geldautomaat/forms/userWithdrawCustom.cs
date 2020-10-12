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
    public partial class userWithdrawCustom : Form
    {
        UserActions userActions = new UserActions();
        public userWithdrawCustom()
        {
            InitializeComponent();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txbWithdrawAmount.Text) > 500)
            {
                userActions.setWithdrawMsg("U kunt niet meer openemen dan 500 euro");
                var withdrawDisplay = new msgForms.withdrawDisplay();
                withdrawDisplay.Show();
                this.Hide();
            } else
            {
                userActions.userWithdraw(txbWithdrawAmount.Text);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var userWithdraw = new userWithdraw();
            userWithdraw.Show();
            this.Hide();
        }
    }
}
