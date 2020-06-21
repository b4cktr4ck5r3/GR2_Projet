namespace GR2_Projet.View.User
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
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminComponentPanel = new System.Windows.Forms.Panel();
            this.returnBtn = new System.Windows.Forms.Button();
            this.logoutLbl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.Control;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addBtn.Location = new System.Drawing.Point(344, 25);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 30);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Ajouter";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addAccount_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.SystemColors.Control;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.editBtn.Location = new System.Drawing.Point(450, 25);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(90, 30);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Editer";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.SystemColors.Control;
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.delBtn.Location = new System.Drawing.Point(546, 25);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(130, 30);
            this.delBtn.TabIndex = 3;
            this.delBtn.Text = "Supprimer";
            this.delBtn.UseVisualStyleBackColor = false;
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
            this.adminComponentPanel.Location = new System.Drawing.Point(0, 132);
            this.adminComponentPanel.Name = "adminComponentPanel";
            this.adminComponentPanel.Size = new System.Drawing.Size(1024, 636);
            this.adminComponentPanel.TabIndex = 7;
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.SystemColors.Control;
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.returnBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.returnBtn.Location = new System.Drawing.Point(895, 25);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(90, 30);
            this.returnBtn.TabIndex = 8;
            this.returnBtn.Text = "Retour";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // logoutLbl
            // 
            this.logoutLbl.AutoSize = true;
            this.logoutLbl.Location = new System.Drawing.Point(73, 55);
            this.logoutLbl.Name = "logoutLbl";
            this.logoutLbl.Size = new System.Drawing.Size(83, 13);
            this.logoutLbl.TabIndex = 9;
            this.logoutLbl.TabStop = true;
            this.logoutLbl.Text = "Se déconnecter";
            this.logoutLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLbl_LinkClicked);
            // 
            // ViewUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.logoutLbl);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.adminComponentPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "ViewUserAccount";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel adminComponentPanel;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.LinkLabel logoutLbl;
    }
}
