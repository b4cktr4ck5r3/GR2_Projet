namespace GR2_Projet.View
{
    partial class ViewUserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUserAccount));
            this.showAccount = new System.Windows.Forms.Button();
            this.addAccount = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminComponentPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // showAccount
            // 
            this.showAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAccount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.showAccount.Location = new System.Drawing.Point(579, 26);
            this.showAccount.Name = "showAccount";
            this.showAccount.Size = new System.Drawing.Size(85, 34);
            this.showAccount.TabIndex = 0;
            this.showAccount.Text = "Voir";
            this.showAccount.UseVisualStyleBackColor = true;
            this.showAccount.Click += new System.EventHandler(this.showAccount_Click);
            // 
            // addAccount
            // 
            this.addAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAccount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addAccount.Location = new System.Drawing.Point(670, 25);
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(108, 35);
            this.addAccount.TabIndex = 1;
            this.addAccount.Text = "Ajouter";
            this.addAccount.UseVisualStyleBackColor = true;
            this.addAccount.Click += new System.EventHandler(this.addAccount_Click);
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.editBtn.Location = new System.Drawing.Point(784, 26);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(89, 34);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Editer";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.delBtn.Location = new System.Drawing.Point(879, 26);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(127, 34);
            this.delBtn.TabIndex = 3;
            this.delBtn.Text = "Supprimer";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.userNameLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userNameLbl.Location = new System.Drawing.Point(71, 29);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(197, 26);
            this.userNameLbl.TabIndex = 4;
            this.userNameLbl.Text = "Nom de l\'utilisateur";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // adminComponentPanel
            // 
            this.adminComponentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adminComponentPanel.Location = new System.Drawing.Point(0, 93);
            this.adminComponentPanel.Name = "adminComponentPanel";
            this.adminComponentPanel.Size = new System.Drawing.Size(1024, 675);
            this.adminComponentPanel.TabIndex = 7;
            // 
            // ViewUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.adminComponentPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addAccount);
            this.Controls.Add(this.showAccount);
            this.Name = "ViewUserAccount";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button showAccount;
        private System.Windows.Forms.Button addAccount;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel adminComponentPanel;
    }
}
