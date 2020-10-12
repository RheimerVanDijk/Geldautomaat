using GeldautomaatClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.forms
{
    public partial class addUser : Form
    {
        UserManagment userManagment = new UserManagment();
        public addUser()
        {
            InitializeComponent();

            dtpBirthDay.Format = DateTimePickerFormat.Custom;
            dtpBirthDay.CustomFormat = "yyyy/MM/dd";
        }

        private void btnOpenRekening_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Text;
            string sex = txbSex.Text;
            System.DateTime birthday = dtpBirthDay.Value;
            int bsn = Convert.ToInt32(txbBSN.Text);
            string firstName = txbFirstName.Text;
            string lastName = txbLastName.Text;
            string address = txbAdress.Text;
            string postcode = txbPostcode.Text;
            string plaats = txbPlaats.Text;

            if(userManagment.createUser(email, sex, birthday, bsn, firstName, lastName, address, postcode, plaats))
            {
                var adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }
    }
}
