namespace Geldautomaat.msgForms
{
    partial class withdrawBill
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnNoBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(595, 119);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(75, 23);
            this.btnBill.TabIndex = 1;
            this.btnBill.Text = "Ja";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnNoBill
            // 
            this.btnNoBill.Location = new System.Drawing.Point(573, 225);
            this.btnNoBill.Name = "btnNoBill";
            this.btnNoBill.Size = new System.Drawing.Size(75, 23);
            this.btnNoBill.TabIndex = 2;
            this.btnNoBill.Text = "Nee";
            this.btnNoBill.UseVisualStyleBackColor = true;
            this.btnNoBill.Click += new System.EventHandler(this.btnNoBill_Click);
            // 
            // withdrawBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNoBill);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.label1);
            this.Name = "withdrawBill";
            this.Text = "withdrawBill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnNoBill;
    }
}