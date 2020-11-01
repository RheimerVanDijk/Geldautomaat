namespace Geldautomaat.forms
{
    partial class userHistory
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
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundButton2 = new Geldautomaat.RoundButton();
            this.roundButton3 = new Geldautomaat.RoundButton();
            this.roundButton4 = new Geldautomaat.RoundButton();
            this.roundButton6 = new Geldautomaat.RoundButton();
            this.roundButton7 = new Geldautomaat.RoundButton();
            this.roundButton5 = new Geldautomaat.RoundButton();
            this.btnWithdraw = new Geldautomaat.RoundButton();
            this.roundButton1 = new Geldautomaat.RoundButton();
            this.btnHistory = new Geldautomaat.RoundButton();
            this.btnBack = new Geldautomaat.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.desc,
            this.amount});
            this.dgvHistory.Location = new System.Drawing.Point(78, 155);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.Size = new System.Drawing.Size(362, 106);
            this.dgvHistory.TabIndex = 0;
            // 
            // date
            // 
            this.date.HeaderText = "Datum";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // desc
            // 
            this.desc.HeaderText = "Beschrijving";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "Bedrag";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvHistory);
            this.panel1.Location = new System.Drawing.Point(137, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 357);
            this.panel1.TabIndex = 4;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.roundButton2.Location = new System.Drawing.Point(670, 324);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(45, 45);
            this.roundButton2.TabIndex = 34;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.roundButton3.Location = new System.Drawing.Point(670, 263);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(45, 45);
            this.roundButton3.TabIndex = 33;
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.roundButton4.Location = new System.Drawing.Point(670, 202);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(45, 45);
            this.roundButton4.TabIndex = 32;
            this.roundButton4.UseVisualStyleBackColor = false;
            // 
            // roundButton6
            // 
            this.roundButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.roundButton6.Location = new System.Drawing.Point(670, 141);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.Size = new System.Drawing.Size(45, 45);
            this.roundButton6.TabIndex = 31;
            this.roundButton6.UseVisualStyleBackColor = false;
            // 
            // roundButton7
            // 
            this.roundButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.roundButton7.Location = new System.Drawing.Point(670, 81);
            this.roundButton7.Name = "roundButton7";
            this.roundButton7.Size = new System.Drawing.Size(45, 45);
            this.roundButton7.TabIndex = 30;
            this.roundButton7.UseVisualStyleBackColor = false;
            // 
            // roundButton5
            // 
            this.roundButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.roundButton5.Location = new System.Drawing.Point(86, 324);
            this.roundButton5.Name = "roundButton5";
            this.roundButton5.Size = new System.Drawing.Size(45, 45);
            this.roundButton5.TabIndex = 29;
            this.roundButton5.UseVisualStyleBackColor = false;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnWithdraw.Location = new System.Drawing.Point(86, 263);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(45, 45);
            this.btnWithdraw.TabIndex = 28;
            this.btnWithdraw.UseVisualStyleBackColor = false;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.roundButton1.Location = new System.Drawing.Point(86, 202);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(45, 45);
            this.roundButton1.TabIndex = 27;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnHistory.Location = new System.Drawing.Point(86, 141);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(45, 45);
            this.btnHistory.TabIndex = 26;
            this.btnHistory.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnBack.Location = new System.Drawing.Point(86, 81);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 45);
            this.btnBack.TabIndex = 25;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hier een overzicht van uw laatste 3 transacties";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Terug";
            // 
            // userHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.roundButton6);
            this.Controls.Add(this.roundButton7);
            this.Controls.Add(this.roundButton5);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Name = "userHistory";
            this.Text = "userHistory";
            this.Load += new System.EventHandler(this.userHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.Panel panel1;
        private RoundButton roundButton2;
        private RoundButton roundButton3;
        private RoundButton roundButton4;
        private RoundButton roundButton6;
        private RoundButton roundButton7;
        private RoundButton roundButton5;
        private RoundButton btnWithdraw;
        private RoundButton roundButton1;
        private RoundButton btnHistory;
        private RoundButton btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}