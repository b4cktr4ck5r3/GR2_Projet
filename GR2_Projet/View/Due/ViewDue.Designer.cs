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
            this.lbListeEcheance = new System.Windows.Forms.Label();
            this.dueComponentPanel = new System.Windows.Forms.GroupBox();
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
            // lbListeEcheance
            // 
            this.lbListeEcheance.AutoSize = true;
            this.lbListeEcheance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListeEcheance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbListeEcheance.Location = new System.Drawing.Point(26, 32);
            this.lbListeEcheance.Name = "lbListeEcheance";
            this.lbListeEcheance.Size = new System.Drawing.Size(155, 20);
            this.lbListeEcheance.TabIndex = 2;
            this.lbListeEcheance.Text = "Liste des échéances";
            // 
            // dueComponentPanel
            // 
            this.dueComponentPanel.Location = new System.Drawing.Point(0, 80);
            this.dueComponentPanel.Name = "dueComponentPanel";
            this.dueComponentPanel.Size = new System.Drawing.Size(1024, 638);
            this.dueComponentPanel.TabIndex = 4;
            this.dueComponentPanel.TabStop = false;
            // 
            // ViewDue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dueComponentPanel);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.lbListeEcheance);
            this.Location = new System.Drawing.Point(26, 32);
            this.Name = "ViewDue";
            this.Size = new System.Drawing.Size(1024, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Label lbListeEcheance;
        private System.Windows.Forms.GroupBox dueComponentPanel;
    }
}
