using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR2_Projet.Model
{
    /// <summary>
    /// Classe représentant le modèle d'une catégorie (utilisé pour le tri d'opérations).
    /// </summary>
    [Serializable()]
    class Category
    {
        private int id;
        private string name;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="id">Id de la catégorie.</param>
        /// <param name="name">Nom de la catégorie.</param>
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        /// <summary>
        /// Setter de la propriété id.
        /// </summary>
        /// <param name="id">id de la catégorie.</param>
        public void SetId(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// Setter de la propriété nom.
        /// </summary>
        /// <param name="name">Nom de la catégorie.</param>
        public void SetName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Getter de la propriété id.
        /// </summary>
        /// <returns>Id de la catégorie.</returns>
        public int GetId()
        {
            return this.id;
        }

        /// <summary>
        /// Getter de la propriété nom.
        /// </summary>
        /// <returns>Nom de la catégorie.</returns>
        public string GetName()
        {
            return this.name;
        }
    }
}
