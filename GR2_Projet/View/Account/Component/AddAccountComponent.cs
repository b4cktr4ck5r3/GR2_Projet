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

        private void createBtn_Click(object sender, EventArgs e)
        {
            //Check si les champs ne sont pas vides.
            if (!(String.IsNullOrEmpty(nameTxtBox.Text) && String.IsNullOrEmpty(budgetTxtBox.Text)))
            {
                float mBudget;
                if (float.TryParse(budgetTxtBox.Text, out mBudget))
                {
                    Model.Account newAccount = new Model.Account(nameTxtBox.Text, mBudget);
                    AppFixtures.currentLoggedUser.Accounts.Add(newAccount);
                    AppFixtures.Save();
                }
                else
                    throw new Exception("Erreur, mauvaise saisie utilisateur");
            }
        }
    }
}
