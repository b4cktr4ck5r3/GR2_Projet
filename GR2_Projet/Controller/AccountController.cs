using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR2_Projet.Controller
{
    /// <summary>
    /// Controller du modèle compte.
    /// </summary>
    public static class AccountController
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// public AccountController() { }
        public static void AddAccount(Model.User User, string AccountName, float AccountBudget)
        {
            Model.Account newAccount = new Model.Account(AccountName, AccountBudget);
            User.Accounts.Add(newAccount);
            AppFixtures.Save();
        }

        public static void DeleteAccount(Model.User User, string AccountId)
        {
            User.Accounts.Remove(User.Accounts.Find(account => string.Compare(account.Id, AccountId) == 0));
        }
    }
}
