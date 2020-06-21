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
            }
            else
            {
                Read();
            }
        }

        public void Read()
        {
            Stream stream = File.Open("data.dat", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            Users = (List<User>)formatter.Deserialize(stream);
            stream.Close();
        }

        public void Save()
        {
            Stream stream = File.Open("data.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, Users);
            stream.Close();
        }

    }
}
