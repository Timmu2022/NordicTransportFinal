using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Data.IDAO
{
    public interface IContractDAO
    {
        IList<Contract> GetContracts(NordicTransportContext context);
        Contract GetContract(int id, NordicTransportContext context);
        void AddContract(Contract contract, NordicTransportContext context);
        IList<CustVehicle> GetCustVehicle(int id, NordicTransportContext context);
    }
}
