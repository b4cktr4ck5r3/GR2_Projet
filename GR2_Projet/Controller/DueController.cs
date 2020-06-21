using GR2_Projet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR2_Projet.Controller
{
    /// <summary>
    /// Controller du modèle d'échéance.
    /// </summary>
    public static class DueController
    {
        /// <summary>
        /// Permet d'ajouter une nouvelle échéance.
        /// </summary>
        /// <param name="Account">Compte bancaire sur laquelle l'échéance est active.</param>
        /// <param name="Name">Nom de l'échéance.</param>
        /// <param name="opT">Type d'opération.</param>
        /// <param name="Day">Jours de récurrence.</param>
        /// <param name="pyT">Type de paiement.</param>
        /// <param name="Amount">Montant de l'échéance.</param>
        /// <param name="category">Catégorie</param>
        public static void AddDue(Model.Account Account, string Name, operationType opT, int Day, paymentType pyT, float Amount, Category category)
        {
            Account.Dues.Add(new Due(Name, opT, Day, pyT, Amount, category));
            Program.ctx.Save();
        }

        /// <summary>
        /// Permet d'éditer une échéance.
        /// </summary>
        /// <param name="due">Echéance à éditer.</param>
        /// <param name="Name">Nom de l'échéance.</param>
        /// <param name="Amount">Montant de l'échéance.</param>
        /// <param name="PaymentType">Type de paiement.</param>
        /// <param name="OperationType">Type d'opération.</param>
        /// <param name="Day">Jours de récurrence.</param>
        /// <param name="category">Catégorie.</param>
        public static void EditDue(Model.Due due, string Name, float Amount, paymentType PaymentType,
            operationType OperationType, int Day, Category category)
        {
            due.Name = Name;
            due.Amount = Amount;
            due.PaymentType = PaymentType;
            due.OperationType = OperationType;
            due.Day = Day;
            due.category = category;

            Program.ctx.Save();
        }

        /// <summary>
        /// Permet de supprimer une échéance.
        /// </summary>
        /// <param name="Account">Compte sur lequel l'échéance est active.</param>
        /// <param name="DueId">Id de l'échéance.</param>
        public static void DeleteDue(Model.Account Account, string DueId)
        {
            Account.Dues.Remove(Account.Dues.Find(due => string.Compare(due.Id, DueId) == 0));
            Program.ctx.Save();
        }
    }
}
