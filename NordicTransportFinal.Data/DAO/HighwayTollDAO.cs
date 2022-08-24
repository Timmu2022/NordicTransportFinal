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
    public class HighwayTollDAO : IHighwayTollDAO
    {
        private NordicTransportContext context;
        public HighwayTollDAO()
        {
            context = new NordicTransportContext();
        }
        public void AddHighwayToll(HighwayToll highwayToll, NordicTransportContext context)
        {
            context.HighwayTolls.Include(g => g.Transactions).ToList();
            context.HighwayTolls.Add(highwayToll);
        }

        public HighwayToll GetHighwayToll(int id, NordicTransportContext context)
        {
            context.HighwayTolls.Include(g => g.Transactions).ToList();
            return context.HighwayTolls.Find(id);
        }

        public IList<HighwayToll> GetHighwayTolls(NordicTransportContext context)
        {
            return context.HighwayTolls.ToList();
        }

    }
}
