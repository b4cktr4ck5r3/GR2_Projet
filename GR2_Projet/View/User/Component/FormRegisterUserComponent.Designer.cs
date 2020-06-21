namespace GR2_Projet.View.User.Component
{
    partial class FormRegisterUserComponent
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
            this.mailTxtBox = new System.Windows.Forms.TextBox();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.mailLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mailTxtBox
            // 
            this.mailTxtBox.Location = new System.Drawing.Point(120, 25);
            this.mailTxtBox.Name = "mailTxtBox";
            this.mailTxtBox.Size = new System.Drawing.Size(100, 20);
            this.mailTxtBox.TabIndex = 0;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(120, 51);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTxtBox.TabIndex = 1;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(120, 77);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTxtBox.TabIndex = 2;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(132, 103);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 3;
            this.registerBtn.Text = "Créer";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // mailLbl
            // 
            this.mailLbl.AutoSize = true;
            this.mailLbl.Location = new System.Drawing.Point(79, 28);
            this.mailLbl.Name = "mailLbl";
            this.mailLbl.Size = new System.Drawing.Size(32, 13);
            this.mailLbl.TabIndex = 4;
            this.mailLbl.Text = "Email";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(79, 54);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(29, 13);
            this.usernameLbl.TabIndex = 5;
            this.usernameLbl.Text = "Nom";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(79, 80);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(28, 13);
            this.passwordLbl.TabIndex = 6;
            this.passwordLbl.Text = "Mdp";
            // 
            // FormRegisterUserComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.mailLbl);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.mailTxtBox);
            this.Name = "FormRegisterUserComponent";
            this.Size = new System.Drawing.Size(351, 267);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mailTxtBox;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label mailLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
    }
}
