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
                passTrough(userActions.userWithdraw(txbWithdrawAmount.Text));
            }
        }

        private void passTrough(string msg)
        {
            if (msg == "bill")
            {
                var withdrawBill = new withdrawBill();
                withdrawBill.Show();
                this.Hide();
            }
            else if (msg == "noMoney")
            {
                userActions.setWithdrawMsg("Niet genoeg geld op je rekening.");
                toWithdrawDisplay();
            }
            else if (msg == "toMany")
            {
                userActions.setWithdrawMsg("U heeft uw max van 3 opnamens behaald deze dag.");
                toWithdrawDisplay();
            }
            else if (msg == "error")
            {
                userActions.setWithdrawMsg("OHNEE ER IS IETS FOUT.");
                toWithdrawDisplay();
            }
        }

        private void toWithdrawDisplay()
        {
            var withdrawDisplay = new withdrawDisplay();
            withdrawDisplay.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var userWithdraw = new userWithdraw();
            userWithdraw.Show();
            this.Hide();
        }
    }
}
