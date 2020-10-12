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
            this.SuspendLayout();
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.CustomFormat = "yyyy/MM/dd";
            this.dtpBirthDay.Location = new System.Drawing.Point(36, 79);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(100, 20);
            this.dtpBirthDay.TabIndex = 19;
            this.dtpBirthDay.Value = new System.DateTime(2020, 10, 7, 0, 0, 0, 0);
            // 
            // txbPlaats
            // 
            this.txbPlaats.Location = new System.Drawing.Point(36, 195);
            this.txbPlaats.Name = "txbPlaats";
            this.txbPlaats.Size = new System.Drawing.Size(100, 20);
            this.txbPlaats.TabIndex = 18;
            // 
            // txbPostcode
            // 
            this.txbPostcode.Location = new System.Drawing.Point(210, 169);
            this.txbPostcode.Name = "txbPostcode";
            this.txbPostcode.Size = new System.Drawing.Size(100, 20);
            this.txbPostcode.TabIndex = 17;
            // 
            // txbAdress
            // 
            this.txbAdress.Location = new System.Drawing.Point(36, 169);
            this.txbAdress.Name = "txbAdress";
            this.txbAdress.Size = new System.Drawing.Size(100, 20);
            this.txbAdress.TabIndex = 16;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(210, 105);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(100, 20);
            this.txbLastName.TabIndex = 15;
            // 
            // txbBSN
            // 
            this.txbBSN.Location = new System.Drawing.Point(210, 79);
            this.txbBSN.Name = "txbBSN";
            this.txbBSN.Size = new System.Drawing.Size(100, 20);
            this.txbBSN.TabIndex = 14;
            // 
            // txbSex
            // 
            this.txbSex.Location = new System.Drawing.Point(210, 53);
            this.txbSex.Name = "txbSex";
            this.txbSex.Size = new System.Drawing.Size(100, 20);
            this.txbSex.TabIndex = 13;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(36, 105);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(100, 20);
            this.txbFirstName.TabIndex = 12;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(36, 53);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(100, 20);
            this.txbEmail.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(98, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Aanpassingen opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnResetPin
            // 
            this.btnResetPin.Location = new System.Drawing.Point(98, 300);
            this.btnResetPin.Name = "btnResetPin";
            this.btnResetPin.Size = new System.Drawing.Size(175, 27);
            this.btnResetPin.TabIndex = 21;
            this.btnResetPin.Text = "Pincode herstel";
            this.btnResetPin.UseVisualStyleBackColor = true;
            this.btnResetPin.Click += new System.EventHandler(this.btnResetPin_Click);
            // 
            // btnBlockUser
            // 
            this.btnBlockUser.Location = new System.Drawing.Point(98, 333);
            this.btnBlockUser.Name = "btnBlockUser";
            this.btnBlockUser.Size = new System.Drawing.Size(175, 29);
            this.btnBlockUser.TabIndex = 22;
            this.btnBlockUser.Text = "Blokkeer rebruiker";
            this.btnBlockUser.UseVisualStyleBackColor = true;
            this.btnBlockUser.Click += new System.EventHandler(this.btnBlockUser_Click);
            // 
            // btnUnblockUser
            // 
            this.btnUnblockUser.Location = new System.Drawing.Point(98, 368);
            this.btnUnblockUser.Name = "btnUnblockUser";
            this.btnUnblockUser.Size = new System.Drawing.Size(175, 28);
            this.btnUnblockUser.TabIndex = 23;
            this.btnUnblockUser.Text = "Deblokkeer gebruiker";
            this.btnUnblockUser.UseVisualStyleBackColor = true;
            this.btnUnblockUser.Click += new System.EventHandler(this.btnUnblockUser_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(98, 402);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(175, 26);
            this.btnRemoveUser.TabIndex = 24;
            this.btnRemoveUser.Text = "Verwijder gebruiker";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(475, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // editUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}