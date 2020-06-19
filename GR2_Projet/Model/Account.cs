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
    class Account
    {
        /// <summary>
        /// GETTER; SETTER; Integer id
        /// </summary>
        private int mId;
        public int Id { get { return mId; } set { mId = value; } }
        /// <summary>
        /// GETTER; SETTER; String name
        /// </summary>
        private string mName;
        public string name { get { return mName; } set { mName = value; } }
        /// <summary>
        /// GETTER;SETTER; Integer budget
        /// </summary>
        private int mBudget;
        public int Budget { get { return mBudget; } set { mBudget = value; } }

        /// <summary>
        /// Construct
        /// </summary>
        public Account() { }
    }
}
