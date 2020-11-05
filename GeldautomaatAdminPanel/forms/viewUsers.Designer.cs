namespace AdminPanel.forms
{
    partial class viewUsers
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voornaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achternaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rekening_nummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditUser = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbAccountNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.voornaam,
            this.achternaam,
            this.rekening_nummer,
            this.EditUser});
            this.dgvUsers.Location = new System.Drawing.Point(40, 130);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(724, 150);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // id
            // 
            this.id.FillWeight = 30F;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 30;
            // 
            // voornaam
            // 
            this.voornaam.HeaderText = "voornaam";
            this.voornaam.Name = "voornaam";
            this.voornaam.ReadOnly = true;
            this.voornaam.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.voornaam.Width = 200;
            // 
            // achternaam
            // 
            this.achternaam.HeaderText = "achternaam";
            this.achternaam.Name = "achternaam";
            this.achternaam.ReadOnly = true;
            this.achternaam.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.achternaam.Width = 200;
            // 
            // rekening_nummer
            // 
            this.rekening_nummer.HeaderText = "rekening nummer";
            this.rekening_nummer.Name = "rekening_nummer";
            this.rekening_nummer.ReadOnly = true;
            this.rekening_nummer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rekening_nummer.Width = 150;
            // 
            // EditUser
            // 
            this.EditUser.HeaderText = "Edit user";
            this.EditUser.Name = "EditUser";
            this.EditUser.ReadOnly = true;
            this.EditUser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(40, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(40, 89);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 2;
            // 
            // txbAccountNumber
            // 
            this.txbAccountNumber.Location = new System.Drawing.Point(252, 89);
            this.txbAccountNumber.Name = "txbAccountNumber";
            this.txbAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txbAccountNumber.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(411, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Voornaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Achternaam:";
            // 
            // viewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbAccountNumber);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvUsers);
            this.Name = "viewUsers";
            this.Text = "viewUsers";
            this.Load += new System.EventHandler(this.viewUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn voornaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn achternaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn rekening_nummer;
        private System.Windows.Forms.DataGridViewButtonColumn EditUser;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbAccountNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}