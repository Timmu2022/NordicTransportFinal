using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Services.IService;
using NordicTransportFinal.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NordicTransportFinal.Controllers
{
    public class Helper
    {
        private ICountryService countryService;
        private ILocationService locationService;
        private IUserService userService;
        public Helper()
        {

            countryService = new CountryService();
            locationService = new LocationService();
            userService = new UserService();
        }

        public List<SelectListItem> GetCountryDropDown() 
        {
            List<SelectListItem> countriesList = new List<SelectListItem>();
            IList<Country> countries = countryService.GetCountries(); 

            foreach (var item in countries)
            {
                countriesList.Add
                    (
                        new SelectListItem()
                        {
                            Text = item.CountryName,
                            Value = item.CountryID.ToString(),
                            Selected = (item.CountryName == (countries[0].CountryName) ? true : false)
                        }
                    );
            }
            return countriesList;
        }

        public List<SelectListItem> GetLocationDropDown() 
        {
            List<SelectListItem> locationsList = new List<SelectListItem>(); 
            IList<Location> locations = locationService.GetLocations();

            foreach (var item in locations)
            {
                locationsList.Add
                    (
                        new SelectListItem()
                        {
                            Text = item.LocationName,
                            Value = item.LocationID.ToString(),
                            Selected = (item.LocationName == (locations[0].LocationName) ? true : false)
                        }
                    );
            }
            return locationsList;
        }

        public List<SelectListItem> GetUserDropDown()
        {
            List<SelectListItem> usersList = new List<SelectListItem>();
            IList<User> users = userService.GetUsers();

            foreach (var item in users)
            {
                usersList.Add
                    (
                        new SelectListItem()
                        {
                            Text = "Forename: "+item.UForename+", Surname: "+item.USurname+", Email: "+item.UEmail,
                            Value = item.UserID.ToString(),
                            Selected = (item.UEmail == (users[0].UEmail) ? true : false)
                        }
                    );
            }
            return usersList;
        }
    }
}