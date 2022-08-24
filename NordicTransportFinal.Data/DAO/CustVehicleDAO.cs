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
    public class CustVehicleDAO : ICustVehicleDAO
    {
        

        public IList<CustVehicle> GetCustVehicles(NordicTransportContext context)
        {
            return context.CustVehicles.ToList();
            
        }

        public CustVehicle GetCustVehicle(string id, NordicTransportContext context)
        {
            context.CustVehicles.Include(u => u.HighwayTolls).ToList();
            return context.CustVehicles.Find(id);
        }

        public void GetUserTransactions(CustVehicle custVehicle, NordicTransportContext context)
        {
            context.CustVehicles.Include(x => x.HighwayTolls).ToList();
        }
    }
}
