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

        }
    }
}
