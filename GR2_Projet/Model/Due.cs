using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR2_Projet.Model
{
    /// <summary>
    /// Classe représentant le modèle d'échéance mensuelle.
    /// </summary>
    class Due
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
        /// Propriété nom.
        /// </summary>
        public string name
        {
            get { return name; }
            set { name = value; }
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
        /// Constructeur.
        /// </summary>
        public Due(){}
    }
}
