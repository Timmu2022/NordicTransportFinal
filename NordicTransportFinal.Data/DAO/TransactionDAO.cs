using NordicTransportFinal.Data.IDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Data.Repository;

namespace NordicTransportFinal.Data.DAO
{
    public class TransactionDAO : ITransactionDAO
    {
        private NordicTransportContext context;

        public TransactionDAO()
        {
            context = new NordicTransportContext();
        }
        public IList<Transaction> GetTransactions(NordicTransportContext context)
        {
            return context.Transactions.ToList();
        }
    }
}
