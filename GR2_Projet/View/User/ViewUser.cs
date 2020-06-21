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
    public partial class ViewUser : BaseView
    {
        private User.Component.FormRegisterUserComponent registerUserComponent;
        private User.Component.FormLoginUserComponent loginUserComponent;
        public ViewUser()
        {
            InitializeComponent();
        }

        private void Créer_Click(object sender, EventArgs e)
        {
            ClearComponentRessources(userComponentPanel);
            registerUserComponent = new FormRegisterUserComponent();
            ChangeComponent(userComponentPanel, registerUserComponent);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            ClearComponentRessources(userComponentPanel);
            loginUserComponent = new FormLoginUserComponent();
            ChangeComponent(userComponentPanel, loginUserComponent);
        }
    }
}
