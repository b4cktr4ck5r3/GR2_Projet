namespace GR2_Projet.View.Due
{
    partial class ViewDue
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
            this.btRetour = new System.Windows.Forms.Button();
            this.lbNomCompte = new System.Windows.Forms.Label();
            this.gbComponent = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btRetour
            // 
            this.btRetour.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btRetour.Location = new System.Drawing.Point(920, 28);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(80, 30);
            this.btRetour.TabIndex = 3;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            // 
            // lbNomCompte
            // 
            this.lbNomCompte.AutoSize = true;
            this.lbNomCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomCompte.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbNomCompte.Location = new System.Drawing.Point(26, 32);
            this.lbNomCompte.Name = "lbNomCompte";
            this.lbNomCompte.Size = new System.Drawing.Size(121, 20);
            this.lbNomCompte.TabIndex = 2;
            this.lbNomCompte.Text = "Nom du compte";
            // 
            // gbComponent
            // 
            this.gbComponent.Location = new System.Drawing.Point(0, 80);
            this.gbComponent.Name = "gbComponent";
            this.gbComponent.Size = new System.Drawing.Size(1024, 638);
            this.gbComponent.TabIndex = 4;
            this.gbComponent.TabStop = false;
            // 
            // ViewDue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbComponent);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.lbNomCompte);
            this.Name = "ViewDue";
            this.Size = new System.Drawing.Size(1024, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Label lbNomCompte;
        private System.Windows.Forms.GroupBox gbComponent;
    }
}
