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
    /// <summary>
    /// Composant : Vue pour gérér les informations liés a un compte.
    /// </summary>
    public partial class ViewAccount : BaseView
    {
        public ViewAccount()
        {
            InitializeComponent();

            timerForDate.Interval = 1000;
            timerForDate.Start();
            this.dateLbl.Text = DateTime.Now.ToString();
            this.accountNameLbl.Text = Program.currentSelectedAccount.Name;
            this.budgetLbl.Text = Program.currentSelectedAccount.GetSolde() + "€";

            InsertOperationsDatas();
            InsertDueDatas();

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
            ViewManager.Instance.ShowViewOperation();
        }

        private void dueViewBtn_Click(object sender, EventArgs e)
        {
            ViewManager.Instance.ShowViewDues();
        }

        private void categoryViewBtn_Click(object sender, EventArgs e)
        {
            ViewManager.Instance.ShowViewCategory();
        }

        /// <summary>
        /// Permet de remplir les données concernant les échéances.
        /// </summary>
        private void InsertDueDatas()
        {
            foreach (Model.Due due in Program.currentSelectedAccount.Dues)
                dueGridView.Rows.Add(due.Id, due.Name, due.OperationType, due.Day.ToString(), due.PaymentType, due.Amount, due.category.GetName());
        }

        /// <summary>
        /// Permet de remplir les données concernant les opérations.
        /// </summary>
        private void InsertOperationsDatas()
        {
            var lastTenOperations = Program.currentSelectedAccount.Operations.OrderByDescending(o => o.Date).Take(10);

            foreach (Model.Operation operation in lastTenOperations)
                operationGridView.Rows.Add(operation.Id, operation.Name, operation.PaymentType, operation.Amount,
                    operation.OperationType, operation.Date.ToString(), operation.category.GetName());
        }
    }
}
