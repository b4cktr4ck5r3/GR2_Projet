using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GR2_Projet.View.Due.Component;

namespace GR2_Projet.View.Due
{
    public partial class ViewDue : BaseView
    {
        private DataGridDueComponent dataGridDue;
        private FormAddOrEditDueComponent form;
        private bool isDataGridActive;
        private bool isFormActive;
        public ViewDue()
        {
            InitializeComponent();

            ShowDuesLogic();
        }

        public void ShowDuesLogic()
        {
            ClearComponentRessources(dueComponentPanel);
            dataGridDue = new DataGridDueComponent();
            ChangeComponent(dueComponentPanel, dataGridDue);

            isDataGridActive = true;
            isFormActive = false;
        }

        public void ShowEditFormLogic(Model.Due due)
        {
            ClearComponentRessources(dueComponentPanel);
            form = new FormAddOrEditDueComponent(due);
            ChangeComponent(dueComponentPanel, form);

            isFormActive = true;
            isDataGridActive = false;
        }

        public void ShowAddFormLogic()
        {
            ClearComponentRessources(dueComponentPanel);
            form = new FormAddOrEditDueComponent();
            ChangeComponent(dueComponentPanel, form);

            isFormActive = true;
            isDataGridActive = false;
        }

        private void btRetour_Click(object sender, EventArgs e)
        {
            if(isFormActive)
                ShowDuesLogic();
            else
                ViewManager.Instance.ShowViewAccount();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ShowAddFormLogic();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (dataGridDue.getCurrentDue() != null)
            {
                Controller.DueController.DeleteDue(Program.currentSelectedAccount, dataGridDue.getCurrentDue().Id);
                dataGridDue.UpdateData();
            }
        }
    }
}
