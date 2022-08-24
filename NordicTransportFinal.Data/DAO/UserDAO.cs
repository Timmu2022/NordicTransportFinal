using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Data.IDAO;
using NordicTransportFinal.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Data.DAO
{
    public class UserDAO : IUserDAO
    {
        private NordicTransportContext context;
        public UserDAO()
        {
            context = new NordicTransportContext();
        }
        public void AddContractToCollection(Contract contract, User user, NordicTransportContext context)
        {
            context.Users.Find(user.UserID).Contracts.Add(contract);
        }

        public void AddUser(User user, NordicTransportContext context)
        {
            context.Users.Include(g => g.Contracts).ToList();
            context.Users.Add(user);
        }

        public void DeleteUser(User user, NordicTransportContext context)
        {
            throw new NotImplementedException();
        }

        public IList<Contract> GetContracts(int id, NordicTransportContext context)
        {
            context.Users.Include(m => m.Contracts).ToList();
            return context.Contracts.ToList();
        }

        public User GetUser(Contract contract, NordicTransportContext context)
        {
            context.Users.Include(g => g.Contracts).ToList();
            return context.Users.Find(contract);
        }

        public User GetUser(string id, NordicTransportContext context)
        {
            context.Users.Include(g => g.Contracts).ToList();
            return context.Users.Find(id);
        }

        public IList<User> GetUsers(NordicTransportContext context) 
        {            
            return context.Users.ToList();
        }

        public void RemoveContractFromCollection(Contract contract, string userId, NordicTransportContext context)
        {
            throw new NotImplementedException();
        }

    }
}
