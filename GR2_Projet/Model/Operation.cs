﻿using System;
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
    [Serializable()]
    public class Operation
    {
        /// <summary>
        /// Propriété id.
        /// </summary>
        private string mId;
        public string Id
        {
            get { return mId; } 
            set { mId = value; }
        }

        /// <summary>
        /// Propriété name.
        /// </summary>
        private string mName;
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        /// <summary>
        /// Propriété type d'opération.
        /// </summary>
        private operationType mOperationType;
        public operationType OperationType
        {
            get { return mOperationType; }
            set { mOperationType = value; }
        }

        /// <summary>
        /// Propriété date.
        /// </summary>
        private DateTime mDate;
        public DateTime Date
        {
            get { return mDate; }
            set { mDate = value; }
        }

        /// <summary>
        /// Propriété type de paiement.
        /// </summary>
        private paymentType mPaymentType;
        public paymentType PaymentType
        {
            get { return mPaymentType; }
            set { mPaymentType = value; }
        }

        /// <summary>
        /// Propriété montant.
        /// </summary>
        private float mAmount;
        public float Amount
        {
            get { return mAmount; }
            set { mAmount = value; }
        }

        /// <summary>
        /// Liste des catégories.
        /// </summary>
        private Category mCategory;
        public Category category
        {
            get { return mCategory; }
            set { mCategory = value; }
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        public Operation(string Name, operationType OperationType, DateTime Date, paymentType PaymentType, float Amount, Category category)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Name = Name;
            this.OperationType = OperationType;
            this.Date = Date;
            this.PaymentType = PaymentType;
            this.Amount = Amount;
            this.category = category;
        }
    }
}
