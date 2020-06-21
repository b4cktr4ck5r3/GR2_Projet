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
    public partial class AddAccountComponent : UserControl
    {
        public AddAccountComponent()
        {
            InitializeComponent();
        }

        public AddAccountComponent(Model.Account account)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            //Check si les champs ne sont pas vides.
            if (!(String.IsNullOrEmpty(nameTxtBox.Text) && String.IsNullOrEmpty(budgetTxtBox.Text)))
            {
                float mBudget;
                if (float.TryParse(budgetTxtBox.Text, out mBudget))
                {
                    Controller.AccountController.AddAccount(AppFixtures.currentLoggedUser, nameTxtBox.Text, mBudget);
                }
                else
                    throw new Exception("Erreur, mauvaise saisie utilisateur");
            }
        }
    }
}
