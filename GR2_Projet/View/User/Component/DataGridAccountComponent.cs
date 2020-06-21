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
        private List<Model.Account> mAccounts;
        public ShowAccountComponent(List<Model.Account> accounts)
        {
            InitializeComponent();
            mAccounts = accounts;
            InsertData(accounts);
        }

        public void UpdateData(List<Model.Account> accounts)
        {
            mAccounts = accounts;
            dataAccount.Rows.Clear();
            InsertData(accounts);
        }

        public void InsertData(List<Model.Account> accounts)
        {
            foreach (Model.Account account in accounts) dataAccount.Rows.Add(account.Id, account.Name, account.Budget + "€");
        }

        private void EnableViewButtons(bool enable)
        {
            AppFixtures.SearchParent(this, "ViewAccount").GetType().GetMethod("EnableButtons").Invoke(this.Parent.Parent, new object[] { enable });
        }

        private void dataAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int[] indexes = { 0, 1, 2 };
            if (indexes.Contains(e.ColumnIndex) == true && e.RowIndex != -1)
            {
                if(dataAccount.Rows[e.RowIndex].Cells["Id"].Value != null)
                {
                    EnableViewButtons(true);
                    currentAccount = mAccounts.Find(a => string.Compare(a.Id, dataAccount.Rows[e.RowIndex].Cells["Id"].Value.ToString()) == 0);
                }
                else
                {
                    EnableViewButtons(false);
                    currentAccount = null;
                }
            }
            else
            {
                EnableViewButtons(false);
                currentAccount = null;
            }
        }

        private Model.Account currentAccount;
        public Model.Account getCurrentAccount()
        {
            return currentAccount;
        }
    }
}
