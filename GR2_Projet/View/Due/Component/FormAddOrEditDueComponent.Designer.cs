namespace GR2_Projet.View.Due.Component
{
    partial class FormAddOrEditDueComponent
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
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.amountTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.paymentTypeCbox = new System.Windows.Forms.ComboBox();
            this.operationTypeCbox = new System.Windows.Forms.ComboBox();
            this._categoryCbox = new System.Windows.Forms.ComboBox();
            this.categoryCbox = new System.Windows.Forms.ComboBox();
            this.paymentTypeLbl = new System.Windows.Forms.Label();
            this.amountLbl = new System.Windows.Forms.Label();
            this.operationTypeLbl = new System.Windows.Forms.Label();
            this.dayLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this._categoryLbl = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.dayTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.75F);
            this.editBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.editBtn.Location = new System.Drawing.Point(524, 449);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(147, 33);
            this.editBtn.TabIndex = 32;
            this.editBtn.Text = "Modifier";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addBtn.Location = new System.Drawing.Point(524, 450);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(147, 33);
            this.addBtn.TabIndex = 31;
            this.addBtn.Text = "Ajouter";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // amountTxtBox
            // 
            this.amountTxtBox.Location = new System.Drawing.Point(538, 358);
            this.amountTxtBox.Name = "amountTxtBox";
            this.amountTxtBox.Size = new System.Drawing.Size(121, 20);
            this.amountTxtBox.TabIndex = 29;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(538, 253);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(121, 20);
            this.nameTxtBox.TabIndex = 28;
            // 
            // paymentTypeCbox
            // 
            this.paymentTypeCbox.FormattingEnabled = true;
            this.paymentTypeCbox.Location = new System.Drawing.Point(538, 399);
            this.paymentTypeCbox.Name = "paymentTypeCbox";
            this.paymentTypeCbox.Size = new System.Drawing.Size(121, 21);
            this.paymentTypeCbox.TabIndex = 27;
            // 
            // operationTypeCbox
            // 
            this.operationTypeCbox.FormattingEnabled = true;
            this.operationTypeCbox.Location = new System.Drawing.Point(538, 319);
            this.operationTypeCbox.Name = "operationTypeCbox";
            this.operationTypeCbox.Size = new System.Drawing.Size(121, 21);
            this.operationTypeCbox.TabIndex = 26;
            // 
            // _categoryCbox
            // 
            this._categoryCbox.FormattingEnabled = true;
            this._categoryCbox.Location = new System.Drawing.Point(538, 220);
            this._categoryCbox.Name = "_categoryCbox";
            this._categoryCbox.Size = new System.Drawing.Size(121, 21);
            this._categoryCbox.TabIndex = 25;
            // 
            // categoryCbox
            // 
            this.categoryCbox.FormattingEnabled = true;
            this.categoryCbox.Location = new System.Drawing.Point(538, 185);
            this.categoryCbox.Name = "categoryCbox";
            this.categoryCbox.Size = new System.Drawing.Size(121, 21);
            this.categoryCbox.TabIndex = 24;
            // 
            // paymentTypeLbl
            // 
            this.paymentTypeLbl.AutoSize = true;
            this.paymentTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.paymentTypeLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.paymentTypeLbl.Location = new System.Drawing.Point(337, 393);
            this.paymentTypeLbl.Name = "paymentTypeLbl";
            this.paymentTypeLbl.Size = new System.Drawing.Size(184, 25);
            this.paymentTypeLbl.TabIndex = 23;
            this.paymentTypeLbl.Text = "Type de paiement";
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.amountLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.amountLbl.Location = new System.Drawing.Point(388, 353);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(90, 25);
            this.amountLbl.TabIndex = 22;
            this.amountLbl.Text = "Montant";
            // 
            // operationTypeLbl
            // 
            this.operationTypeLbl.AutoSize = true;
            this.operationTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.operationTypeLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.operationTypeLbl.Location = new System.Drawing.Point(349, 315);
            this.operationTypeLbl.Name = "operationTypeLbl";
            this.operationTypeLbl.Size = new System.Drawing.Size(172, 25);
            this.operationTypeLbl.TabIndex = 21;
            this.operationTypeLbl.Text = "Type d\'opération";
            // 
            // dayLbl
            // 
            this.dayLbl.AutoSize = true;
            this.dayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dayLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dayLbl.Location = new System.Drawing.Point(398, 281);
            this.dayLbl.Name = "dayLbl";
            this.dayLbl.Size = new System.Drawing.Size(54, 25);
            this.dayLbl.TabIndex = 20;
            this.dayLbl.Text = "Jour";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nameLbl.Location = new System.Drawing.Point(398, 247);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(56, 25);
            this.nameLbl.TabIndex = 19;
            this.nameLbl.Text = "Nom";
            // 
            // _categoryLbl
            // 
            this._categoryLbl.AutoSize = true;
            this._categoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this._categoryLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this._categoryLbl.Location = new System.Drawing.Point(350, 216);
            this._categoryLbl.Name = "_categoryLbl";
            this._categoryLbl.Size = new System.Drawing.Size(157, 25);
            this._categoryLbl.TabIndex = 18;
            this._categoryLbl.Text = "Sous-catégorie";
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.categoryLbl.Location = new System.Drawing.Point(373, 181);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(105, 25);
            this.categoryLbl.TabIndex = 17;
            this.categoryLbl.Text = "Catégorie";
            // 
            // dayTxtBox
            // 
            this.dayTxtBox.Location = new System.Drawing.Point(538, 286);
            this.dayTxtBox.Name = "dayTxtBox";
            this.dayTxtBox.Size = new System.Drawing.Size(121, 20);
            this.dayTxtBox.TabIndex = 33;
            // 
            // FormAddOrEditDueComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dayTxtBox);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.amountTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.paymentTypeCbox);
            this.Controls.Add(this.operationTypeCbox);
            this.Controls.Add(this._categoryCbox);
            this.Controls.Add(this.categoryCbox);
            this.Controls.Add(this.paymentTypeLbl);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.operationTypeLbl);
            this.Controls.Add(this.dayLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this._categoryLbl);
            this.Controls.Add(this.categoryLbl);
            this.Name = "FormAddOrEditDueComponent";
            this.Size = new System.Drawing.Size(1008, 665);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox amountTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.ComboBox paymentTypeCbox;
        private System.Windows.Forms.ComboBox operationTypeCbox;
        private System.Windows.Forms.ComboBox _categoryCbox;
        private System.Windows.Forms.ComboBox categoryCbox;
        private System.Windows.Forms.Label paymentTypeLbl;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Label operationTypeLbl;
        private System.Windows.Forms.Label dayLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label _categoryLbl;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.TextBox dayTxtBox;
    }
}
