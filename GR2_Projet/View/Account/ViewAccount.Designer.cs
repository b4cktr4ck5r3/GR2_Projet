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
            this.accountPanel = new System.Windows.Forms.Panel();
            this.showAccount = new System.Windows.Forms.Button();
            this.addAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountPanel
            // 
            this.accountPanel.Location = new System.Drawing.Point(0, 37);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(1024, 731);
            this.accountPanel.TabIndex = 0;
            // 
            // showAccount
            // 
            this.showAccount.Location = new System.Drawing.Point(3, 8);
            this.showAccount.Name = "showAccount";
            this.showAccount.Size = new System.Drawing.Size(75, 23);
            this.showAccount.TabIndex = 0;
            this.showAccount.Text = "Voir";
            this.showAccount.UseVisualStyleBackColor = true;
            this.showAccount.Click += new System.EventHandler(this.showAccount_Click);
            // 
            // addAccount
            // 
            this.addAccount.Location = new System.Drawing.Point(84, 8);
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(75, 23);
            this.addAccount.TabIndex = 1;
            this.addAccount.Text = "Ajouter";
            this.addAccount.UseVisualStyleBackColor = true;
            this.addAccount.Click += new System.EventHandler(this.addAccount_Click);
            // 
            // ViewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.addAccount);
            this.Controls.Add(this.accountPanel);
            this.Controls.Add(this.showAccount);
            this.Name = "ViewAccount";
            this.Size = new System.Drawing.Size(1024, 768);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.Button showAccount;
        private System.Windows.Forms.Button addAccount;
    }
}
