namespace GR2_Projet.View
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
            this.showAccount = new System.Windows.Forms.Button();
            this.addAccount = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.userMailLbl = new System.Windows.Forms.Label();
            this.accountPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // showAccount
            // 
            this.showAccount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.showAccount.Location = new System.Drawing.Point(335, 24);
            this.showAccount.Name = "showAccount";
            this.showAccount.Size = new System.Drawing.Size(80, 30);
            this.showAccount.TabIndex = 0;
            this.showAccount.Text = "Voir";
            this.showAccount.UseVisualStyleBackColor = true;
            this.showAccount.Click += new System.EventHandler(this.showAccount_Click);
            // 
            // addAccount
            // 
            this.addAccount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addAccount.Location = new System.Drawing.Point(416, 24);
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(80, 30);
            this.addAccount.TabIndex = 1;
            this.addAccount.Text = "Ajouter";
            this.addAccount.UseVisualStyleBackColor = true;
            this.addAccount.Click += new System.EventHandler(this.addAccount_Click);
            // 
            // editBtn
            // 
            this.editBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.editBtn.Location = new System.Drawing.Point(497, 24);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(80, 30);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Editer";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.delBtn.Location = new System.Drawing.Point(578, 24);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(80, 30);
            this.delBtn.TabIndex = 3;
            this.delBtn.Text = "Supprimer";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userNameLbl.Location = new System.Drawing.Point(16, 11);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(142, 20);
            this.userNameLbl.TabIndex = 4;
            this.userNameLbl.Text = "Nom de l\'utilisateur";
            // 
            // userMailLbl
            // 
            this.userMailLbl.AutoSize = true;
            this.userMailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMailLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userMailLbl.Location = new System.Drawing.Point(16, 34);
            this.userMailLbl.Name = "userMailLbl";
            this.userMailLbl.Size = new System.Drawing.Size(148, 20);
            this.userMailLbl.TabIndex = 5;
            this.userMailLbl.Text = "Email de l\'utilisateur";
            // 
            // accountPanel
            // 
            this.accountPanel.Location = new System.Drawing.Point(0, 71);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(1024, 697);
            this.accountPanel.TabIndex = 0;
            // 
            // ViewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.accountPanel);
            this.Controls.Add(this.userMailLbl);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addAccount);
            this.Controls.Add(this.showAccount);
            this.Name = "ViewAccount";
            this.Size = new System.Drawing.Size(1024, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button showAccount;
        private System.Windows.Forms.Button addAccount;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label userMailLbl;
        private System.Windows.Forms.Panel accountPanel;
    }
}
