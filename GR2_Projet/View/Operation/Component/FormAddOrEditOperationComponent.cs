using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GR2_Projet.Model;

namespace GR2_Projet.View.Operation.Component
{
    public partial class FormAddOrEditOperationComponent : UserControl
    {
        public FormAddOrEditOperationComponent()
        {
            InitializeComponent();

            this.addBtn.Visible = true;
            this.editBtn.Visible = false;
        }

        private Model.Operation mOperation;
        public FormAddOrEditOperationComponent(Model.Operation operation)
        {
            mOperation = operation;
            this.editBtn.Visible = true;
            this.addBtn.Visible = false;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            operationType operationType;
            operationType.TryParse(operationTypeCbox.SelectedItem.ToString(), out operationType);

            paymentType paymentType;
            paymentType.TryParse(paymentTypeCbox.SelectedItem.ToString(), out paymentType);

            Model.Operation newOperation = new Model.Operation(nameTxtBox.Text,
                operationType, dateTPicker.Value, paymentType, float.Parse(amountTxtBox.Text));

            Program.currentSelectedAccount.Operations.Add(newOperation);
            Program.ctx.Save();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
