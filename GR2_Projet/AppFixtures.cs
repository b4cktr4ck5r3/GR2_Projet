using GR2_Projet.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GR2_Projet
{
    public static class AppFixtures
    {
        public static User currentLoggedUser;
        public static void CreateFakeUser()
        {
            Model.User user = new Model.User("Utilisateur", "utilisateur@utilisateur.fr", "mdp");
            currentLoggedUser = user;
        }
        public static void CreateFakeAccount()
        {
            for(int i = 0; i < 5; i++)
            {
                Model.Account account = new Model.Account($"Compte{i}", 1000);
                currentLoggedUser.Accounts.Add(account);
            }
        }

        public static void Save()
        {
            Stream stream = File.Open("data.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, currentLoggedUser);
            stream.Close();
        }

        public static void Read()
        {
            Stream stream = File.Open("data.dat", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            var test = (User)formatter.Deserialize(stream);
            stream.Close();
        }
    }
}
