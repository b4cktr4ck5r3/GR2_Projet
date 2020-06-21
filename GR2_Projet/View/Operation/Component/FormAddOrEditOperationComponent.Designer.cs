namespace GR2_Projet.View.Operation.Component
{
    partial class FormAddOrEditOperationComponent
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
            this.categoryLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.operationTypeLbl = new System.Windows.Forms.Label();
            this.amountLbl = new System.Windows.Forms.Label();
            this.paymentTypeLbl = new System.Windows.Forms.Label();
            this.categoryCbox = new System.Windows.Forms.ComboBox();
            this.operationTypeCbox = new System.Windows.Forms.ComboBox();
            this.paymentTypeCbox = new System.Windows.Forms.ComboBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.amountTxtBox = new System.Windows.Forms.TextBox();
            this.dateTPicker = new System.Windows.Forms.DateTimePicker();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.categoryLbl.Location = new System.Drawing.Point(311, 234);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(105, 25);
            this.categoryLbl.TabIndex = 0;
            this.categoryLbl.Text = "Catégorie";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nameLbl.Location = new System.Drawing.Point(311, 268);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(56, 25);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Nom";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dateLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateLbl.Location = new System.Drawing.Point(311, 302);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(57, 25);
            this.dateLbl.TabIndex = 3;
            this.dateLbl.Text = "Date";
            // 
            // operationTypeLbl
            // 
            this.operationTypeLbl.AutoSize = true;
            this.operationTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.operationTypeLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.operationTypeLbl.Location = new System.Drawing.Point(311, 336);
            this.operationTypeLbl.Name = "operationTypeLbl";
            this.operationTypeLbl.Size = new System.Drawing.Size(172, 25);
            this.operationTypeLbl.TabIndex = 4;
            this.operationTypeLbl.Text = "Type d\'opération";
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.amountLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.amountLbl.Location = new System.Drawing.Point(311, 374);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(90, 25);
            this.amountLbl.TabIndex = 5;
            this.amountLbl.Text = "Montant";
            // 
            // paymentTypeLbl
            // 
            this.paymentTypeLbl.AutoSize = true;
            this.paymentTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.paymentTypeLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.paymentTypeLbl.Location = new System.Drawing.Point(311, 414);
            this.paymentTypeLbl.Name = "paymentTypeLbl";
            this.paymentTypeLbl.Size = new System.Drawing.Size(184, 25);
            this.paymentTypeLbl.TabIndex = 6;
            this.paymentTypeLbl.Text = "Type de paiement";
            // 
            // categoryCbox
            // 
            this.categoryCbox.FormattingEnabled = true;
            this.categoryCbox.Location = new System.Drawing.Point(512, 238);
            this.categoryCbox.Name = "categoryCbox";
            this.categoryCbox.Size = new System.Drawing.Size(121, 21);
            this.categoryCbox.TabIndex = 7;
            // 
            // operationTypeCbox
            // 
            this.operationTypeCbox.FormattingEnabled = true;
            this.operationTypeCbox.Location = new System.Drawing.Point(512, 340);
            this.operationTypeCbox.Name = "operationTypeCbox";
            this.operationTypeCbox.Size = new System.Drawing.Size(121, 21);
            this.operationTypeCbox.TabIndex = 9;
            // 
            // paymentTypeCbox
            // 
            this.paymentTypeCbox.FormattingEnabled = true;
            this.paymentTypeCbox.Location = new System.Drawing.Point(512, 420);
            this.paymentTypeCbox.Name = "paymentTypeCbox";
            this.paymentTypeCbox.Size = new System.Drawing.Size(121, 21);
            this.paymentTypeCbox.TabIndex = 10;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(512, 274);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(121, 20);
            this.nameTxtBox.TabIndex = 11;
            // 
            // amountTxtBox
            // 
            this.amountTxtBox.Location = new System.Drawing.Point(512, 379);
            this.amountTxtBox.Name = "amountTxtBox";
            this.amountTxtBox.Size = new System.Drawing.Size(121, 20);
            this.amountTxtBox.TabIndex = 13;
            // 
            // dateTPicker
            // 
            this.dateTPicker.Location = new System.Drawing.Point(512, 305);
            this.dateTPicker.Name = "dateTPicker";
            this.dateTPicker.Size = new System.Drawing.Size(121, 20);
            this.dateTPicker.TabIndex = 14;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addBtn.Location = new System.Drawing.Point(498, 471);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(147, 33);
            this.addBtn.TabIndex = 15;
            this.addBtn.Text = "Ajouter";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.75F);
            this.editBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.editBtn.Location = new System.Drawing.Point(498, 471);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(147, 33);
            this.editBtn.TabIndex = 16;
            this.editBtn.Text = "Modifier";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // FormAddOrEditOperationComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dateTPicker);
            this.Controls.Add(this.amountTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.paymentTypeCbox);
            this.Controls.Add(this.operationTypeCbox);
            this.Controls.Add(this.categoryCbox);
            this.Controls.Add(this.paymentTypeLbl);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.operationTypeLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.categoryLbl);
            this.Name = "FormAddOrEditOperationComponent";
            this.Size = new System.Drawing.Size(1024, 686);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label operationTypeLbl;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Label paymentTypeLbl;
        private System.Windows.Forms.ComboBox categoryCbox;
        private System.Windows.Forms.ComboBox operationTypeCbox;
        private System.Windows.Forms.ComboBox paymentTypeCbox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox amountTxtBox;
        private System.Windows.Forms.DateTimePicker dateTPicker;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
    }
}
