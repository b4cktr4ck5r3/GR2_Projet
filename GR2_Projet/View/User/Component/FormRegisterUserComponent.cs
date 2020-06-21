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
    public partial class FormRegisterUserComponent : UserControl
    {
        public FormRegisterUserComponent()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Controller.UserController.Register(this.usernameTxtBox.Text, this.mailTxtBox.Text, this.passwordTxtBox.Text);
            Program.ctx.Save();
        }
    }
}
