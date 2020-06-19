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
    [Serializable()]
    class Due
    {
        /// <summary>
        /// Propriété id.
        /// </summary>
        private int mId;
        public int Id
        {
            get { return mId; }
            set { mId = value; }
        }

        /// <summary>
        /// Propriété nom.
        /// </summary>
        private string mName;
        public string Name
        {
            get { return mName; }
            set { mName = value; }
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
        /// Constructeur.
        /// </summary>
        public Due(){}
    }
}
