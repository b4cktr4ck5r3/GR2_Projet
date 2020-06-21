using System;
using System.Windows.Forms;
using GR2_Projet.View.User.Component;

namespace GR2_Projet.View.User
{
    /// <summary>
    /// Classe ViewUserAccount. Elle permet de représenter la vue lié au modèle des comptes bancaires.
    /// </summary>
    public partial class ViewUserAccount : BaseView
    {
        private static bool isShowComponentActive;
        private static bool isAddOrEditComponentActive;
        #region Components
        /// <summary>
        /// Composant permettant d'ajouter un compte bancaire.
        /// </summary>
        private Account.Component.FormAddOrEditAccountComponent form;
        /// <summary>
        /// Composant permettant d'afficher les comptes bancaires.
        /// </summary>
        private ShowAccountComponent showComponent;
        #endregion Components

        /// <summary>
        /// Constructeur.
        /// </summary>
        public ViewUserAccount()
        {
            InitializeComponent();

            this.userNameLbl.Text = Program.currentLoggedUser.Username;
            showAccountLogic();

            ChangeReturnState(false);
            EnableButtons(false);
        }

        public void EnableButtons(bool enable)
        {
            this.editBtn.Enabled = enable;
            this.delBtn.Enabled = enable;
        }

        private void ChangeReturnState(bool state)
        {
            returnBtn.Visible = state;
        }

        /// <summary>
        /// Logique d'affichage du composant permettant d'afficher les comptes bancaires.
        /// </summary>
        private void showAccount_Click(object sender, EventArgs e)
        {
            if (!isShowComponentActive)
            {
                showAccountLogic();
                ChangeReturnState(false);
            }
        }

        public void showAccountLogic()
        {
            ClearComponentRessources(adminComponentPanel);
            showComponent = new ShowAccountComponent(Program.currentLoggedUser.Accounts);
            ChangeComponent(adminComponentPanel, showComponent);

            isShowComponentActive = true;
            isAddOrEditComponentActive = false;
        }

        /// <summary>
        /// Logique d'affichage du composant permettant d'ajouter un comptes bancaire.
        /// </summary>
        private void addAccount_Click(object sender, EventArgs e)
        {
            if (!isAddOrEditComponentActive)
            {
                addAccountLogic();
                ChangeReturnState(true);
            }
        }

        private void addAccountLogic()
        {
            ClearComponentRessources(adminComponentPanel);
            form = new Account.Component.FormAddOrEditAccountComponent();
            ChangeComponent(adminComponentPanel, form);

            isAddOrEditComponentActive = true;
            isShowComponentActive = false;
        }



        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!isAddOrEditComponentActive)
            {
                editAccountLogic();
                ChangeReturnState(true);
            }
        }

        private void editAccountLogic()
        {
            if (showComponent.getCurrentAccount() != null)
            {
                Model.Account tempAccount = showComponent.getCurrentAccount();
                ClearComponentRessources(adminComponentPanel);
                form = new Account.Component.FormAddOrEditAccountComponent(tempAccount);
                ChangeComponent(adminComponentPanel, form);

                isAddOrEditComponentActive = true;
                isShowComponentActive = false;
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (showComponent.getCurrentAccount() != null)
            {
                Controller.AccountController.DeleteAccount(Program.currentLoggedUser, showComponent.getCurrentAccount().Id);
                showComponent.UpdateData(Program.currentLoggedUser.Accounts);
                EnableButtons(false);
                showComponent.ResetSelection();
            }
        }

        private void logoutLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            showAccountLogic();
            EnableButtons(false);
            ChangeReturnState(false);
        }
    }
}
