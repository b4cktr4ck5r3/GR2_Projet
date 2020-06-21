using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GR2_Projet.View.Account
{
    public partial class ViewAccount : BaseView
    {
        private Model.Account mAccount;
        public ViewAccount(Model.Account account)
        {
            InitializeComponent();

            timerForDate.Interval = 1000;
            timerForDate.Start();
            this.dateLbl.Text = DateTime.Now.ToString();
            this.accountNameLbl.Text = account.Name;
            this.budgetLbl.Text = account.Budget + "€";
            mAccount = account;
        }

        private void timerForDate_Tick(object sender, EventArgs e)
        {
            this.dateLbl.Text = DateTime.Now.ToString();

        }

        private void returnPreviousViewBtn_Click(object sender, EventArgs e)
        {
            ViewManager.Instance.ShowViewUserAccounts();
        }

        private void operationViewBtn_Click(object sender, EventArgs e)
        {
            //ViewManager.Instance.ShowViewOperation();
        }

        private void dueViewBtn_Click(object sender, EventArgs e)
        {

        }

        private void categoryViewBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
