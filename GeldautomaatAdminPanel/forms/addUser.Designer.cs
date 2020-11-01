namespace AdminPanel.forms
{
    partial class addUser
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
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbSex = new System.Windows.Forms.TextBox();
            this.txbBSN = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbAdress = new System.Windows.Forms.TextBox();
            this.txbPostcode = new System.Windows.Forms.TextBox();
            this.txbPlaats = new System.Windows.Forms.TextBox();
            this.btnOpenRekening = new System.Windows.Forms.Button();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(103, 59);
            this.txbEmail.Multiline = true;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(169, 20);
            this.txbEmail.TabIndex = 0;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(103, 156);
            this.txbFirstName.Multiline = true;
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(169, 20);
            this.txbFirstName.TabIndex = 2;
            // 
            // txbSex
            // 
            this.txbSex.Location = new System.Drawing.Point(313, 59);
            this.txbSex.Name = "txbSex";
            this.txbSex.Size = new System.Drawing.Size(100, 20);
            this.txbSex.TabIndex = 3;
            // 
            // txbBSN
            // 
            this.txbBSN.Location = new System.Drawing.Point(313, 108);
            this.txbBSN.Multiline = true;
            this.txbBSN.Name = "txbBSN";
            this.txbBSN.Size = new System.Drawing.Size(186, 20);
            this.txbBSN.TabIndex = 4;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(313, 156);
            this.txbLastName.Multiline = true;
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(186, 20);
            this.txbLastName.TabIndex = 5;
            // 
            // txbAdress
            // 
            this.txbAdress.Location = new System.Drawing.Point(103, 213);
            this.txbAdress.Name = "txbAdress";
            this.txbAdress.Size = new System.Drawing.Size(169, 20);
            this.txbAdress.TabIndex = 6;
            // 
            // txbPostcode
            // 
            this.txbPostcode.Location = new System.Drawing.Point(313, 213);
            this.txbPostcode.Name = "txbPostcode";
            this.txbPostcode.Size = new System.Drawing.Size(100, 20);
            this.txbPostcode.TabIndex = 7;
            // 
            // txbPlaats
            // 
            this.txbPlaats.Location = new System.Drawing.Point(103, 259);
            this.txbPlaats.Name = "txbPlaats";
            this.txbPlaats.Size = new System.Drawing.Size(169, 20);
            this.txbPlaats.TabIndex = 8;
            // 
            // btnOpenRekening
            // 
            this.btnOpenRekening.Location = new System.Drawing.Point(103, 307);
            this.btnOpenRekening.Name = "btnOpenRekening";
            this.btnOpenRekening.Size = new System.Drawing.Size(161, 23);
            this.btnOpenRekening.TabIndex = 9;
            this.btnOpenRekening.Text = "Rekening openen";
            this.btnOpenRekening.UseVisualStyleBackColor = true;
            this.btnOpenRekening.Click += new System.EventHandler(this.btnOpenRekening_Click);
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Location = new System.Drawing.Point(103, 108);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(100, 20);
            this.dtpBirthDay.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Geslacht: (Man, Vrouw)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Geboorte datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "BSN nummer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Voornaam:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Achternaam:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Postcode:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Woonplaats:";
            // 
            // addUser
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
            this.Controls.Add(this.dtpBirthDay);
            this.Controls.Add(this.btnOpenRekening);
            this.Controls.Add(this.txbPlaats);
            this.Controls.Add(this.txbPostcode);
            this.Controls.Add(this.txbAdress);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.txbBSN);
            this.Controls.Add(this.txbSex);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.txbEmail);
            this.Name = "addUser";
            this.Text = "addUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txbSex;
        private System.Windows.Forms.TextBox txbBSN;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TextBox txbAdress;
        private System.Windows.Forms.TextBox txbPostcode;
        private System.Windows.Forms.TextBox txbPlaats;
        private System.Windows.Forms.Button btnOpenRekening;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}