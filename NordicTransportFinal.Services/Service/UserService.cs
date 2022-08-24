using NordicTransportFinal.Data.Models.Domain;
using NordicTransportFinal.Data.DAO;
using NordicTransportFinal.Data.IDAO;
using NordicTransportFinal.Data.Repository;
using NordicTransportFinal.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NordicTransportFinal.Services.Models;

namespace NordicTransportFinal.Services.Service
{
    public class UserService : IUserService
    {
        private IUserDAO userDAO;
        private ICountryDAO countryDAO;
        private IRoleDAO roleDAO;
        public UserService()
        {
            userDAO = new UserDAO();
            countryDAO = new CountryDAO();
            roleDAO = new RoleDAO();
        }

        public void AddUser(UserCountryRole userCountryRole) 
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            User newUser = new User() //Create new User Object
            {
                UserID = finalString,
                UForename = userCountryRole.UForename,
                USurname = userCountryRole.USurname,
                UDOB = userCountryRole.UDOB,
                UAddress = userCountryRole.UAddress,
                UPostcode = userCountryRole.UPostcode,
                UEmail = userCountryRole.UEmail,
                UPassword = userCountryRole.UPassword
            };
            using (var context = new NordicTransportContext())
            {

                //Context is created
                userDAO.AddUser(newUser, context); // Add User
                Country country = countryDAO.GetCountry(userCountryRole.Country, context); //Create Country Object 
                countryDAO.AddUserToCollection(newUser, country, context); //Add User to Collection of Country
                //Role role = roleDAO.GetRole(userCountryRole.Role, context); //Create Artist Object
                //roleDAO.AddUserToCollection(newUser, role, context); //Add Music to Collection of Artist
                context.SaveChanges();
            }
        }

        public IList<Contract> GetContracts(int id)
        {
            using (var context = new NordicTransportContext())
            {
                return userDAO.GetContracts(id, context);
            }
        }

        public User GetUser(string id)
        {
            using (var context = new NordicTransportContext())
            {
                return userDAO.GetUser(id, context);
            }
        }

        public IList<User> GetUsers()
        {          
           using (var context = new NordicTransportContext())
           {
            return userDAO.GetUsers(context);
           }
            
        }
    }
}
