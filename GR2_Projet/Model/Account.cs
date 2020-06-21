using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR2_Projet.Model
{
    /// <summary>
    /// Classe représentant le modèle d'un compte bancaire.
    /// </summary>
    [Serializable()]
    public class Account
    {
        /// <summary>
        /// GETTER; SETTER; Integer id
        /// </summary>
        private string mId;
        public string Id { get { return mId; } set { mId = value; } }
        /// <summary>
        /// GETTER; SETTER; String name
        /// </summary>
        private string mName;
        public string Name { get { return mName; } set { mName = value; } }
        /// <summary>
        /// GETTER;SETTER; Integer budget
        /// </summary>
        private float mBudget;
        public float Budget { get { return mBudget; } set { mBudget = value; } }

        private List<Operation> mOperations;
        public List<Operation> Operations
        {
            get { return mOperations; }
            set { mOperations = value; }
        }

        private List<Due> mDues;
        public List<Due> Dues
        {
            get { return mDues; }
            set { mDues = value; }
        }

        /// <summary>
        /// Construct
        /// </summary>
        public Account(string Name, float Budget)
        {
            this.Name = Name;
            this.Budget = Budget;
            Dues = new List<Due>();
            Operations = new List<Operation>();
            this.Id = Guid.NewGuid().ToString();
        }

        public float GetSolde()
        {
            float solde = Budget;
            Operations.ForEach(operation =>
            {
                if (operation.OperationType == operationType.Credit) solde += operation.Amount;
                else if (operation.OperationType == operationType.Debit) solde -= operation.Amount;
            });
            return solde;
        }
    }
}
