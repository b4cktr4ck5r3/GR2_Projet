using GR2_Projet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR2_Projet.Controller
{
    /// <summary>
    /// Controller du modèle utilisateur.
    /// </summary>
    public static class UserController
    {
        /// <summary>
        /// Permet d'enregister un utilisateur.
        /// </summary>
        /// <param name="username">Nom d'utilisateur.</param>
        /// <param name="email">Email de l'utilisateur.</param>
        /// <param name="password">Mot de passe de l'utilisateur.</param>
        public static void Register(string username, string email, string password)
        {
            if (!(String.IsNullOrEmpty(username) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password)))
            {
                Model.User newUser = new Model.User(username, email, password);
                Program.ctx.Users.Add(newUser);
                Program.ctx.Save();
            }
        }

        /// <summary>
        /// Permet de connecter un utilisateur.
        /// </summary>
        /// <param name="username">Nom de l'utilisateur.</param>
        /// <param name="password">Mot de passe de l'utilisateur.</param>
        /// <returns></returns>
        public static Model.User Login(string username, string password)
        {
            if (Program.ctx.Users.Contains(
                Program.ctx.Users.Find(u => u.Username == username && u.Password == password)))
                return Program.ctx.Users.Find(u => u.Username == username && u.Password == password);
            else
                return null;
        }
    }
}