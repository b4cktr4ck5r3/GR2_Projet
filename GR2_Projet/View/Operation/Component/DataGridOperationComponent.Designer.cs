namespace GR2_Projet.View.Operation.Component
{
    partial class DataGridOperationComponent
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
            this.dataOperationGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataOperationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataOperationGridView
            // 
            this.dataOperationGridView.AllowUserToAddRows = false;
            this.dataOperationGridView.AllowUserToDeleteRows = false;
            this.dataOperationGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOperationGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataOperationGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataOperationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOperationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Namee,
            this.PaymentType,
            this.Amount,
            this.OperationType,
            this.Date,
            this.Category});
            this.dataOperationGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataOperationGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataOperationGridView.Location = new System.Drawing.Point(0, 84);
            this.dataOperationGridView.MultiSelect = false;
            this.dataOperationGridView.Name = "dataOperationGridView";
            this.dataOperationGridView.ReadOnly = true;
            this.dataOperationGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOperationGridView.Size = new System.Drawing.Size(1024, 580);
            this.dataOperationGridView.TabIndex = 10;
            this.dataOperationGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOperationGridView_CellClick);
            this.dataOperationGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOperationGridView_CellContentClick);
            this.dataOperationGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOperationGridView_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Namee
            // 
            this.Namee.HeaderText = "Nom";
            this.Namee.Name = "Namee";
            this.Namee.ReadOnly = true;
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
            // OperationType
            // 
            this.OperationType.HeaderText = "Type d\'opération";
            this.OperationType.Name = "OperationType";
            this.OperationType.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Catégorie";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // DataGridOperationComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataOperationGridView);
            this.Name = "DataGridOperationComponent";
            this.Size = new System.Drawing.Size(1024, 664);
            this.Load += new System.EventHandler(this.DataGridOperationComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOperationGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataOperationGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
    }
}
