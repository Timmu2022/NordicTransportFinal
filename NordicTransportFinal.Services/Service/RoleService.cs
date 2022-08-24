using NordicTransportFinal.Data.DAO;
using NordicTransportFinal.Data.IDAO;
using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Data.Repository;
using NordicTransportFinal.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Services.Service
{
    public class RoleService : IRoleService
    {
        IRoleDAO roleDAO;
        public RoleService()
        {
            roleDAO = new RoleDAO();
        }

        public Role GetRole(int id)
        {
            using (var context = new NordicTransportContext())
            {
                return roleDAO.GetRole(id, context);
            }
        }
    }
}
