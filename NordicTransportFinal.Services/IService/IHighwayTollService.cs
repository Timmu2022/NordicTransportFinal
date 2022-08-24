using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Services.IService
{
    public interface IHighwayTollService
    {
        IList<HighwayToll> GetHighwayTolls();
        HighwayToll GetHighwayToll(int id);
        void AddHighwayToll(HighwayTollServiceModel highwayTollServiceModel); 
    }
}
