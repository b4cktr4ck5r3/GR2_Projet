using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR2_Projet.Model
{
    class User
    {
        public int id
        {
            get { return id; }
            set { id = value; }
        }
        public string username
        {
            get { return username; }
            set { username = value; }
        }
        public string email
        {
            get { return email; }
            set { email = value; }
        }
        public string password
        {
            get { return password; }
            set { password = value; }
        }

        public User()
        {
            
        }
    }
}
