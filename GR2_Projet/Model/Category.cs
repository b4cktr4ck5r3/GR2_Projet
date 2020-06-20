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
        private string id;
        private string name;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="id">Id de la catégorie.</param>
        /// <param name="name">Nom de la catégorie.</param>
        public Category(string name)
        {
            this.id = Guid.NewGuid().ToString();
            this.name = name;
        }

        /// <summary>
        /// Setter de la propriété id.
        /// </summary>
        /// <param name="id">id de la catégorie.</param>
        public void SetId(string id)
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
        public string GetId()
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
