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
            this.loginBtn = new System.Windows.Forms.Button();
            this.userComponentPanel = new System.Windows.Forms.Panel();
            this.registerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loginBtn.Location = new System.Drawing.Point(438, 677);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(182, 49);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Se connecter";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userComponentPanel
            // 
            this.userComponentPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userComponentPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userComponentPanel.Location = new System.Drawing.Point(0, 0);
            this.userComponentPanel.Name = "userComponentPanel";
            this.userComponentPanel.Size = new System.Drawing.Size(1008, 671);
            this.userComponentPanel.TabIndex = 1;
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.registerBtn.Location = new System.Drawing.Point(424, 677);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(212, 49);
            this.registerBtn.TabIndex = 0;
            this.registerBtn.Text = "Créer un compte";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userComponentPanel);
            this.Controls.Add(this.registerBtn);
            this.Name = "ViewUser";
            this.Size = new System.Drawing.Size(1008, 729);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Panel userComponentPanel;
        private System.Windows.Forms.Button loginBtn;
    }
}
