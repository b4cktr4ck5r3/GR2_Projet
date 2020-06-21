using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GR2_Projet.Model;

namespace GR2_Projet.Controller
{
    /// <summary>
    /// Controller du modèle opération.
    /// </summary>
    public static class OperationController
    {
        /// <summary>
        /// Permet d'ajouter une nouvelle opération.
        /// </summary>
        /// <param name="Account">Compte concerné par l'operation.</param>
        /// <param name="Name">Nom de l'opération.</param>
        /// <param name="opT">Type d'opération.</param>
        /// <param name="date">Date de l'opération.</param>
        /// <param name="paT">Type de paiement.</param>
        /// <param name="Amount">Montant de l'opération.</param>
        /// <param name="cat">Catégorie de l'opération.</param>
        public static void AddOperation(Model.Account Account, string Name, operationType opT, DateTime date, paymentType paT, float Amount, Category cat)
        {
            Account.Operations.Add(new Operation(Name, opT, date, paT, Amount, cat));
            Program.ctx.Save();
        }

        /// <summary>
        /// Permet d'éditer une nouvelle opération.
        /// </summary>
        /// <param name="operation">Opération concernée.</param>
        /// <param name="Name">Nom de l'opération.</param>
        /// <param name="Amount">Montant de l'opération.</param>
        /// <param name="PaymentType">Type de paiement.</param>
        /// <param name="OperationType">Type d'opération.</param>
        /// <param name="Date">Date de l'opération.</param>
        /// <param name="category">Catégorie de l'opération.</param>
        public static void EditOperation(Model.Operation operation, string Name, float Amount, paymentType PaymentType,
            operationType OperationType, DateTime Date, Category category)
        {
            operation.Name = Name;
            operation.Amount = Amount;
            operation.PaymentType = PaymentType;
            operation.OperationType = OperationType;
            operation.Date = Date;
            operation.category = category;

            Program.ctx.Save();
        }

        /// <summary>
        /// Permet de supprimer une opération.
        /// </summary>
        /// <param name="Account">Compte qui contient l'opération.</param>
        /// <param name="OperationId">Id de l'opération.</param>
        public static void DeleteOperation(Model.Account Account, string OperationId)
        {
            Account.Operations.Remove(Account.Operations.Find(operation =>
                string.Compare(operation.Id, OperationId) == 0));
            Program.ctx.Save();
        }
    }
}
