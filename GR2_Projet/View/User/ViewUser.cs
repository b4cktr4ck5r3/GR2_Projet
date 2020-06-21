using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GR2_Projet.View.User.Component;

namespace GR2_Projet.View.User
{
    /// <summary>
    /// Composant : vue permettant la connexion/l'inscription d'un utilisateur.
    /// </summary>
    public partial class ViewUser : BaseView
    {
        private User.Component.FormRegisterUserComponent registerUserComponent;
        private User.Component.FormLoginUserComponent loginUserComponent;
        public ViewUser()
        {
            InitializeComponent();
            ShowLoginFormLogic();

            this.loginBtn.Visible = false;
            this.registerBtn.Visible = true;
        }

        public void ShowLoginFormLogic()
        {
            ClearComponentRessources(userComponentPanel);
            loginUserComponent = new FormLoginUserComponent();
            ChangeComponent(userComponentPanel, loginUserComponent);
        }

        public void ShowRegisterFormLogic()
        {
            ClearComponentRessources(userComponentPanel);
            registerUserComponent = new FormRegisterUserComponent();
            ChangeComponent(userComponentPanel, registerUserComponent);
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            ShowRegisterFormLogic();
            this.loginBtn.Visible = true;
            this.registerBtn.Visible = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            ShowLoginFormLogic();
            this.registerBtn.Visible = true;
            this.loginBtn.Visible = false;
        }
    }
}
