using Geldautomaat.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geldautomaat.msgForms
{
    public partial class withdrawBill : Form
    {
        public withdrawBill()
        {
            InitializeComponent();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            var userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }

        private void btnNoBill_Click(object sender, EventArgs e)
        {
            var userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }
    }
}
