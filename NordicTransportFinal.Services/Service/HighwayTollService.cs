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
    public class HighwayTollService : IHighwayTollService
    {
        private IHighwayTollDAO highwayTollDAO;
        private ILocationDAO locationDAO;
        public HighwayTollService()
        {
            highwayTollDAO = new HighwayTollDAO();
            locationDAO = new LocationDAO();
        }

        public void AddHighwayToll(HighwayTollServiceModel highwayTollServiceModel)
        {
            HighwayToll newHighwayToll = new HighwayToll() //Create new User Object
            {
                TollName = highwayTollServiceModel.TollName,
                TollPrice = highwayTollServiceModel.TollPrice
            };
            using (var context = new NordicTransportContext())
            {
                //Context is created 
                highwayTollDAO.AddHighwayToll(newHighwayToll, context); // Add HighwayToll
                Location location = locationDAO.GetLocation(highwayTollServiceModel.Location, context); //Create Location Object 
                locationDAO.AddHighwayTollToCollection(newHighwayToll, location, context); //Add HighwayToll to Collection of Location
                context.SaveChanges();
            }
        }

        public HighwayToll GetHighwayToll(int id)
        {
            using (var context = new NordicTransportContext())
            {
                return highwayTollDAO.GetHighwayToll(id, context);
            }
        }

        public IList<HighwayToll> GetHighwayTolls()
        {
            using (var context = new NordicTransportContext())
            {
                return highwayTollDAO.GetHighwayTolls(context);
            }
        }
    }
}
