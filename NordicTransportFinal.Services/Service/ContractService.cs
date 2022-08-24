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
    public class ContractService : IContractService
    {
        private IContractDAO contractDAO;
        private IUserDAO userDAO;
        public ContractService()
        {
            contractDAO = new ContractDAO();
            userDAO = new UserDAO();
        }
        public void AddContract(ContractUserModel contractUserModel)
        {
            Contract newContract = new Contract() //Create new Contract Object 
            {
                ContractType = contractUserModel.ContractType,
                ContractLength = contractUserModel.ContractLength
            };
            using (var context = new NordicTransportContext())
            {

                //Context is created 
                contractDAO.AddContract(newContract, context); // Add Contract
                User user = userDAO.GetUser(contractUserModel.User, context); //Create User Object 
                userDAO.AddContractToCollection(newContract, user, context); //Add Contract to Collection of User
                context.SaveChanges();
            }
        }

        public Contract GetContract(int id)
        {
            using (var context = new NordicTransportContext())
            {
                return contractDAO.GetContract(id, context);
            }
        }

        public IList<Contract> GetContracts()
        {
            using (var context = new NordicTransportContext())
            {
                return contractDAO.GetContracts(context);
            }

        }

        public IList<CustVehicle> GetCustVehicle(int id)
        {
            using (var context = new NordicTransportContext())
            {
                return contractDAO.GetCustVehicle(id, context);
            }
        }
    }
}
