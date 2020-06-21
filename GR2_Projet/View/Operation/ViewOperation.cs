using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GR2_Projet.View.Operation.Component;

namespace GR2_Projet.View.Operation
{
    /// <summary>
    /// Composant : Vue permettant d'afficher les informatiosn liées aux opérations.
    /// </summary>
    public partial class ViewOperation : BaseView
    {
        private Component.DataGridOperationComponent dataGridComponent;
        private FormAddOrEditOperationComponent formComponent;
        private bool isDataGridActive;
        private bool isFormActive;
        public ViewOperation()
        {
            InitializeComponent();

            ShowOperationsLogic();
        }

        public void ShowOperationsLogic()
        {
            ClearComponentRessources(operationComponentPanel);
            dataGridComponent = new DataGridOperationComponent();
            ChangeComponent(operationComponentPanel, dataGridComponent);

            isDataGridActive = true;
            isFormActive = false;
        }

        public void ShowAddFormLogic()
        {
            ClearComponentRessources(operationComponentPanel);
            formComponent = new FormAddOrEditOperationComponent();
            ChangeComponent(operationComponentPanel, formComponent);

            isDataGridActive = false;
            isFormActive = true;
        }

        public void ShowEditFormLogic(Model.Operation operation)
        {
            ClearComponentRessources(operationComponentPanel);
            formComponent = new FormAddOrEditOperationComponent(operation);
            ChangeComponent(operationComponentPanel, formComponent);

            isDataGridActive = false;
            isFormActive = true;
        }

        private void returnPreviousViewBtn_Click(object sender, EventArgs e)
        {
            if(isFormActive)
                ShowOperationsLogic();
            else
                ViewManager.Instance.ShowViewAccount();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ShowAddFormLogic();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (dataGridComponent.getCurrentOperation() != null)
            {
                Controller.OperationController.DeleteOperation(Program.currentSelectedAccount,
                    dataGridComponent.getCurrentOperation().Id);
                dataGridComponent.UpdateData();
            }

        }
    }
}
