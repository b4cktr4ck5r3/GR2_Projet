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
    [Serializable()]
    public class User
    {
        static int userCount = 0;
        /// <summary>
        /// Propriété id.
        /// </summary>
        private int mId;
        public int Id
        {
            get { return mId; }
            set { mId = value; }
        }

        /// <summary>
        /// Propriété nom d'utilisateur.
        /// </summary>
        private string mUsername;
        public string Username
        {
            get { return mUsername; }
            set { mUsername = value; }
        }

        /// <summary>
        /// Propriété email.
        /// </summary>
        private string mEmail;
        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }

        /// <summary>
        /// Propriété mot de passe.
        /// </summary>
        private string mPassword;
        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        private List<Account> mAccounts;
        public List<Account> Accounts
        {
            get { return mAccounts; }
            set { mAccounts = value; }
        }
        /// <summary>
        /// Constructeur.
        /// </summary>
        public User(string Username, string Email, string Password)
        {
            this.Id = userCount;
            this.Username = Username;
            this.Email = Email;
            this.Password = Password;
            Accounts = new List<Account>();
            userCount++;
        }
    }
}
