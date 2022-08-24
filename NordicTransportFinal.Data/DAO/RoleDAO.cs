using NordicTransportFinal.Data.IDAO;
using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace NordicTransportFinal.Data.DAO
{
    public class RoleDAO : IRoleDAO
    {
        public void AddUserToCollection(User user, Role role, NordicTransportContext context)
        {
            context.Roles.Find(role.RoleID).Users.Add(user);
        }

        public Role GetRole(int id, NordicTransportContext context)
        {
            context.Roles.Include(g => g.Users).ToList();
            return context.Roles.Find(id);
        }
    }
}
