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
    public partial class userWithdraw : Form
    {
        UserActions userActions = new UserActions();
        public userWithdraw()
        {
            InitializeComponent();
        }

        private void btnWithdraw1_Click(object sender, EventArgs e)
        {
            passTrough(userActions.userWithdraw("5"));
        }

        private void btnWithdraw2_Click(object sender, EventArgs e)
        {
            passTrough(userActions.userWithdraw("10"));
        }

        private void btnWithdraw3_Click(object sender, EventArgs e)
        {
            passTrough(userActions.userWithdraw("20"));
        }

        private void btnWithdraw4_Click(object sender, EventArgs e)
        {
            passTrough(userActions.userWithdraw("50"));
        }

        private void btnWithdraw5_Click(object sender, EventArgs e)
        {
            passTrough(userActions.userWithdraw("100"));
        }

        private void btnWithdraw6_Click(object sender, EventArgs e)
        {
            passTrough(userActions.userWithdraw("150"));
        }

        private void btnWithdraw7_Click(object sender, EventArgs e)
        {
            passTrough(userActions.userWithdraw("200"));
        }

        private void passTrough(string msg)
        {
            if (msg == "bill")
            {
                var withdrawBill = new withdrawBill();
                withdrawBill.Show();
                this.Hide();
            }
            else if (msg == "noMoney") {
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
            var userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }

        private void btnToCustom(object sender, EventArgs e)
        {
            var userWithdrawCustom = new userWithdrawCustom();
            userWithdrawCustom.Show();
            this.Hide();
        }
    }
}
