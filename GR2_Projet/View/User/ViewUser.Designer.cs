namespace GR2_Projet.View.User
{
    partial class ViewUser
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
            this.Créer = new System.Windows.Forms.Button();
            this.userComponentPanel = new System.Windows.Forms.Panel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Créer
            // 
            this.Créer.Location = new System.Drawing.Point(372, 360);
            this.Créer.Name = "Créer";
            this.Créer.Size = new System.Drawing.Size(75, 23);
            this.Créer.TabIndex = 0;
            this.Créer.Text = "registerBtn";
            this.Créer.UseVisualStyleBackColor = true;
            this.Créer.Click += new System.EventHandler(this.Créer_Click);
            // 
            // userComponentPanel
            // 
            this.userComponentPanel.Location = new System.Drawing.Point(53, 37);
            this.userComponentPanel.Name = "userComponentPanel";
            this.userComponentPanel.Size = new System.Drawing.Size(495, 295);
            this.userComponentPanel.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(291, 360);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "loginBtn";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userComponentPanel);
            this.Controls.Add(this.Créer);
            this.Name = "ViewUser";
            this.Size = new System.Drawing.Size(904, 523);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Créer;
        private System.Windows.Forms.Panel userComponentPanel;
        private System.Windows.Forms.Button loginBtn;
    }
}
