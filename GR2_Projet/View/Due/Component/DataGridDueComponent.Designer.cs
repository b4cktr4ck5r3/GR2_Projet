namespace GR2_Projet.View.Due.Component
{
    partial class DataGridDueComponent
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
            this.dataDuesGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataDuesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDuesGrid
            // 
            this.dataDuesGrid.AllowUserToAddRows = false;
            this.dataDuesGrid.AllowUserToDeleteRows = false;
            this.dataDuesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDuesGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataDuesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDuesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DueName,
            this.OperationType,
            this.Day,
            this.PaymentType,
            this.Amount,
            this.Category});
            this.dataDuesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDuesGrid.GridColor = System.Drawing.SystemColors.Control;
            this.dataDuesGrid.Location = new System.Drawing.Point(0, 0);
            this.dataDuesGrid.MultiSelect = false;
            this.dataDuesGrid.Name = "dataDuesGrid";
            this.dataDuesGrid.ReadOnly = true;
            this.dataDuesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDuesGrid.Size = new System.Drawing.Size(1024, 638);
            this.dataDuesGrid.TabIndex = 0;
            this.dataDuesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDuesGrid_CellClick);
            this.dataDuesGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDuesGrid_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // DueName
            // 
            this.DueName.HeaderText = "Nom";
            this.DueName.Name = "DueName";
            this.DueName.ReadOnly = true;
            // 
            // OperationType
            // 
            this.OperationType.HeaderText = "Type d\'opération";
            this.OperationType.Name = "OperationType";
            this.OperationType.ReadOnly = true;
            // 
            // Day
            // 
            this.Day.HeaderText = "Jours";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            // 
            // PaymentType
            // 
            this.PaymentType.HeaderText = "Type de paiement";
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Montant";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Catégorie";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // DataGridDueComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataDuesGrid);
            this.Name = "DataGridDueComponent";
            this.Size = new System.Drawing.Size(1024, 638);
            ((System.ComponentModel.ISupportInitialize)(this.dataDuesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDuesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
    }
}
