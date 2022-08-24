using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Services.IService
{
    public interface IUserService
    {
        IList<User> GetUsers();
        void AddUser(UserCountryRole userCountryRole);
        User GetUser(string id);
        IList<Contract> GetContracts(int id);
    }
}
