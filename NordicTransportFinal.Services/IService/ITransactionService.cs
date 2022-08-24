using NordicTransportFinal.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Services.IService
{
    public interface ITransactionService
    {
        IList<Transaction> GetTransactions(); 
    }
}
