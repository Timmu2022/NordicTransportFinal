using NordicTransportFinal.Data.Models.Domain;
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
    public class ContractController : Controller
    {
        private IContractService contractService;

        public ContractController()
        {
            contractService = new ContractService();
        }
        // GET: Contract
        public ActionResult AddContract() 
        {
            Helper helper = new Helper();
            ViewBag.usersList = helper.GetUserDropDown();
            return View();
        }

        [HttpPost]
        public ActionResult AddContract(ContractUserModel contractUserModel)  
        {

            contractService.AddContract(contractUserModel);
            return RedirectToAction("GetUsers", "User");
        }

        public ActionResult GetCustVehicle(int id)  
        {
            IList<CustVehicle> custVehicle = contractService.GetCustVehicle(id).ToList();
            return View(custVehicle); 
        }

        public ActionResult GetContract(int id) 
        {
            return View(contractService.GetContract(id));
        }

        public ActionResult GetContracts()
        {
            return View(contractService.GetContracts());
        }
    }
}