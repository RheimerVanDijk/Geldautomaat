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
            this.SuspendLayout();
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(103, 42);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(100, 20);
            this.txbEmail.TabIndex = 0;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(103, 94);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(100, 20);
            this.txbFirstName.TabIndex = 2;
            // 
            // txbSex
            // 
            this.txbSex.Location = new System.Drawing.Point(277, 42);
            this.txbSex.Name = "txbSex";
            this.txbSex.Size = new System.Drawing.Size(100, 20);
            this.txbSex.TabIndex = 3;
            // 
            // txbBSN
            // 
            this.txbBSN.Location = new System.Drawing.Point(323, 68);
            this.txbBSN.Name = "txbBSN";
            this.txbBSN.Size = new System.Drawing.Size(100, 20);
            this.txbBSN.TabIndex = 4;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(277, 94);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(100, 20);
            this.txbLastName.TabIndex = 5;
            // 
            // txbAdress
            // 
            this.txbAdress.Location = new System.Drawing.Point(103, 158);
            this.txbAdress.Name = "txbAdress";
            this.txbAdress.Size = new System.Drawing.Size(100, 20);
            this.txbAdress.TabIndex = 6;
            // 
            // txbPostcode
            // 
            this.txbPostcode.Location = new System.Drawing.Point(277, 158);
            this.txbPostcode.Name = "txbPostcode";
            this.txbPostcode.Size = new System.Drawing.Size(100, 20);
            this.txbPostcode.TabIndex = 7;
            // 
            // txbPlaats
            // 
            this.txbPlaats.Location = new System.Drawing.Point(103, 184);
            this.txbPlaats.Name = "txbPlaats";
            this.txbPlaats.Size = new System.Drawing.Size(100, 20);
            this.txbPlaats.TabIndex = 8;
            // 
            // btnOpenRekening
            // 
            this.btnOpenRekening.Location = new System.Drawing.Point(103, 263);
            this.btnOpenRekening.Name = "btnOpenRekening";
            this.btnOpenRekening.Size = new System.Drawing.Size(161, 23);
            this.btnOpenRekening.TabIndex = 9;
            this.btnOpenRekening.Text = "Rekening openen";
            this.btnOpenRekening.UseVisualStyleBackColor = true;
            this.btnOpenRekening.Click += new System.EventHandler(this.btnOpenRekening_Click);
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Location = new System.Drawing.Point(103, 68);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(100, 20);
            this.dtpBirthDay.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(564, 38);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}