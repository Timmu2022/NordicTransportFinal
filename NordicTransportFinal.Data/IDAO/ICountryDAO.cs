using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Data.IDAO
{
    public interface ICountryDAO
    {
        Country GetCountry(int id, NordicTransportContext context);
        IList<Country> GetCountries(NordicTransportContext context); 
        void AddUserToCollection(User user, Country country, NordicTransportContext context); 
    }
}
