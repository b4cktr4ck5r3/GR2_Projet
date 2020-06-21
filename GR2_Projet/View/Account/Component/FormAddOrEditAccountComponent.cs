using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GR2_Projet.View.Account.Component
{
    /// <summary>
    /// Composant : Formulaire d'ajout ou d'édition d'un comtpe.
    /// </summary>
    public partial class FormAddOrEditAccountComponent : UserControl
    {
        public FormAddOrEditAccountComponent()
        {
            InitializeComponent();

            this.addBtn.Visible = true;
            this.editBtn.Visible = false;

            this.budgetTxtBox.Visible = true;
            this.budgetLbl.Visible = true;

        }

        private Model.Account mAccount;
        public FormAddOrEditAccountComponent(Model.Account account)
        {
            mAccount = account;
            InitializeComponent();

            this.nameTxtBox.Text = account.Name;

            this.editBtn.Visible = true;
            this.addBtn.Visible = false;

            this.budgetTxtBox.Visible = false;
            this.budgetLbl.Visible = false;
        }

        /// <summary>
        /// Logique d'ajout d'un compte.
        /// </summary>
        private void addBtn_Click(object sender, EventArgs e)
        {
            //Check si les champs ne sont pas vides.
            if (!(String.IsNullOrEmpty(nameTxtBox.Text) && String.IsNullOrEmpty(budgetTxtBox.Text)))
            {
                float mBudget;
                if (float.TryParse(budgetTxtBox.Text, out mBudget))
                {
                    Controller.AccountController.AddAccount(Program.currentLoggedUser, nameTxtBox.Text, mBudget);
                    Program.SearchParent(this, "ViewUserAccount").GetType().GetMethod("showAccountLogic").Invoke(Program.SearchParent(this, "ViewUserAccount"), new object[] { });
                }
                else
                    throw new Exception("Erreur, mauvaise saisie utilisateur");
            }
        }

        /// <summary>
        /// Logique d'édition d'un compte.
        /// </summary>
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nameTxtBox.Text))
            {
                Controller.AccountController.EditAccount(Program.currentLoggedUser, mAccount.Id, nameTxtBox.Text);
                Program.SearchParent(this, "ViewUserAccount").GetType().GetMethod("showAccountLogic").Invoke(Program.SearchParent(this, "ViewUserAccount"), new object[] { });
            }
            else
                throw new Exception("Erreur, mauvaise saisie utilisateur");
        }
    }
}
