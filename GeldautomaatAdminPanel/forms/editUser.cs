using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeldautomaatClassLibrary;
using MySql.Data.MySqlClient;

namespace AdminPanel.forms
{
    public partial class editUser : Form
    {
        UserManagment userManagment = new UserManagment();
        Database database = new Database();
        public editUser()
        {
            InitializeComponent();
            dtpBirthDay.Format = DateTimePickerFormat.Custom;
            dtpBirthDay.CustomFormat = "yyyy/MM/dd";
        }

        private string recordID;

        public void fillData(string id)
        {
            recordID = id;

            TextBox email = txbEmail;
            TextBox sex = txbSex;
            DateTimePicker birthday = dtpBirthDay;
            TextBox bsn = txbBSN;
            TextBox firstName = txbFirstName;
            TextBox lastName = txbLastName;
            TextBox address = txbAdress;
            TextBox postcode = txbPostcode;
            TextBox plaats = txbPlaats;

            userManagment.FillEditUser(recordID, email, sex, birthday, bsn, firstName, lastName, address, postcode, plaats);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
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

            userManagment.updateUser(email, sex, birthday, bsn, firstName, lastName, address, postcode, plaats, recordID);
        }

        private void btnResetPin_Click(object sender, EventArgs e)
        {
            userManagment.resetPin(recordID);
        }

        private void btnBlockUser_Click(object sender, EventArgs e)
        {
            userManagment.setUserBlock(recordID, "1");
        }

        private void btnUnblockUser_Click(object sender, EventArgs e)
        {
            userManagment.setUserBlock(recordID, "0");
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (userManagment.removeUser(recordID))
            {
                var viewUsers = new viewUsers();
                viewUsers.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var viewUsers = new viewUsers();
            viewUsers.Show();
            this.Hide();
        }
    }
}
