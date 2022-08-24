using NordicTransportFinal.Data.DAO;
using NordicTransportFinal.Data.IDAO;
using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Data.Repository;
using NordicTransportFinal.Services.IService;
using NordicTransportFinal.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Services.Service
{
    public class LocationService : ILocationService
    {
        private ILocationDAO locationDAO;
        public LocationService()
        {
            locationDAO = new LocationDAO();
        }

        public void AddLocation(LocationServiceModel locationServiceModel)
        {
            Location newLocation = new Location() //Create new Location Object 
            {
                LocationName = locationServiceModel.LocationName,
                LocationAddress = locationServiceModel.LocationAddress
            };
            using (var context = new NordicTransportContext())
            {

                //Context is created
                locationDAO.AddLocation(newLocation, context); // Add Location              
                context.SaveChanges();
            }
        }

        public Location GetLocation(int id)
        {
            using (var context = new NordicTransportContext())
            {
                return locationDAO.GetLocation(id, context);
            }
        }

        public IList<Location> GetLocations()
        {
            using (var context = new NordicTransportContext())
            {
                return locationDAO.GetLocations(context);
            }
        }
    }
}
