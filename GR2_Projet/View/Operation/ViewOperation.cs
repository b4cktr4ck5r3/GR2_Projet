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
    public partial class ViewOperation : BaseView
    {
        private Component.DataGridOperationComponent dataGridCompoennt;
        private bool isDataGridActive;
        private bool isFormActive;
        public ViewOperation()
        {
            InitializeComponent();

            ShowOperationsLogic();
        }

        private void ShowOperationsLogic()
        {
            ClearComponentRessources(operationComponentPanel);
            dataGridCompoennt = new DataGridOperationComponent();
            ChangeComponent(operationComponentPanel, dataGridCompoennt);

            isDataGridActive = true;
            isFormActive = false;
        }

        //private void showAccount_Click(object sender, EventArgs e)
        //{
        //    if (!isShowComponentActive)
        //    {
        //        showAccountLogic();
        //        this.adminComponentPanel.Text = "Mes comptes";
        //        ShowButtons(true);
        //    }
        //}

        //private void showAccountLogic()
        //{
        //    ClearComponentRessources(adminComponentPanel);
        //    showComponent = new Account.Component.ShowAccountComponent(Program.currentLoggedUser.Accounts);
        //    ChangeComponent(adminComponentPanel, showComponent);

        //    isShowComponentActive = true;
        //    isAddComponentActive = false;
        //}

        private void returnPreviousViewBtn_Click(object sender, EventArgs e)
        {
            ViewManager.Instance.ShowViewAccount();
        }
    }
}
