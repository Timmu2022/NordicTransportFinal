using NordicTransportFinal.Data.DAO;
using NordicTransportFinal.Data.IDAO;
using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Data.Repository;
using NordicTransportFinal.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Services.Service
{
    public class TransactionService : ITransactionService
    {
        private ITransactionDAO transactionDAO;

        public TransactionService()
        {
            transactionDAO = new TransactionDAO();
  
        }

        public IList<Transaction> GetTransactions()
        {
            using (var context = new NordicTransportContext())
            {
                return transactionDAO.GetTransactions(context);
            }
        }
    }
}
