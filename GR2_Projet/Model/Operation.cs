using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR2_Projet.Model
{
    /// <summary>
    /// Enumération des types d'opérations disponibles.
    /// </summary>
    public enum operationType
    {
        Debit,
        Credit
    }

    /// <summary>
    /// Enumération des types de paiements disponibles.
    /// </summary>
    public enum paymentType
    {
        Card,
        Transfer,
        Cash,
        Cheque
    }

    /// <summary>
    /// Classe représentant le modèle d'une opération bancaire.
    /// </summary>
    class Operation
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
        /// Propriété name.
        /// </summary>
        public string name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Propriété type d'opération.
        /// </summary>
        public operationType operation_Type
        {
            get { return operation_Type; }
            set { operation_Type = value; }
        }

        /// <summary>
        /// Propriété date.
        /// </summary>
        public DateTime date
        {
            get { return date; }
            set { date = value; }
        }

        /// <summary>
        /// Propriété type de paiement.
        /// </summary>
        public paymentType payment_Type
        {
            get { return payment_Type; }
            set { payment_Type = value; }
        }

        /// <summary>
        /// Propriété montant.
        /// </summary>
        public int amount
        {
            get { return amount; }
            set { amount = value; }
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        public Operation() { }
    }
}
