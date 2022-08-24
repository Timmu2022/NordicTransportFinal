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
    public class LocationController : Controller
    {
        ILocationService locationService; 
        public LocationController()
        {
            locationService = new LocationService();
        }
        // GET: Location
        public ActionResult GetLocations() 
        {
            return View(locationService.GetLocations()); 
        }

        public ActionResult AddLocation() 
        {           
            return View();
        }

        [HttpPost]
        public ActionResult AddLocation(LocationServiceModel locationServiceModel)  
        {

            locationService.AddLocation(locationServiceModel);
            return RedirectToAction("GetLocations", "Location");
        }
    }
}