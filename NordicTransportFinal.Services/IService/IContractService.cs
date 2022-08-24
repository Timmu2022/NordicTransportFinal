using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Services.IService
{
    public interface IContractService
    {
        void AddContract(ContractUserModel contractUserModel); 
        Contract GetContract(int id); 
        IList<Contract> GetContracts();

        IList<CustVehicle> GetCustVehicle(int id);
    }
}
