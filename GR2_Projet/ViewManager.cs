using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// <summary>
        /// Permet de créer et d'afficher le formulaire principale de l'application.
        /// </summary>
        public void ShowMainForm()
        {
            mainForm = new MainForm();
            mainForm.Show();
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
        #endregion Views treatments
    }
}
