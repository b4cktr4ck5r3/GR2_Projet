namespace GR2_Projet.View.User.Component
{
    partial class FormLoginUserComponent
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
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(181, 117);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(28, 13);
            this.passwordLbl.TabIndex = 11;
            this.passwordLbl.Text = "Mdp";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(181, 91);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(29, 13);
            this.usernameLbl.TabIndex = 10;
            this.usernameLbl.Text = "Nom";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(234, 140);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "Créer";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(222, 114);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTxtBox.TabIndex = 8;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(222, 88);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTxtBox.TabIndex = 7;
            // 
            // FormLoginUserComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.usernameTxtBox);
            this.Name = "FormLoginUserComponent";
            this.Size = new System.Drawing.Size(558, 406);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.TextBox usernameTxtBox;
    }
}
