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
    public class LocationDAO : ILocationDAO
    {
        private NordicTransportContext context;

        public LocationDAO()
        {
            context = new NordicTransportContext();
        }

        public void AddHighwayTollToCollection(HighwayToll highwayToll, Location location, NordicTransportContext context)
        {
            context.Locations.Find(location.LocationID).HighwayTolls.Add(highwayToll);
        }

        public void AddLocation(Location location, NordicTransportContext context)
        {
            context.Locations.Include(g => g.HighwayTolls).ToList();
            context.Locations.Add(location);
        }

        public Location GetLocation(int id, NordicTransportContext context)
        {
            context.Locations.Include(g => g.HighwayTolls).ToList();
            return context.Locations.Find(id);
        }

        public IList<Location> GetLocations(NordicTransportContext context)
        {
            return context.Locations.ToList(); 
        }
    }
}
