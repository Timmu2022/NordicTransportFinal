using NordicTransportFinal.Data.Repository;
using NordicTransportFinal.Models;
using NordicTransportFinal.Services.IService;
using NordicTransportFinal.Services.Models;
using NordicTransportFinal.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NordicTransportFinal.Controllers
{
    [Authorize(Roles = "Admin,Staff")]
    public class HighwayTollController : Controller
    {
        private IHighwayTollService highwayTollService;
        private ITransactionService transactionService;
        public HighwayTollController()
        {
            highwayTollService = new HighwayTollService();
            transactionService = new TransactionService();
        }


        public ActionResult GetHighwayTolls() 
        {
            return View(highwayTollService.GetHighwayTolls()); 
        }

        // GET: HighwayToll
        public ActionResult AddHighwayToll() 
        {
            Helper helper = new Helper();
            ViewBag.locationsList = helper.GetLocationDropDown();
            return View();
        }

        [HttpPost]
        public ActionResult AddHighwayToll(HighwayTollServiceModel highwayTollServiceModel) 
        {

            highwayTollService.AddHighwayToll(highwayTollServiceModel);
            return RedirectToAction("GetHighwayTolls", "HighwayToll");
        }

        public ActionResult GetTransactions()
        {
            return View(transactionService.GetTransactions());
        }

  
    }
}