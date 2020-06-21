using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GR2_Projet.Model;

namespace GR2_Projet.Controller
{
    /// <summary>
    /// Controller du modèle opération.
    /// </summary>
    public static class OperationController
    {
        public static void AddOperation()
        {

        }

        public static void EditOperation(Model.Operation operation, string Name, float Amount, paymentType PaymentType,
            operationType OperationType, DateTime Date, Category category)
        {
            operation.Name = Name;
            operation.Amount = Amount;
            operation.PaymentType = PaymentType;
            operation.OperationType = OperationType;
            operation.Date = Date;
            operation.category = category;

            Program.ctx.Save();
        }
    }
}
