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
        public static void AddUser(string username, string email, string password)
        {
            Model.User newUser = new Model.User(username, email, password);
            Program.ctx.Users.Add(newUser);
            Program.ctx.Save();
        }
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