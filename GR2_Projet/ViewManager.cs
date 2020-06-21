using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GR2_Projet.View;
using GR2_Projet.View.Account;
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

        private View.ViewUserAccount viewUserAccount;

        private View.Account.ViewAccount viewAccount;
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

        public void ShowViewAccounts()
        {
            viewUserAccount = new ViewUserAccount();
            mainForm.ChangePanel(viewUserAccount);
        }

        public void ShowViewAccount(Model.Account account)
        {
            viewAccount = new ViewAccount(account);
            mainForm.ChangePanel(viewAccount);
        }
        #endregion Views treatments
    }
}
