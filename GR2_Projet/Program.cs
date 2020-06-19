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
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ViewManager.Instance.ShowMainForm();

            User test = new User("TestUser");
            Stream stream = File.Open("data.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, test);
            stream.Close();

            stream = File.Open("data.dat", FileMode.Open);
            formatter = new BinaryFormatter();

            test = (User)formatter.Deserialize(stream);
            stream.Close();

            System.Diagnostics.Debug.WriteLine("---------------------------");
            System.Diagnostics.Debug.WriteLine(test.username);
            System.Diagnostics.Debug.WriteLine("---------------------------");

            Application.Run();
       }
    }
}
