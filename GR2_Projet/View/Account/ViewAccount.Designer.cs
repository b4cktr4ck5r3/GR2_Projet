namespace GR2_Projet.View.Account
{
    partial class ViewAccount
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
            this.components = new System.ComponentModel.Container();
            this.timerForDate = new System.Windows.Forms.Timer(this.components);
            this.operationGridView = new System.Windows.Forms.DataGridView();
            this.dueGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.categoryViewBtn = new System.Windows.Forms.Button();
            this.dueViewBtn = new System.Windows.Forms.Button();
            this.operationViewBtn = new System.Windows.Forms.Button();
            this.staticBudgetLbl = new System.Windows.Forms.Label();
            this.budgetLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.returnPreviousViewBtn = new System.Windows.Forms.Button();
            this.accountNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpPaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpOperationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.operationGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dueGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // timerForDate
            // 
            this.timerForDate.Tick += new System.EventHandler(this.timerForDate_Tick);
            // 
            // operationGridView
            // 
            this.operationGridView.AllowUserToAddRows = false;
            this.operationGridView.AllowUserToDeleteRows = false;
            this.operationGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.operationGridView.BackgroundColor = System.Drawing.Color.White;
            this.operationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OpId,
            this.OpName,
            this.OpPaymentType,
            this.OpAmount,
            this.OpOperationType,
            this.OpDate,
            this.OpCategory});
            this.operationGridView.Location = new System.Drawing.Point(488, 434);
            this.operationGridView.MultiSelect = false;
            this.operationGridView.Name = "operationGridView";
            this.operationGridView.ReadOnly = true;
            this.operationGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.operationGridView.Size = new System.Drawing.Size(504, 260);
            this.operationGridView.TabIndex = 13;
            // 
            // dueGridView
            // 
            this.dueGridView.AllowUserToAddRows = false;
            this.dueGridView.AllowUserToDeleteRows = false;
            this.dueGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dueGridView.BackgroundColor = System.Drawing.Color.White;
            this.dueGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dueGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DueName,
            this.OperationType,
            this.Day,
            this.PaymentType,
            this.Amount,
            this.Category});
            this.dueGridView.Location = new System.Drawing.Point(487, 167);
            this.dueGridView.MultiSelect = false;
            this.dueGridView.Name = "dueGridView";
            this.dueGridView.ReadOnly = true;
            this.dueGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dueGridView.Size = new System.Drawing.Size(504, 193);
            this.dueGridView.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // DueName
            // 
            this.DueName.HeaderText = "Name";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(481, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Dernières opérations";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(481, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mes écheances";
            // 
            // categoryViewBtn
            // 
            this.categoryViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryViewBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.categoryViewBtn.Location = new System.Drawing.Point(30, 603);
            this.categoryViewBtn.Name = "categoryViewBtn";
            this.categoryViewBtn.Size = new System.Drawing.Size(303, 90);
            this.categoryViewBtn.TabIndex = 9;
            this.categoryViewBtn.Text = "Gestion Categories";
            this.categoryViewBtn.UseVisualStyleBackColor = true;
            this.categoryViewBtn.Click += new System.EventHandler(this.categoryViewBtn_Click);
            // 
            // dueViewBtn
            // 
            this.dueViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueViewBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dueViewBtn.Location = new System.Drawing.Point(30, 473);
            this.dueViewBtn.Name = "dueViewBtn";
            this.dueViewBtn.Size = new System.Drawing.Size(303, 90);
            this.dueViewBtn.TabIndex = 8;
            this.dueViewBtn.Text = "Gestion Echeances";
            this.dueViewBtn.UseVisualStyleBackColor = true;
            this.dueViewBtn.Click += new System.EventHandler(this.dueViewBtn_Click);
            // 
            // operationViewBtn
            // 
            this.operationViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationViewBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.operationViewBtn.Location = new System.Drawing.Point(30, 343);
            this.operationViewBtn.Name = "operationViewBtn";
            this.operationViewBtn.Size = new System.Drawing.Size(303, 90);
            this.operationViewBtn.TabIndex = 7;
            this.operationViewBtn.Text = "Gestion Operations";
            this.operationViewBtn.UseVisualStyleBackColor = true;
            this.operationViewBtn.Click += new System.EventHandler(this.operationViewBtn_Click);
            // 
            // staticBudgetLbl
            // 
            this.staticBudgetLbl.AutoSize = true;
            this.staticBudgetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticBudgetLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.staticBudgetLbl.Location = new System.Drawing.Point(25, 234);
            this.staticBudgetLbl.Name = "staticBudgetLbl";
            this.staticBudgetLbl.Size = new System.Drawing.Size(72, 25);
            this.staticBudgetLbl.TabIndex = 6;
            this.staticBudgetLbl.Text = "Solde";
            // 
            // budgetLbl
            // 
            this.budgetLbl.AutoSize = true;
            this.budgetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.budgetLbl.Location = new System.Drawing.Point(216, 234);
            this.budgetLbl.Name = "budgetLbl";
            this.budgetLbl.Size = new System.Drawing.Size(117, 25);
            this.budgetLbl.TabIndex = 5;
            this.budgetLbl.Text = "{SOLDE}€";
            this.budgetLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateLbl.Location = new System.Drawing.Point(25, 122);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(251, 25);
            this.dateLbl.TabIndex = 4;
            this.dateLbl.Text = "DD:MM:YYYY  HH:MM";
            // 
            // returnPreviousViewBtn
            // 
            this.returnPreviousViewBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.returnPreviousViewBtn.Location = new System.Drawing.Point(920, 28);
            this.returnPreviousViewBtn.Name = "returnPreviousViewBtn";
            this.returnPreviousViewBtn.Size = new System.Drawing.Size(80, 30);
            this.returnPreviousViewBtn.TabIndex = 2;
            this.returnPreviousViewBtn.Text = "Retour";
            this.returnPreviousViewBtn.UseVisualStyleBackColor = true;
            this.returnPreviousViewBtn.Click += new System.EventHandler(this.returnPreviousViewBtn_Click);
            // 
            // accountNameLbl
            // 
            this.accountNameLbl.AutoSize = true;
            this.accountNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.accountNameLbl.Location = new System.Drawing.Point(26, 32);
            this.accountNameLbl.Name = "accountNameLbl";
            this.accountNameLbl.Size = new System.Drawing.Size(121, 20);
            this.accountNameLbl.TabIndex = 1;
            this.accountNameLbl.Text = "Nom du compte";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1024, 3);
            this.label3.TabIndex = 3;
            // 
            // OpId
            // 
            this.OpId.HeaderText = "Id";
            this.OpId.Name = "OpId";
            this.OpId.ReadOnly = true;
            // 
            // OpName
            // 
            this.OpName.HeaderText = "Name";
            this.OpName.Name = "OpName";
            this.OpName.ReadOnly = true;
            // 
            // OpPaymentType
            // 
            this.OpPaymentType.HeaderText = "Type de paiement";
            this.OpPaymentType.Name = "OpPaymentType";
            this.OpPaymentType.ReadOnly = true;
            // 
            // OpAmount
            // 
            this.OpAmount.HeaderText = "Montant";
            this.OpAmount.Name = "OpAmount";
            this.OpAmount.ReadOnly = true;
            // 
            // OpOperationType
            // 
            this.OpOperationType.HeaderText = "Type d\'opération";
            this.OpOperationType.Name = "OpOperationType";
            this.OpOperationType.ReadOnly = true;
            // 
            // OpDate
            // 
            this.OpDate.HeaderText = "Date";
            this.OpDate.Name = "OpDate";
            this.OpDate.ReadOnly = true;
            // 
            // OpCategory
            // 
            this.OpCategory.HeaderText = "Catégorie";
            this.OpCategory.Name = "OpCategory";
            this.OpCategory.ReadOnly = true;
            // 
            // ViewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.operationGridView);
            this.Controls.Add(this.dueGridView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.categoryViewBtn);
            this.Controls.Add(this.dueViewBtn);
            this.Controls.Add(this.operationViewBtn);
            this.Controls.Add(this.staticBudgetLbl);
            this.Controls.Add(this.budgetLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.returnPreviousViewBtn);
            this.Controls.Add(this.accountNameLbl);
            this.Controls.Add(this.label1);
            this.Name = "ViewAccount";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.operationGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dueGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accountNameLbl;
        private System.Windows.Forms.Button returnPreviousViewBtn;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label budgetLbl;
        private System.Windows.Forms.Label staticBudgetLbl;
        private System.Windows.Forms.Button operationViewBtn;
        private System.Windows.Forms.Button dueViewBtn;
        private System.Windows.Forms.Button categoryViewBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dueGridView;
        private System.Windows.Forms.DataGridView operationGridView;
        private System.Windows.Forms.Timer timerForDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpPaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpOperationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpCategory;
    }
}
