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
    public partial class ShowAccountComponent : UserControl
    {
        public ShowAccountComponent(List<Model.Account> accounts)
        {
            InitializeComponent();
            foreach (Model.Account account in accounts) dataAccount.Rows.Add(account.Id, account.Name, account.Budget+"€");
        }

        private void EnableViewButtons(bool enable)
        {
            if (this.Parent != null)
                if (this.Parent.Parent != null)
                    //Reflection, permet d'appeler la fonction de l'instance parent de deux niveaux (premier parent = Control Panel contenu dans la vue parent, deuxième = Vue parent) depuis cette instance.
                    this.Parent.Parent.GetType().GetMethod("EnableButtons").Invoke(this.Parent.Parent, new object[] { enable });
        }

        private void dataAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int[] indexes = { 0, 1, 2 };
            if (indexes.Contains(e.ColumnIndex) == true)
                EnableViewButtons(true);
            else
                EnableViewButtons(false);
        }
    }
}
