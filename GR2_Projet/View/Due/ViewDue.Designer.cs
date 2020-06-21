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
            this.dueComponentPanel = new System.Windows.Forms.Panel();
            this.delBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRetour
            // 
            this.btRetour.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btRetour.Location = new System.Drawing.Point(925, 18);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(80, 30);
            this.btRetour.TabIndex = 3;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // lbListeEcheance
            // 
            this.lbListeEcheance.AutoSize = true;
            this.lbListeEcheance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListeEcheance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbListeEcheance.Location = new System.Drawing.Point(17, 28);
            this.lbListeEcheance.Name = "lbListeEcheance";
            this.lbListeEcheance.Size = new System.Drawing.Size(155, 20);
            this.lbListeEcheance.TabIndex = 2;
            this.lbListeEcheance.Text = "Liste des échéances";
            // 
            // dueComponentPanel
            // 
            this.dueComponentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dueComponentPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.dueComponentPanel.Location = new System.Drawing.Point(0, 64);
            this.dueComponentPanel.Name = "dueComponentPanel";
            this.dueComponentPanel.Size = new System.Drawing.Size(1008, 665);
            this.dueComponentPanel.TabIndex = 5;
            // 
            // delBtn
            // 
            this.delBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.delBtn.Location = new System.Drawing.Point(793, 18);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(80, 30);
            this.delBtn.TabIndex = 6;
            this.delBtn.Text = "Supprimer";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addBtn.Location = new System.Drawing.Point(707, 18);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(80, 30);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Ajouter";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ViewDue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.dueComponentPanel);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.lbListeEcheance);
            this.Location = new System.Drawing.Point(26, 32);
            this.Name = "ViewDue";
            this.Size = new System.Drawing.Size(1008, 729);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Label lbListeEcheance;
        private System.Windows.Forms.Panel dueComponentPanel;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addBtn;
    }
}
