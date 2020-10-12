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

namespace Geldautomaat.msgForms
{
    public partial class withdrawDisplay : Form
    {
        UserActions userActions = new UserActions();
        public withdrawDisplay()
        {
            InitializeComponent();
        }

        private void withdrawDisplay_Load(object sender, EventArgs e)
        {
            lblMsg.Text = userActions.withdrawMsg(); 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var userDashboard = new forms.UserDashboard();
            userDashboard.Show();
            this.Hide();
        }
    }
}
