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

namespace GR2_Projet.View.Due.Component
{
    public partial class FormAddOrEditDueComponent : UserControl
    {
        public FormAddOrEditDueComponent()
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

        private Model.Due mDue;
        public FormAddOrEditDueComponent(Model.Due due)
        {
            InitializeComponent();
            UpdateCbox();

            this.nameTxtBox.Text = due.Name;
            this.amountTxtBox.Text = due.Amount.ToString();
            this.dayTxtBox.Text = due.Day.ToString();
            this.categoryCbox.SelectedItem = due.category.GetName();
            this.paymentTypeCbox.SelectedItem = due.PaymentType;
            this.operationTypeCbox.SelectedItem = due.OperationType;
            mDue = due;

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                operationType operationType;
                operationType.TryParse(operationTypeCbox.SelectedItem.ToString(), out operationType);

                paymentType paymentType;
                paymentType.TryParse(paymentTypeCbox.SelectedItem.ToString(), out paymentType);

                Controller.DueController.AddDue(Program.currentSelectedAccount, nameTxtBox.Text, operationType,
                    int.Parse(dayTxtBox.Text), paymentType, float.Parse(amountTxtBox.Text),
                    Program.currentLoggedUser.Categories.Find(c => c.GetName() == categoryCbox.SelectedItem.ToString()));
                Program.SearchParent(this, "ViewDue").GetType().GetMethod("ShowDuesLogic").Invoke(Program.SearchParent(this, "ViewDue"), new object[] { });
            }
            catch (Exception)
            {

            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                operationType operationType;
                operationType.TryParse(operationTypeCbox.SelectedItem.ToString(), out operationType);

                paymentType paymentType;
                paymentType.TryParse(paymentTypeCbox.SelectedItem.ToString(), out paymentType);

                Controller.DueController.EditDue(mDue, nameTxtBox.Text, float.Parse(amountTxtBox.Text), paymentType, operationType, int.Parse(dayTxtBox.Text), Program.currentLoggedUser.Categories.Find(c => c.GetName() == categoryCbox.SelectedItem.ToString()));

                Program.SearchParent(this, "ViewDue").GetType().GetMethod("ShowDuesLogic").Invoke(Program.SearchParent(this, "ViewDue"), new object[] {});
            }
            catch (Exception)
            {

            }
        }


    }
}
