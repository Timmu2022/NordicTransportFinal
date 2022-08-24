using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Data.IDAO
{
    public interface IHighwayTollDAO
    {
        IList<HighwayToll> GetHighwayTolls(NordicTransportContext context); 
        HighwayToll GetHighwayToll(int id, NordicTransportContext context);
        void AddHighwayToll(HighwayToll highwayToll, NordicTransportContext context);  
    }
}
