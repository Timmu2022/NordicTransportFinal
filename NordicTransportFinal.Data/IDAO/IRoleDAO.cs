using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Data.IDAO
{
    public interface IRoleDAO
    {
        Role GetRole(int id, NordicTransportContext context);
        void AddUserToCollection(User user, Role role, NordicTransportContext context);
    }
}
