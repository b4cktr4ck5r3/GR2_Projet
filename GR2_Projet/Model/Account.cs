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
    class Account
    {
        /// <summary>
        /// GETTER; SETTER; Integer id
        /// </summary>
        private int id { get { return id; } set { id = value; } }
        /// <summary>
        /// GETTER; SETTER; String name
        /// </summary>
        private string name { get { return name; } set { name = value; } }
        /// <summary>
        /// GETTER;SETTER; Integer budget
        /// </summary>
        private int budget { get { return budget; } set { budget = value; } }

        /// <summary>
        /// Construct
        /// </summary>
        public Account() { }
    }
}
