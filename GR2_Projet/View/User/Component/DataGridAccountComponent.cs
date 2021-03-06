﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GR2_Projet.View.User.Component
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
            foreach (Model.Account account in accounts) dataAccount.Rows.Add(account.Id, account.Name, account.GetSolde() + "€");
        }

        public void ResetSelection()
        {
            dataAccount.ClearSelection();
        }
        private void EnableViewButtons(bool enable)
        {
            Program.SearchParent(this, "ViewUserAccount").GetType().GetMethod("EnableButtons").Invoke(Program.SearchParent(this, "ViewUserAccount"), new object[] { enable });
        }

        private void dataAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int[] indexes = new int[dataAccount.ColumnCount];
            for (int i = 0; i < dataAccount.ColumnCount; i++)
                indexes[i] = i;

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

        private void dataAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int[] indexes = new int[dataAccount.ColumnCount];
            for (int i = 0; i < dataAccount.ColumnCount; i++)
                indexes[i] = i;

            if (indexes.Contains(e.ColumnIndex) == true && e.RowIndex != -1)
            {
                if (dataAccount.Rows[e.RowIndex].Cells["Id"].Value != null)
                {
                    currentAccount = mAccounts.Find(a => string.Compare(a.Id, dataAccount.Rows[e.RowIndex].Cells["Id"].Value.ToString()) == 0);
                    Program.currentSelectedAccount = currentAccount;
                    ViewManager.Instance.ShowViewAccount();
                }
                else
                {
                    currentAccount = null;
                }
            }
            else
            {
                currentAccount = null;
            }
        }

        private void ShowAccountComponent_Load(object sender, EventArgs e)
        {
            dataAccount.ClearSelection();
        }

        private void dataAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
