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
            this.label1 = new System.Windows.Forms.Label();
            this.categoriesCbox = new System.Windows.Forms.ComboBox();
            this.dataOperationGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataOperationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Catégorie";
            // 
            // categoriesCbox
            // 
            this.categoriesCbox.FormattingEnabled = true;
            this.categoriesCbox.Location = new System.Drawing.Point(154, 24);
            this.categoriesCbox.Name = "categoriesCbox";
            this.categoriesCbox.Size = new System.Drawing.Size(121, 21);
            this.categoriesCbox.TabIndex = 9;
            // 
            // dataOperationGridView
            // 
            this.dataOperationGridView.AllowUserToAddRows = false;
            this.dataOperationGridView.AllowUserToDeleteRows = false;
            this.dataOperationGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOperationGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataOperationGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataOperationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOperationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Namee,
            this.PaymentType,
            this.Amount,
            this.OperationType,
            this.Date});
            this.dataOperationGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataOperationGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataOperationGridView.Location = new System.Drawing.Point(0, 67);
            this.dataOperationGridView.MultiSelect = false;
            this.dataOperationGridView.Name = "dataOperationGridView";
            this.dataOperationGridView.ReadOnly = true;
            this.dataOperationGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOperationGridView.Size = new System.Drawing.Size(1024, 597);
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
            // DataGridOperationComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataOperationGridView);
            this.Controls.Add(this.categoriesCbox);
            this.Controls.Add(this.label1);
            this.Name = "DataGridOperationComponent";
            this.Size = new System.Drawing.Size(1024, 664);
            ((System.ComponentModel.ISupportInitialize)(this.dataOperationGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoriesCbox;
        private System.Windows.Forms.DataGridView dataOperationGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}
