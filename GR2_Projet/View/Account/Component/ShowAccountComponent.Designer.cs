namespace GR2_Projet.View.Account.Component
{
    partial class ShowAccountComponent
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataAccount = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataAccount
            // 
            this.dataAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.AccountName,
            this.Budget});
            this.dataAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataAccount.Location = new System.Drawing.Point(0, 0);
            this.dataAccount.Name = "dataAccount";
            this.dataAccount.Size = new System.Drawing.Size(1024, 731);
            this.dataAccount.TabIndex = 0;
            this.dataAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAccount_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // AccountName
            // 
            this.AccountName.HeaderText = "Nom";
            this.AccountName.Name = "AccountName";
            this.AccountName.ReadOnly = true;
            // 
            // Budget
            // 
            this.Budget.HeaderText = "Budget";
            this.Budget.Name = "Budget";
            this.Budget.ReadOnly = true;
            // 
            // ShowAccountComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.Controls.Add(this.dataAccount);
            this.Name = "ShowAccountComponent";
            this.Size = new System.Drawing.Size(1024, 731);
            ((System.ComponentModel.ISupportInitialize)(this.dataAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Budget;
    }
}
