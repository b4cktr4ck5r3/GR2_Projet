namespace GR2_Projet.View.Category
{
    partial class ViewCategory
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
            this.lbNomCompte = new System.Windows.Forms.Label();
            this.btRetour = new System.Windows.Forms.Button();
            this.lbListeCategorie = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbParent = new System.Windows.Forms.Label();
            this.btAjouter = new System.Windows.Forms.Button();
            this.lbAjouterCategorie = new System.Windows.Forms.Label();
            this.gbListeCategorie = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbAjouterCategorie = new System.Windows.Forms.GroupBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.gbListeCategorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbAjouterCategorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNomCompte
            // 
            this.lbNomCompte.AutoSize = true;
            this.lbNomCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomCompte.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbNomCompte.Location = new System.Drawing.Point(26, 32);
            this.lbNomCompte.Name = "lbNomCompte";
            this.lbNomCompte.Size = new System.Drawing.Size(121, 20);
            this.lbNomCompte.TabIndex = 0;
            this.lbNomCompte.Text = "Nom du compte";
            // 
            // btRetour
            // 
            this.btRetour.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btRetour.Location = new System.Drawing.Point(920, 28);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(80, 30);
            this.btRetour.TabIndex = 1;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            // 
            // lbListeCategorie
            // 
            this.lbListeCategorie.AutoSize = true;
            this.lbListeCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListeCategorie.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbListeCategorie.Location = new System.Drawing.Point(25, 26);
            this.lbListeCategorie.Name = "lbListeCategorie";
            this.lbListeCategorie.Size = new System.Drawing.Size(225, 25);
            this.lbListeCategorie.TabIndex = 2;
            this.lbListeCategorie.Text = "Liste des catégories";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbNom.Location = new System.Drawing.Point(18, 72);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(46, 20);
            this.lbNom.TabIndex = 3;
            this.lbNom.Text = "Nom ";
            // 
            // lbParent
            // 
            this.lbParent.AutoSize = true;
            this.lbParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbParent.Location = new System.Drawing.Point(395, 71);
            this.lbParent.Name = "lbParent";
            this.lbParent.Size = new System.Drawing.Size(56, 20);
            this.lbParent.TabIndex = 4;
            this.lbParent.Text = "Parent";
            // 
            // btAjouter
            // 
            this.btAjouter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btAjouter.Location = new System.Drawing.Point(866, 65);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(80, 30);
            this.btAjouter.TabIndex = 6;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.UseVisualStyleBackColor = true;
            // 
            // lbAjouterCategorie
            // 
            this.lbAjouterCategorie.AutoSize = true;
            this.lbAjouterCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAjouterCategorie.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbAjouterCategorie.Location = new System.Drawing.Point(369, 25);
            this.lbAjouterCategorie.Name = "lbAjouterCategorie";
            this.lbAjouterCategorie.Size = new System.Drawing.Size(238, 25);
            this.lbAjouterCategorie.TabIndex = 7;
            this.lbAjouterCategorie.Text = "Ajouter une catégorie";
            // 
            // gbListeCategorie
            // 
            this.gbListeCategorie.Controls.Add(this.dataGridView1);
            this.gbListeCategorie.Controls.Add(this.lbListeCategorie);
            this.gbListeCategorie.Location = new System.Drawing.Point(0, 80);
            this.gbListeCategorie.Name = "gbListeCategorie";
            this.gbListeCategorie.Size = new System.Drawing.Size(1024, 478);
            this.gbListeCategorie.TabIndex = 8;
            this.gbListeCategorie.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(970, 384);
            this.dataGridView1.TabIndex = 3;
            // 
            // gbAjouterCategorie
            // 
            this.gbAjouterCategorie.Controls.Add(this.tbNom);
            this.gbAjouterCategorie.Controls.Add(this.btAjouter);
            this.gbAjouterCategorie.Controls.Add(this.cbCategorie);
            this.gbAjouterCategorie.Controls.Add(this.lbAjouterCategorie);
            this.gbAjouterCategorie.Controls.Add(this.lbNom);
            this.gbAjouterCategorie.Controls.Add(this.lbParent);
            this.gbAjouterCategorie.Location = new System.Drawing.Point(30, 590);
            this.gbAjouterCategorie.Name = "gbAjouterCategorie";
            this.gbAjouterCategorie.Size = new System.Drawing.Size(970, 145);
            this.gbAjouterCategorie.TabIndex = 9;
            this.gbAjouterCategorie.TabStop = false;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(70, 72);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 3;
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(457, 71);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(121, 21);
            this.cbCategorie.TabIndex = 3;
            // 
            // ViewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAjouterCategorie);
            this.Controls.Add(this.gbListeCategorie);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.lbNomCompte);
            this.Name = "ViewCategory";
            this.Size = new System.Drawing.Size(1024, 768);
            this.gbListeCategorie.ResumeLayout(false);
            this.gbListeCategorie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbAjouterCategorie.ResumeLayout(false);
            this.gbAjouterCategorie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomCompte;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Label lbListeCategorie;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbParent;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.Label lbAjouterCategorie;
        private System.Windows.Forms.GroupBox gbListeCategorie;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbAjouterCategorie;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.ComboBox cbCategorie;
    }
}
