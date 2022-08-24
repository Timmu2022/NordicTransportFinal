using NordicTransportFinal.Services.IService;
using NordicTransportFinal.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NordicTransportFinal.Controllers
{
    [Authorize(Roles = "Admin,Roaduser")]
    public class TransactionsController : Controller
    {
        private ITransactionService transactionService;
        public TransactionsController()
        {
            transactionService = new TransactionService();
        }
        // GET: Transactions
        public ActionResult GetTransactions()
        {
            return View(transactionService.GetTransactions());
        }
    }
}