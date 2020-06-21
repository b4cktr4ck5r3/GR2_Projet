namespace GR2_Projet.View.Operation
{
    partial class ViewOperation
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
            this.label3 = new System.Windows.Forms.Label();
            this.returnPreviousViewBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.operationComponentPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(0, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1024, 3);
            this.label3.TabIndex = 7;
            // 
            // returnPreviousViewBtn
            // 
            this.returnPreviousViewBtn.Location = new System.Drawing.Point(876, 25);
            this.returnPreviousViewBtn.Name = "returnPreviousViewBtn";
            this.returnPreviousViewBtn.Size = new System.Drawing.Size(116, 48);
            this.returnPreviousViewBtn.TabIndex = 6;
            this.returnPreviousViewBtn.Text = "Retour";
            this.returnPreviousViewBtn.UseVisualStyleBackColor = true;
            this.returnPreviousViewBtn.Click += new System.EventHandler(this.returnPreviousViewBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Opérations";
            // 
            // operationComponentPanel
            // 
            this.operationComponentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.operationComponentPanel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.operationComponentPanel.Location = new System.Drawing.Point(0, 76);
            this.operationComponentPanel.Name = "operationComponentPanel";
            this.operationComponentPanel.Size = new System.Drawing.Size(1024, 664);
            this.operationComponentPanel.TabIndex = 8;
            // 
            // ViewOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.operationComponentPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.returnPreviousViewBtn);
            this.Controls.Add(this.label2);
            this.Name = "ViewOperation";
            this.Size = new System.Drawing.Size(1024, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button returnPreviousViewBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel operationComponentPanel;
    }
}
