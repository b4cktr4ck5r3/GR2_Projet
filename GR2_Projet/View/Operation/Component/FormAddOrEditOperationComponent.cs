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
            UpdateCbox();

            this.addBtn.Visible = true;
            this.editBtn.Visible = false;

        }

        private void UpdateCbox()
        {
            foreach (Model.Category category in Program.currentLoggedUser.Categories)
                categoryCbox.Items.Add(category.GetName());

            var pt_values = Enum.GetValues(typeof(paymentType));
            var ot_values = Enum.GetValues(typeof(operationType));

            foreach (paymentType pt in pt_values)
                paymentTypeCbox.Items.Add(pt);

            foreach (operationType ot in ot_values)
                operationTypeCbox.Items.Add(ot);
        }

        private Model.Operation mOperation;
        public FormAddOrEditOperationComponent(Model.Operation operation)
        {
            InitializeComponent();
            UpdateCbox();

            mOperation = operation;

            this.nameTxtBox.Text = operation.Name;
            this.operationTypeCbox.SelectedItem = operation.OperationType;
            this.dateTPicker.Value = operation.Date;
            this.paymentTypeCbox.SelectedItem = operation.PaymentType;
            this.amountTxtBox.Text = operation.Amount.ToString();
            this.categoryCbox.SelectedItem = operation.category.GetName();


            this.editBtn.Visible = true;
            this.addBtn.Visible = false;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            operationType operationType;
            operationType.TryParse(operationTypeCbox.SelectedItem.ToString(), out operationType);

            paymentType paymentType;
            paymentType.TryParse(paymentTypeCbox.SelectedItem.ToString(), out paymentType);

            Controller.OperationController.AddOperation(Program.currentSelectedAccount, nameTxtBox.Text,
                operationType, dateTPicker.Value, paymentType, float.Parse(amountTxtBox.Text), Program.currentLoggedUser.Categories.Find(c => c.GetName() == categoryCbox.SelectedItem.ToString()));

            Program.SearchParent(this, "ViewOperation").GetType().GetMethod("ShowOperationsLogic").Invoke(Program.SearchParent(this, "ViewOperation"), new object[] { });
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            operationType operationType;
            operationType.TryParse(operationTypeCbox.SelectedItem.ToString(), out operationType);

            paymentType paymentType;
            paymentType.TryParse(paymentTypeCbox.SelectedItem.ToString(), out paymentType);

            Controller.OperationController.EditOperation(mOperation, nameTxtBox.Text,
                float.Parse(amountTxtBox.Text), paymentType, operationType, dateTPicker.Value, Program.currentLoggedUser.Categories.Find(c => c.GetName() == categoryCbox.SelectedItem.ToString()));

            Program.SearchParent(this, "ViewOperation").GetType().GetMethod("ShowOperationsLogic").Invoke(Program.SearchParent(this, "ViewOperation"), new object[] { });

        }
    }
}