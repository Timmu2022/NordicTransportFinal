using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Data.IDAO
{
    public interface ICustVehicleDAO
    {
        IList<CustVehicle> GetCustVehicles(NordicTransportContext context); 
        CustVehicle GetCustVehicle(string id, NordicTransportContext context);
        void GetUserTransactions(CustVehicle custVehicle, NordicTransportContext context);
    }
}
