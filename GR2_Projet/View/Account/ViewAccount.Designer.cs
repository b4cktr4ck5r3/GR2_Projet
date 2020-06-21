namespace GR2_Projet.View.Account
{
    partial class ViewAccount
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.accountNameLbl = new System.Windows.Forms.Label();
            this.returnPreviousViewBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.budgetLbl = new System.Windows.Forms.Label();
            this.staticBudgetLbl = new System.Windows.Forms.Label();
            this.operationViewBtn = new System.Windows.Forms.Button();
            this.dueViewBtn = new System.Windows.Forms.Button();
            this.categoryViewBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.timerForDate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // accountNameLbl
            // 
            this.accountNameLbl.AutoSize = true;
            this.accountNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.accountNameLbl.Location = new System.Drawing.Point(26, 32);
            this.accountNameLbl.Name = "accountNameLbl";
            this.accountNameLbl.Size = new System.Drawing.Size(121, 20);
            this.accountNameLbl.TabIndex = 1;
            this.accountNameLbl.Text = "Nom du compte";
            // 
            // returnPreviousViewBtn
            // 
            this.returnPreviousViewBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.returnPreviousViewBtn.Location = new System.Drawing.Point(920, 28);
            this.returnPreviousViewBtn.Name = "returnPreviousViewBtn";
            this.returnPreviousViewBtn.Size = new System.Drawing.Size(80, 30);
            this.returnPreviousViewBtn.TabIndex = 2;
            this.returnPreviousViewBtn.Text = "Retour";
            this.returnPreviousViewBtn.UseVisualStyleBackColor = true;
            this.returnPreviousViewBtn.Click += new System.EventHandler(this.returnPreviousViewBtn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(0, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1024, 3);
            this.label3.TabIndex = 3;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateLbl.Location = new System.Drawing.Point(25, 122);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(251, 25);
            this.dateLbl.TabIndex = 4;
            this.dateLbl.Text = "DD:MM:YYYY  HH:MM";
            // 
            // budgetLbl
            // 
            this.budgetLbl.AutoSize = true;
            this.budgetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.budgetLbl.Location = new System.Drawing.Point(216, 234);
            this.budgetLbl.Name = "budgetLbl";
            this.budgetLbl.Size = new System.Drawing.Size(117, 25);
            this.budgetLbl.TabIndex = 5;
            this.budgetLbl.Text = "{SOLDE}€";
            this.budgetLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // staticBudgetLbl
            // 
            this.staticBudgetLbl.AutoSize = true;
            this.staticBudgetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticBudgetLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.staticBudgetLbl.Location = new System.Drawing.Point(25, 234);
            this.staticBudgetLbl.Name = "staticBudgetLbl";
            this.staticBudgetLbl.Size = new System.Drawing.Size(72, 25);
            this.staticBudgetLbl.TabIndex = 6;
            this.staticBudgetLbl.Text = "Solde";
            // 
            // operationViewBtn
            // 
            this.operationViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationViewBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.operationViewBtn.Location = new System.Drawing.Point(30, 343);
            this.operationViewBtn.Name = "operationViewBtn";
            this.operationViewBtn.Size = new System.Drawing.Size(303, 90);
            this.operationViewBtn.TabIndex = 7;
            this.operationViewBtn.Text = "Gestion Operations";
            this.operationViewBtn.UseVisualStyleBackColor = true;
            this.operationViewBtn.Click += new System.EventHandler(this.operationViewBtn_Click);
            // 
            // dueViewBtn
            // 
            this.dueViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueViewBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dueViewBtn.Location = new System.Drawing.Point(30, 473);
            this.dueViewBtn.Name = "dueViewBtn";
            this.dueViewBtn.Size = new System.Drawing.Size(303, 90);
            this.dueViewBtn.TabIndex = 8;
            this.dueViewBtn.Text = "Gestion Echeances";
            this.dueViewBtn.UseVisualStyleBackColor = true;
            this.dueViewBtn.Click += new System.EventHandler(this.dueViewBtn_Click);
            // 
            // categoryViewBtn
            // 
            this.categoryViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryViewBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.categoryViewBtn.Location = new System.Drawing.Point(30, 603);
            this.categoryViewBtn.Name = "categoryViewBtn";
            this.categoryViewBtn.Size = new System.Drawing.Size(303, 90);
            this.categoryViewBtn.TabIndex = 9;
            this.categoryViewBtn.Text = "Gestion Categories";
            this.categoryViewBtn.UseVisualStyleBackColor = true;
            this.categoryViewBtn.Click += new System.EventHandler(this.categoryViewBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(481, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mes écheances";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(481, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Dernières opérations";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(487, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 193);
            this.dataGridView1.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(488, 434);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(504, 260);
            this.dataGridView2.TabIndex = 13;
            // 
            // timerForDate
            // 
            this.timerForDate.Tick += new System.EventHandler(this.timerForDate_Tick);
            // 
            // ViewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.categoryViewBtn);
            this.Controls.Add(this.dueViewBtn);
            this.Controls.Add(this.operationViewBtn);
            this.Controls.Add(this.staticBudgetLbl);
            this.Controls.Add(this.budgetLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.returnPreviousViewBtn);
            this.Controls.Add(this.accountNameLbl);
            this.Controls.Add(this.label1);
            this.Name = "ViewAccount";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accountNameLbl;
        private System.Windows.Forms.Button returnPreviousViewBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label budgetLbl;
        private System.Windows.Forms.Label staticBudgetLbl;
        private System.Windows.Forms.Button operationViewBtn;
        private System.Windows.Forms.Button dueViewBtn;
        private System.Windows.Forms.Button categoryViewBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Timer timerForDate;
    }
}
