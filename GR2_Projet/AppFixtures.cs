using GR2_Projet.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GR2_Projet
{
    /// <summary>
    /// Classe permettant de gérer un jeu de fausses données pour tester l'application.
    /// </summary>
    public static class AppFixtures
    {
        public static User currentLoggedUser;

        public static User GetFakeUserWithData()
        {
            User user = new Model.User("test", "test@test.com", "test");

            user.Categories.Add(new Category("Transport"));
            user.Categories.Add(new Category("Ecole"));
            user.Categories.Add(new Category("Alimentation"));
            user.Categories.Add(new Category("Maison"));
            user.Categories.Add(new Category("Vetement"));

            for (int i = 0; i < 5; i++)
            {
                Model.Account account = new Model.Account($"Compte{i}", 1000);
                Due fakeDue = new Due($"Echeance{i}", (i % 2 == 0) ? operationType.Credit : operationType.Debit, i, paymentType.Cash, i*2000, user.Categories.ElementAt(i%5));

                for (int j = 0; j < 30; j++)
                {
                    Operation fakeOperation = new Operation($"Operation{j}", (j % 2 == 0) ? operationType.Credit : operationType.Debit, DateTime.Now, paymentType.Cash, 3000, user.Categories.ElementAt(i % 5));
                    account.Operations.Add(fakeOperation);
                }
                account.Dues.Add(fakeDue);
                user.Accounts.Add(account);
            }
            
            return user;
        }
        public static void CreateFakeUser()
        {
            Model.User user = new Model.User("Utilisateur", "utilisateur@utilisateur.fr", "mdp");
            Program.currentLoggedUser = user;
        }
        public static void CreateFakeAccount()
        {
            for(int i = 0; i < 5; i++)
            {
                Model.Account account = new Model.Account($"Compte{i}", 1000);
                Program.currentLoggedUser.Accounts.Add(account);
            }
        }
    }
}
