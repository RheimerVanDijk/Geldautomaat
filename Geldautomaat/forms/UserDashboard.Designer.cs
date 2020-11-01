namespace Geldautomaat.forms
{
    partial class UserDashboard
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
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundButton5 = new Geldautomaat.RoundButton();
            this.btnWithdraw = new Geldautomaat.RoundButton();
            this.btnDeposit = new Geldautomaat.RoundButton();
            this.btnHistory = new Geldautomaat.RoundButton();
            this.btnCheckSaldo = new Geldautomaat.RoundButton();
            this.roundButton6 = new Geldautomaat.RoundButton();
            this.roundButton7 = new Geldautomaat.RoundButton();
            this.roundButton8 = new Geldautomaat.RoundButton();
            this.roundButton9 = new Geldautomaat.RoundButton();
            this.roundButton10 = new Geldautomaat.RoundButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.Location = new System.Drawing.Point(214, 107);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(310, 122);
            this.lblWelcomeMessage.TabIndex = 0;
            this.lblWelcomeMessage.Text = "Welkom Rheimer van Dijk, Kies een van de opties.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblWelcomeMessage);
            this.panel1.Location = new System.Drawing.Point(124, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 357);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Geld opnemen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geld storten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transacties geschiedenis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check huidige saldo";
            // 
            // roundButton5
            // 
            this.roundButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.roundButton5.Location = new System.Drawing.Point(73, 315);
            this.roundButton5.Name = "roundButton5";
            this.roundButton5.Size = new System.Drawing.Size(45, 45);
            this.roundButton5.TabIndex = 14;
            this.roundButton5.UseVisualStyleBackColor = false;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnWithdraw.Location = new System.Drawing.Point(73, 254);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(45, 45);
            this.btnWithdraw.TabIndex = 13;
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnDeposit.Location = new System.Drawing.Point(73, 193);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(45, 45);
            this.btnDeposit.TabIndex = 12;
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnHistory.Location = new System.Drawing.Point(73, 132);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(45, 45);
            this.btnHistory.TabIndex = 11;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnCheckSaldo
            // 
            this.btnCheckSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnCheckSaldo.Location = new System.Drawing.Point(73, 72);
            this.btnCheckSaldo.Name = "btnCheckSaldo";
            this.btnCheckSaldo.Size = new System.Drawing.Size(45, 45);
            this.btnCheckSaldo.TabIndex = 10;
            this.btnCheckSaldo.UseVisualStyleBackColor = false;
            this.btnCheckSaldo.Click += new System.EventHandler(this.btnCheckSaldo_Click);
            // 
            // roundButton6
            // 
            this.roundButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.roundButton6.Location = new System.Drawing.Point(657, 315);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.Size = new System.Drawing.Size(45, 45);
            this.roundButton6.TabIndex = 14;
            this.roundButton6.UseVisualStyleBackColor = false;
            // 
            // roundButton7
            // 
            this.roundButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.roundButton7.Location = new System.Drawing.Point(657, 254);
            this.roundButton7.Name = "roundButton7";
            this.roundButton7.Size = new System.Drawing.Size(45, 45);
            this.roundButton7.TabIndex = 13;
            this.roundButton7.UseVisualStyleBackColor = false;
            // 
            // roundButton8
            // 
            this.roundButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.roundButton8.Location = new System.Drawing.Point(657, 193);
            this.roundButton8.Name = "roundButton8";
            this.roundButton8.Size = new System.Drawing.Size(45, 45);
            this.roundButton8.TabIndex = 12;
            this.roundButton8.UseVisualStyleBackColor = false;
            // 
            // roundButton9
            // 
            this.roundButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.roundButton9.Location = new System.Drawing.Point(657, 132);
            this.roundButton9.Name = "roundButton9";
            this.roundButton9.Size = new System.Drawing.Size(45, 45);
            this.roundButton9.TabIndex = 11;
            this.roundButton9.UseVisualStyleBackColor = false;
            // 
            // roundButton10
            // 
            this.roundButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.roundButton10.Location = new System.Drawing.Point(657, 72);
            this.roundButton10.Name = "roundButton10";
            this.roundButton10.Size = new System.Drawing.Size(45, 45);
            this.roundButton10.TabIndex = 10;
            this.roundButton10.UseVisualStyleBackColor = false;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundButton6);
            this.Controls.Add(this.roundButton7);
            this.Controls.Add(this.roundButton5);
            this.Controls.Add(this.roundButton8);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.roundButton9);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.roundButton10);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnCheckSaldo);
            this.Controls.Add(this.panel1);
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RoundButton roundButton5;
        private RoundButton btnWithdraw;
        private RoundButton btnDeposit;
        private RoundButton btnHistory;
        private RoundButton btnCheckSaldo;
        private RoundButton roundButton6;
        private RoundButton roundButton7;
        private RoundButton roundButton8;
        private RoundButton roundButton9;
        private RoundButton roundButton10;
    }
}