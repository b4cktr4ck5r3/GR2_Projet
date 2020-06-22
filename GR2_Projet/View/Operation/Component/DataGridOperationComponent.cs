using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GR2_Projet.View.Operation.Component
{
    public partial class DataGridOperationComponent : UserControl
    {
        public DataGridOperationComponent()
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
                    operation.Amount + "€", operation.OperationType, operation.Date.ToString(), operation.category.GetName());
        }

        private Model.Operation currentOperation = null;
        public Model.Operation getCurrentOperation()
        {
            return currentOperation;
        }
        private void dataOperationGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int[] indexes = new int[dataOperationGridView.ColumnCount];
            for (int i = 0; i < dataOperationGridView.ColumnCount; i++)
                indexes[i] = i;

            if (indexes.Contains(e.ColumnIndex) == true && e.RowIndex != -1)
            {
                if (dataOperationGridView.Rows[e.RowIndex].Cells["Id"].Value != null)
                {
                    currentOperation = Program.currentSelectedAccount.Operations.Find(o =>
                        string.Compare(o.Id, dataOperationGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString()) == 0);
                }
                else
                {
                    currentOperation = null;
                }
            }
            else
            {
                currentOperation = null;
            }
        }

        private void dataOperationGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int[] indexes = new int[dataOperationGridView.ColumnCount];
            for (int i = 0; i < dataOperationGridView.ColumnCount; i++)
                indexes[i] = i;

            if (indexes.Contains(e.ColumnIndex) == true && e.RowIndex != -1)
            {
                if (dataOperationGridView.Rows[e.RowIndex].Cells["Id"].Value != null)
                {
                    Program.SearchParent(this, "ViewOperation").GetType().GetMethod("ShowEditFormLogic").Invoke(Program.SearchParent(this, "ViewOperation"), new object[] { currentOperation });
                }
            }
            else
            {
                currentOperation = null;
            }
        }

        private void dataOperationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridOperationComponent_Load(object sender, EventArgs e)
        {

        }
    }
}
