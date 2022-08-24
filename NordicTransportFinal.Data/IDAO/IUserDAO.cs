using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Data.IDAO
{
    public interface IUserDAO
    {
        void AddContractToCollection(Contract contract, User user, NordicTransportContext context); 
        void RemoveContractFromCollection(Contract contract, string userId, NordicTransportContext context);
        void AddUser(User user, NordicTransportContext context);
        void DeleteUser(User user, NordicTransportContext context);
        IList<User> GetUsers(NordicTransportContext context);
        User GetUser(Contract contract, NordicTransportContext context);
        User GetUser(string id, NordicTransportContext context);
        IList<Contract> GetContracts(int id, NordicTransportContext context);

    }
}
