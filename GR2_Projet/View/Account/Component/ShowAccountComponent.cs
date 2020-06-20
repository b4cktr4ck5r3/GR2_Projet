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
            foreach (Model.Account account in accounts) dataAccount.Rows.Add(account.Id, account.Name, account.Budget);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
