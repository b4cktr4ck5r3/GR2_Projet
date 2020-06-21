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
        /// Permet d'ajouter un compte bancaire.
        /// </summary>
        /// <param name="User">Utilisateur connecté.</param>
        /// <param name="AccountName">Nom du compte.</param>
        /// <param name="AccountBudget">Solde du compte.</param>
        public static void AddAccount(Model.User User, string AccountName, float AccountBudget)
        {
            User.Accounts.Add(new Model.Account(AccountName, AccountBudget));
            Program.ctx.Save();
        }

        /// <summary>
        /// Permet d'éditer un compte bancaire.
        /// </summary>
        /// <param name="User">Utilisateur connecté.</param>
        /// <param name="AccountId">Id du compte a éditer</param>
        /// <param name="AccountNewName">Nouveau nom de compte.</param>
        public static void EditAccount(Model.User User, string AccountId, string AccountNewName)
        {
            User.Accounts.Find(account => string.Compare(account.Id, AccountId) == 0).Name = AccountNewName;
            Program.ctx.Save();
        }

        /// <summary>
        /// Permet de supprimer un compte bancaire.
        /// </summary>
        /// <param name="User">Utilisateur connecté.</param>
        /// <param name="AccountId">Id du compte à supprimer.</param>
        public static void DeleteAccount(Model.User User, string AccountId)
        {
            User.Accounts.Remove(User.Accounts.Find(account => string.Compare(account.Id, AccountId) == 0));
            Program.ctx.Save();
        }
    }
}
