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
    public class CountryService : ICountryService
    {
        ICountryDAO countryDAO;
        public CountryService()
        {
            countryDAO = new CountryDAO();
        }

        public IList<Country> GetCountries()
        {
            using (var context = new NordicTransportContext())
            {
                return countryDAO.GetCountries(context);
            }
        }

        public Country GetCountry(int id)
        {
            using (var context = new NordicTransportContext())
            {
                return countryDAO.GetCountry(id, context);
            }
        }
    }
}
