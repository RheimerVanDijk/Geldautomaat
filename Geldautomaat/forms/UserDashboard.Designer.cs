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
            this.btnCheckSaldo = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Location = new System.Drawing.Point(472, 120);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(35, 13);
            this.lblWelcomeMessage.TabIndex = 0;
            this.lblWelcomeMessage.Text = "label1";
            // 
            // btnCheckSaldo
            // 
            this.btnCheckSaldo.Location = new System.Drawing.Point(67, 54);
            this.btnCheckSaldo.Name = "btnCheckSaldo";
            this.btnCheckSaldo.Size = new System.Drawing.Size(75, 23);
            this.btnCheckSaldo.TabIndex = 1;
            this.btnCheckSaldo.Text = "Check saldo";
            this.btnCheckSaldo.UseVisualStyleBackColor = true;
            this.btnCheckSaldo.Click += new System.EventHandler(this.btnCheckSaldo_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(67, 83);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Geld storten";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(67, 115);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(179, 23);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "Transacties geschiedenis";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(67, 144);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Geld opnemen";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnCheckSaldo);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Button btnCheckSaldo;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnWithdraw;
    }
}