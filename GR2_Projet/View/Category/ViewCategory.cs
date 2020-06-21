using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GR2_Projet.View.Category
{
    /// <summary>
    /// Composant : Vue permettant d'afficher les informations liées aux catégories.
    /// </summary>
    public partial class ViewCategory : UserControl
    {
        public ViewCategory()
        {
            InitializeComponent();
            InsertData();
        }

        public void UpdateData()
        {
            dataGridCategory.Rows.Clear();
            InsertData();
        }

        public void InsertData()
        {
            foreach (Model.Category category in Program.currentLoggedUser.Categories) dataGridCategory.Rows.Add(category.GetName());
        }

        private void btRetour_Click(object sender, EventArgs e)
        {
            ViewManager.Instance.ShowViewAccount();
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nameTxtBox.Text))
            {
                Controller.CategoryController.AddCategory(Program.currentLoggedUser, nameTxtBox.Text);
                UpdateData();
                nameTxtBox.Clear();
            }
        }
    }
}
