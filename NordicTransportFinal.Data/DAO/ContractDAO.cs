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
    public class ContractDAO : IContractDAO
    {
        public void AddContract(Contract contract, NordicTransportContext context)
        {
            context.Contracts.Include(g => g.CustVehicles).ToList();
            context.Contracts.Add(contract);
        }

        public Contract GetContract(int id, NordicTransportContext context)
        {
            context.Contracts.Include(g => g.CustVehicles).ToList();
            return context.Contracts.Find(id);
        }

        public IList<Contract> GetContracts(NordicTransportContext context)
        {
            return context.Contracts.ToList();
        }

        public IList<CustVehicle> GetCustVehicle(int id, NordicTransportContext context)
        {
            context.Contracts.Include(m => m.CustVehicles).ToList();
            return context.CustVehicles.ToList();
        }
    }
}
