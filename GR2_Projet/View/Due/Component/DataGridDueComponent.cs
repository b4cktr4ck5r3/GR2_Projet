using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GR2_Projet.View.Due.Component
{
    public partial class DataGridDueComponent : UserControl
    {
        public DataGridDueComponent()
        {
            InitializeComponent();
            InsertData(Program.currentSelectedAccount.Dues);
        }

        public void UpdateData()
        {
            dataDuesGrid.Rows.Clear();
            InsertData(Program.currentSelectedAccount.Dues);
        }

        public void InsertData(List<Model.Due> dues)
        {
            foreach (Model.Due due in dues)
                dataDuesGrid.Rows.Add(due.Id, due.Name, due.OperationType, due.Day, due.PaymentType, due.Amount+"€",
                    due.category.GetName());
        }

        private Model.Due currentDue;
        private void dataDuesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int[] indexes = new int[dataDuesGrid.ColumnCount];
            for (int i = 0; i < dataDuesGrid.ColumnCount; i++)
                indexes[i] = i;

            if (indexes.Contains(e.ColumnIndex) == true && e.RowIndex != -1)
            {
                if (dataDuesGrid.Rows[e.RowIndex].Cells["Id"].Value != null)
                {
                    currentDue = Program.currentSelectedAccount.Dues.Find(d =>
                        string.Compare(d.Id, dataDuesGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString()) == 0);
                }
                else
                {
                    currentDue = null;
                }
            }
            else
            {
                currentDue = null;
            }
        }

        private void dataDuesGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int[] indexes = new int[dataDuesGrid.ColumnCount];
            for (int i = 0; i < dataDuesGrid.ColumnCount; i++)
                indexes[i] = i;

            if (indexes.Contains(e.ColumnIndex) == true && e.RowIndex != -1)
            {
                if (dataDuesGrid.Rows[e.RowIndex].Cells["Id"].Value != null)
                {
                    AppFixtures.SearchParent(this, "ViewDue").GetType().GetMethod("ShowEditFormLogic").Invoke(AppFixtures.SearchParent(this, "ViewDue"), new object[] { currentDue });
                }
            }
            else
            {
                currentDue = null;
            }
        }
    }
}
