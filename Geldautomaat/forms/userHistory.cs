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
    public partial class userHistory : Form
    {
        UserActions userActions = new UserActions();
        public userHistory()
        {
            InitializeComponent();
        }

        private void userHistory_Load(object sender, EventArgs e)
        {
            userActions.transactionHistory(dgvHistory);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }
    }
}
