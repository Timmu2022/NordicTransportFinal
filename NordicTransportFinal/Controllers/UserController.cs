using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Data.Repository;
using NordicTransportFinal.Services.IService;
using NordicTransportFinal.Services.Models;
using NordicTransportFinal.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace NordicTransportFinal.Controllers
{
    [Authorize(Roles ="Admin,Staff")]
    public class UserController : Controller
    {
        private NordicTransportContext context;
        IUserService userService;

        public UserController()
        {
            context = new NordicTransportContext();
            userService = new UserService();
        }

        // GET: User
        public ActionResult GetUsers() 
        {
            return View(userService.GetUsers());
        }

        public ActionResult AddUser()
        {
            Helper helper = new Helper();
            ViewBag.countriesList = helper.GetCountryDropDown();
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(UserCountryRole userCountryRole)
        {

                userService.AddUser(userCountryRole);
                return RedirectToAction("GetUsers", "User");
        }

        public ActionResult GetUser(string id)
        {
            return View(userService.GetUser(id));
        }

        public ActionResult GetContracts(int id)
        {
            IList<Contract> contract = userService.GetContracts(id).ToList();
            return View(contract);
        }

    }
}