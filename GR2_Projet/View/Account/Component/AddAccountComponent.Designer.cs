﻿namespace GR2_Projet.View.Account.Component
{
    partial class AddAccountComponent
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
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.budgetTxtBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.budgetLbl = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(431, 75);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 0;
            // 
            // budgetTxtBox
            // 
            this.budgetTxtBox.Location = new System.Drawing.Point(431, 116);
            this.budgetTxtBox.Name = "budgetTxtBox";
            this.budgetTxtBox.Size = new System.Drawing.Size(100, 20);
            this.budgetTxtBox.TabIndex = 1;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(428, 59);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(85, 13);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Nom du compte:";
            // 
            // budgetLbl
            // 
            this.budgetLbl.AutoSize = true;
            this.budgetLbl.Location = new System.Drawing.Point(428, 100);
            this.budgetLbl.Name = "budgetLbl";
            this.budgetLbl.Size = new System.Drawing.Size(44, 13);
            this.budgetLbl.TabIndex = 3;
            this.budgetLbl.Text = "Budget:";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(431, 152);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 4;
            this.createBtn.Text = "Créer";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // AddAccountComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.budgetLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.budgetTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Name = "AddAccountComponent";
            this.Size = new System.Drawing.Size(1024, 731);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox budgetTxtBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label budgetLbl;
        private System.Windows.Forms.Button createBtn;
    }
}