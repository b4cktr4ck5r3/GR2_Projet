using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR2_Projet.Model
{
    /// <summary>
    /// Classe représentant le modèle utilisateur.
    /// </summary>
    class User
    {
        /// <summary>
        /// Propriété id.
        /// </summary>
        public int id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Propriété nom d'utilisateur.
        /// </summary>
        public string username
        {
            get { return username; }
            set { username = value; }
        }

        /// <summary>
        /// Propriété email.
        /// </summary>
        public string email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Propriété mot de passe.
        /// </summary>
        public string password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        public User(string username)
        {
            this.username = username;
        }
    }
}
