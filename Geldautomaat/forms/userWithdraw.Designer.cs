namespace Geldautomaat.forms
{
    partial class userWithdraw
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
            this.btnWithdraw1 = new System.Windows.Forms.Button();
            this.btnWithdraw2 = new System.Windows.Forms.Button();
            this.btnWithdraw3 = new System.Windows.Forms.Button();
            this.btnWithdraw4 = new System.Windows.Forms.Button();
            this.btnWithdraw5 = new System.Windows.Forms.Button();
            this.btnWithdraw6 = new System.Windows.Forms.Button();
            this.btnWithdraw7 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWithdraw1
            // 
            this.btnWithdraw1.Location = new System.Drawing.Point(45, 79);
            this.btnWithdraw1.Name = "btnWithdraw1";
            this.btnWithdraw1.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw1.TabIndex = 0;
            this.btnWithdraw1.Text = "5";
            this.btnWithdraw1.UseVisualStyleBackColor = true;
            this.btnWithdraw1.Click += new System.EventHandler(this.btnWithdraw1_Click);
            // 
            // btnWithdraw2
            // 
            this.btnWithdraw2.Location = new System.Drawing.Point(45, 134);
            this.btnWithdraw2.Name = "btnWithdraw2";
            this.btnWithdraw2.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw2.TabIndex = 1;
            this.btnWithdraw2.Text = "10";
            this.btnWithdraw2.UseVisualStyleBackColor = true;
            this.btnWithdraw2.Click += new System.EventHandler(this.btnWithdraw2_Click);
            // 
            // btnWithdraw3
            // 
            this.btnWithdraw3.Location = new System.Drawing.Point(45, 190);
            this.btnWithdraw3.Name = "btnWithdraw3";
            this.btnWithdraw3.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw3.TabIndex = 2;
            this.btnWithdraw3.Text = "20";
            this.btnWithdraw3.UseVisualStyleBackColor = true;
            this.btnWithdraw3.Click += new System.EventHandler(this.btnWithdraw3_Click);
            // 
            // btnWithdraw4
            // 
            this.btnWithdraw4.Location = new System.Drawing.Point(45, 252);
            this.btnWithdraw4.Name = "btnWithdraw4";
            this.btnWithdraw4.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw4.TabIndex = 3;
            this.btnWithdraw4.Text = "50";
            this.btnWithdraw4.UseVisualStyleBackColor = true;
            this.btnWithdraw4.Click += new System.EventHandler(this.btnWithdraw4_Click);
            // 
            // btnWithdraw5
            // 
            this.btnWithdraw5.Location = new System.Drawing.Point(651, 79);
            this.btnWithdraw5.Name = "btnWithdraw5";
            this.btnWithdraw5.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw5.TabIndex = 4;
            this.btnWithdraw5.Text = "100";
            this.btnWithdraw5.UseVisualStyleBackColor = true;
            this.btnWithdraw5.Click += new System.EventHandler(this.btnWithdraw5_Click);
            // 
            // btnWithdraw6
            // 
            this.btnWithdraw6.Location = new System.Drawing.Point(651, 134);
            this.btnWithdraw6.Name = "btnWithdraw6";
            this.btnWithdraw6.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw6.TabIndex = 5;
            this.btnWithdraw6.Text = "150";
            this.btnWithdraw6.UseVisualStyleBackColor = true;
            this.btnWithdraw6.Click += new System.EventHandler(this.btnWithdraw6_Click);
            // 
            // btnWithdraw7
            // 
            this.btnWithdraw7.Location = new System.Drawing.Point(651, 190);
            this.btnWithdraw7.Name = "btnWithdraw7";
            this.btnWithdraw7.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw7.TabIndex = 6;
            this.btnWithdraw7.Text = "200";
            this.btnWithdraw7.UseVisualStyleBackColor = true;
            this.btnWithdraw7.Click += new System.EventHandler(this.btnWithdraw7_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(597, 252);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(129, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Zelf bedrag invullen";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnToCustom);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(45, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // userWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnWithdraw7);
            this.Controls.Add(this.btnWithdraw6);
            this.Controls.Add(this.btnWithdraw5);
            this.Controls.Add(this.btnWithdraw4);
            this.Controls.Add(this.btnWithdraw3);
            this.Controls.Add(this.btnWithdraw2);
            this.Controls.Add(this.btnWithdraw1);
            this.Name = "userWithdraw";
            this.Text = "userWithdraw";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWithdraw1;
        private System.Windows.Forms.Button btnWithdraw2;
        private System.Windows.Forms.Button btnWithdraw3;
        private System.Windows.Forms.Button btnWithdraw4;
        private System.Windows.Forms.Button btnWithdraw5;
        private System.Windows.Forms.Button btnWithdraw6;
        private System.Windows.Forms.Button btnWithdraw7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnBack;
    }
}