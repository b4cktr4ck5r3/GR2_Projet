﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GR2_Projet.View;
using GR2_Projet.View.Account;
using GR2_Projet.View.Category;
using GR2_Projet.View.Due;
using GR2_Projet.View.Operation;
using GR2_Projet.View.User;

namespace GR2_Projet
{
    /// <summary>
    /// Permet de gérer les différentes vues de l'application.
    /// Classe Singleton (une seule instance).
    /// </summary>
    public sealed class ViewManager
    {
        /// <summary>
        /// Instance de la classe (Design Pattern Singleton).
        /// </summary>
        public static readonly ViewManager Instance = new ViewManager();

        #region Views declaration
        /// <summary>
        /// Vue principale de l'application.
        /// </summary>
        private MainForm mainForm;

        private View.User.ViewUser viewUser;

        private ViewUserAccount viewUserAccount;

        private View.Account.ViewAccount viewAccount;

        private View.Operation.ViewOperation viewOperation;

        private View.Due.ViewDue viewDue;

        private View.Category.ViewCategory viewCategory;

        private View.Due.ViewDue viewDues;
        #endregion Views declaration

        /// <summary>
        /// Constructeur static de la classe (pour la création de l'objet "Instance").
        /// </summary>
        static ViewManager(){}

        /// <summary>
        /// Constructeur privée de classe.
        /// </summary>
        private ViewManager(){}

        #region Views treatments
        public void ChangePanel(UserControl tab)
        {
            mainForm.ChangePanel(tab);
        }

        public void ClearPanel()
        {
            mainForm.ClearPanel();
        }

        public void ClearViewRessources()
        {
            mainForm.ClearPanelRessources();
        }

        /// <summary>
        /// Permet de créer et d'afficher le formulaire principale de l'application.
        /// </summary>
        public void ShowMainForm()
        {
            mainForm = new MainForm();
            mainForm.Show();

            viewUser = new ViewUser();
            mainForm.ChangePanel(viewUser);
        }

        /// <summary>
        /// Permet de détruire et de fermer le formulaire principale de l'application.
        /// </summary>
        public void CloseMainForm()
        {
            if (mainForm != null)
                mainForm.Close();
            else
                throw new Exception("Le formulaire principale n'existe pas.");
        }

        public void ShowViewUserAccounts()
        {
            viewUserAccount = new ViewUserAccount();
            mainForm.ChangePanel(viewUserAccount);
        }

        public void ShowViewAccount()
        {
            viewAccount = new ViewAccount();
            mainForm.ChangePanel(viewAccount);
        }

        public void ShowViewOperation()
        {
            viewOperation = new ViewOperation();
            mainForm.ChangePanel(viewOperation);
        }

        public void ShowViewDues()
        {
            viewDues = new ViewDue();
            mainForm.ChangePanel(viewDues);
        }

        public void ShowViewCategory()
        {
            viewCategory = new ViewCategory();
            mainForm.ChangePanel(viewCategory);
        }
        #endregion Views treatments
    }
}
