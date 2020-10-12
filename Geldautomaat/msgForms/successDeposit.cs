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
    public partial class successDeposit : Form
    {
        public successDeposit()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var userDeposit = new UserDashboard();
            userDeposit.Show();
            this.Hide();
        }
    }
}
