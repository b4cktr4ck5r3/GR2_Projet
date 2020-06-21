using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GR2_Projet.View
{
    /// <summary>
    /// Classe ViewAccount. Elle permet de représenter la vue lié au modèle des comptes bancaires.
    /// </summary>
    public partial class ViewAccount : BaseView
    {
        #region Components
        /// <summary>
        /// Composant permettant d'ajouter un compte bancaire.
        /// </summary>
        private Account.Component.AddAccountComponent addComponent;
        /// <summary>
        /// Composant permettant d'afficher les comptes bancaires.
        /// </summary>
        private Account.Component.ShowAccountComponent showComponent;
        #endregion Components

        /// <summary>
        /// Constructeur.
        /// </summary>
        public ViewAccount()
        {
            InitializeComponent();

            this.userNameLbl.Text = AppFixtures.currentLoggedUser.Username;
            this.userMailLbl.Text = AppFixtures.currentLoggedUser.Email;

            ShowButtons(false);
            EnableButtons(false);
        }

        public void ShowButtons(bool isVisible)
        {
            this.delBtn.Visible = isVisible;
            this.editBtn.Visible = isVisible;
        }

        public void EnableButtons(bool isEnabled)
        {
            this.delBtn.Enabled = isEnabled;
            this.editBtn.Enabled = isEnabled;
        }

        /// <summary>
        /// Logique d'affichage du composant permettant d'afficher les comptes bancaires.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAccount_Click(object sender, EventArgs e)
        {
            ClearComponentRessources(accountPanel);
            showComponent = new Account.Component.ShowAccountComponent(AppFixtures.currentLoggedUser.Accounts);
            ChangeComponent(accountPanel, showComponent);
            ShowButtons(true);
        }

        /// <summary>
        /// Logique d'affichage du composant permettant d'ajouter un comptes bancaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addAccount_Click(object sender, EventArgs e)
        {
            ClearComponentRessources(accountPanel);
            addComponent = new Account.Component.AddAccountComponent();
            ChangeComponent(accountPanel, addComponent);
            ShowButtons(false);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(showComponent.getCurrentAccount().Name);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            Controller.AccountController.DeleteAccount(AppFixtures.currentLoggedUser, showComponent.getCurrentAccount().Id);
            showComponent.UpdateData(AppFixtures.currentLoggedUser.Accounts);
        }
    }
}
