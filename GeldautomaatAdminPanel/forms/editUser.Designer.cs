namespace AdminPanel.forms
{
    partial class editUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.txbPlaats = new System.Windows.Forms.TextBox();
            this.txbPostcode = new System.Windows.Forms.TextBox();
            this.txbAdress = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbBSN = new System.Windows.Forms.TextBox();
            this.txbSex = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnResetPin = new System.Windows.Forms.Button();
            this.btnBlockUser = new System.Windows.Forms.Button();
            this.btnUnblockUser = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.CustomFormat = "yyyy/MM/dd";
            this.dtpBirthDay.Location = new System.Drawing.Point(115, 99);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(100, 20);
            this.dtpBirthDay.TabIndex = 19;
            this.dtpBirthDay.Value = new System.DateTime(2020, 10, 7, 0, 0, 0, 0);
            // 
            // txbPlaats
            // 
            this.txbPlaats.Location = new System.Drawing.Point(115, 246);
            this.txbPlaats.Name = "txbPlaats";
            this.txbPlaats.Size = new System.Drawing.Size(169, 20);
            this.txbPlaats.TabIndex = 18;
            // 
            // txbPostcode
            // 
            this.txbPostcode.Location = new System.Drawing.Point(358, 201);
            this.txbPostcode.Name = "txbPostcode";
            this.txbPostcode.Size = new System.Drawing.Size(100, 20);
            this.txbPostcode.TabIndex = 17;
            // 
            // txbAdress
            // 
            this.txbAdress.Location = new System.Drawing.Point(115, 197);
            this.txbAdress.Name = "txbAdress";
            this.txbAdress.Size = new System.Drawing.Size(169, 20);
            this.txbAdress.TabIndex = 16;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(358, 144);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(183, 20);
            this.txbLastName.TabIndex = 15;
            // 
            // txbBSN
            // 
            this.txbBSN.Location = new System.Drawing.Point(358, 102);
            this.txbBSN.Name = "txbBSN";
            this.txbBSN.Size = new System.Drawing.Size(183, 20);
            this.txbBSN.TabIndex = 14;
            // 
            // txbSex
            // 
            this.txbSex.Location = new System.Drawing.Point(358, 51);
            this.txbSex.Name = "txbSex";
            this.txbSex.Size = new System.Drawing.Size(100, 20);
            this.txbSex.TabIndex = 13;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(115, 144);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(169, 20);
            this.txbFirstName.TabIndex = 12;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(115, 51);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(169, 20);
            this.txbEmail.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(115, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Aanpassingen opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnResetPin
            // 
            this.btnResetPin.Location = new System.Drawing.Point(115, 330);
            this.btnResetPin.Name = "btnResetPin";
            this.btnResetPin.Size = new System.Drawing.Size(175, 27);
            this.btnResetPin.TabIndex = 21;
            this.btnResetPin.Text = "Pincode herstel";
            this.btnResetPin.UseVisualStyleBackColor = true;
            this.btnResetPin.Click += new System.EventHandler(this.btnResetPin_Click);
            // 
            // btnBlockUser
            // 
            this.btnBlockUser.Location = new System.Drawing.Point(358, 328);
            this.btnBlockUser.Name = "btnBlockUser";
            this.btnBlockUser.Size = new System.Drawing.Size(175, 29);
            this.btnBlockUser.TabIndex = 22;
            this.btnBlockUser.Text = "Blokkeer rebruiker";
            this.btnBlockUser.UseVisualStyleBackColor = true;
            this.btnBlockUser.Click += new System.EventHandler(this.btnBlockUser_Click);
            // 
            // btnUnblockUser
            // 
            this.btnUnblockUser.Location = new System.Drawing.Point(358, 363);
            this.btnUnblockUser.Name = "btnUnblockUser";
            this.btnUnblockUser.Size = new System.Drawing.Size(175, 28);
            this.btnUnblockUser.TabIndex = 23;
            this.btnUnblockUser.Text = "Deblokkeer gebruiker";
            this.btnUnblockUser.UseVisualStyleBackColor = true;
            this.btnUnblockUser.Click += new System.EventHandler(this.btnUnblockUser_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(596, 331);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(175, 26);
            this.btnRemoveUser.TabIndex = 24;
            this.btnRemoveUser.Text = "Verwijder gebruiker";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Geslacht: (Man, Vrouw)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Geboorte datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "BSN nummer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Voornaam:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Achternaam:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Woonplaats:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Postcode:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Address:";
            // 
            // editUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnUnblockUser);
            this.Controls.Add(this.btnBlockUser);
            this.Controls.Add(this.txbPostcode);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.btnResetPin);
            this.Controls.Add(this.dtpBirthDay);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbSex);
            this.Controls.Add(this.txbAdress);
            this.Controls.Add(this.txbPlaats);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.txbBSN);
            this.Name = "editUser";
            this.Text = "editUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.TextBox txbPlaats;
        private System.Windows.Forms.TextBox txbPostcode;
        private System.Windows.Forms.TextBox txbAdress;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TextBox txbBSN;
        private System.Windows.Forms.TextBox txbSex;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnResetPin;
        private System.Windows.Forms.Button btnBlockUser;
        private System.Windows.Forms.Button btnUnblockUser;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}