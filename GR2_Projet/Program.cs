using GR2_Projet.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GR2_Projet
{
    static class Program
    {
        public static AppContext ctx = new AppContext();
        public static User currentLoggedUser = null;
        public static Account currentSelectedAccount = null;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ViewManager.Instance.ShowMainForm();
            Application.Run();
       }

        public static object SearchParent(Control ctrl, string Name)
        {
            while (ctrl.Parent.Name != Name)
                ctrl = ctrl.Parent;

            return ctrl.Parent;
        }
    }
}
