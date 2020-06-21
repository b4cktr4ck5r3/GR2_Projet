using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GR2_Projet.View.User.Component
{
    public partial class FormLoginUserComponent : UserControl
    {
        public FormLoginUserComponent()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (Controller.UserController.Login(this.usernameTxtBox.Text, this.passwordTxtBox.Text) != null)
            {
                AppFixtures.currentLoggedUser =
                    Controller.UserController.Login(this.usernameTxtBox.Text, this.passwordTxtBox.Text);
                ViewManager.Instance.ShowViewUserAccounts();
            }
            else
                MessageBox.Show("Mauvais username/mdp");
        }
    }
}
