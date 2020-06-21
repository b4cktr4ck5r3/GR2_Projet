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
    public partial class ListOperationComponent : UserControl
    {
        public ListOperationComponent()
        {
            InitializeComponent();

            InsertData(Program.currentSelectedAccount.Operations);

        }

        public void UpdateData()
        {
            dataOperationGridView.Rows.Clear();
            InsertData(Program.currentSelectedAccount.Operations);
        }

        public void InsertData(List<Model.Operation> operations)
        {
            foreach (Model.Operation operation in operations)
                dataOperationGridView.Rows.Add(operation.Id, operation.Name, operation.PaymentType,
                    operation.Amount + "€", operation.OperationType, operation.Date.ToString());
        }
    }
}
