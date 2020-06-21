using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using GR2_Projet.Model;

namespace GR2_Projet
{
    /// <summary>
    /// Classe permettant de représenter le contexte de l'application et de stocker les différents utilisateur via le processus de sérialisation.
    /// </summary>
    [Serializable()]
    public class AppContext
    {
        private List<Model.User> mUsers;
        public List<Model.User> Users
        {
            get { return mUsers; }
            set { mUsers = value; }
        }

        public AppContext()
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "data.dat"))
            {
                Users = new List<User>();
                Users.Add(AppFixtures.GetFakeUserWithData());
            }
            else
            {
                Read();
            }
        }

        /// <summary>
        /// Permet de lire les données et d'effectuer le processus de désérialisation.
        /// </summary>
        public void Read()
        {
            Stream stream = File.Open("data.dat", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            Users = (List<User>)formatter.Deserialize(stream);
            stream.Close();
        }

        /// <summary>
        /// Permet d'écrire les données et d'effectuer le processus de sérialisation.
        /// </summary>
        public void Save()
        {
            Stream stream = File.Open("data.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, Users);
            stream.Close();
        }

    }
}
