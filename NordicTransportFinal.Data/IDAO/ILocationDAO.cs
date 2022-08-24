using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Data.IDAO
{
    public interface ILocationDAO
    {
        IList<Location> GetLocations(NordicTransportContext context); 
        Location GetLocation(int id, NordicTransportContext context);
        void AddLocation(Location location, NordicTransportContext context);
        void AddHighwayTollToCollection(HighwayToll highwayToll, Location location, NordicTransportContext context); 
    }
}
