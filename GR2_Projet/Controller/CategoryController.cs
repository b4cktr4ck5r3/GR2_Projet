using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR2_Projet.Controller
{
    /// <summary>
    /// Controller du modèle catégorie.
    /// </summary>
   public static class CategoryController
    {
        /// <summary>
        /// Permet d'ajouter une nouvelle catégorie.
        /// </summary>
        /// <param name="User">Utilisateur connecté.</param>
        /// <param name="Name">Nom de la catégorie.</param>
        public static void AddCategory(Model.User User, string Name)
        {
            User.Categories.Add(new Model.Category(Name));
            Program.ctx.Save();
        }
        
        /// <summary>
        /// Permet d'éditer une catégorie.
        /// </summary>
        /// <param name="User">Utilisateur connecté.</param>
        /// <param name="CategoryId">Id de la catégorie.</param>
        /// <param name="CategoryName">Nouveau nom de la catégorie.</param>
        public static void EditCategory(Model.User User, string CategoryId, string CategoryName)
        {
            User.Categories.Find(category => string.Compare(category.GetId(), CategoryId) == 0).SetName(CategoryName);
            Program.ctx.Save();
        }

        /// <summary>
        /// Permet de supprimer une catégorie.
        /// </summary>
        /// <param name="User">Utilisateur connecté.</param>
        /// <param name="CategoryId">Id de la catégorie.</param>
        public static void DeleteCategory(Model.User User, string CategoryId)
        {
            User.Categories.Remove(User.Categories.Find(category => string.Compare(category.GetId(), CategoryId) == 0));
            Program.ctx.Save();
        }
    }
}
