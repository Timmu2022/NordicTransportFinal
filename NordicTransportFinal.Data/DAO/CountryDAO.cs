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
    public class CountryDAO : ICountryDAO
    {
        NordicTransportContext context;
        public CountryDAO()
        {
            context = new NordicTransportContext();
        }

        public void AddUserToCollection(User user, Country country, NordicTransportContext context)
        {
            context.Countries.Find(country.CountryID).Users.Add(user);
        }

        public IList<Country> GetCountries(NordicTransportContext context)
        {
            
            return context.Countries.ToList();
        }

        public Country GetCountry(int id, NordicTransportContext context)
        {
            context.Countries.Include(g => g.Users).ToList();
            return context.Countries.Find(id);
        }
    }
}
