using NordicTransportFinal.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Data.Repository
{
    public class NordicTransportInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<NordicTransportContext>
    {
        protected override void Seed(NordicTransportContext context)
        {
            //Creating Country Objects
            Country country1 = new Country()
            {
                CountryName = "England",
                Currency = "GBP"
            };

            Country country2 = new Country()
            {
                CountryName = "Spain",
                Currency = "EUR"
            };

            Country country3 = new Country()
            {
                CountryName = "America",
                Currency = "USD"
            };
            context.Countries.Add(country1); context.Countries.Add(country2); context.Countries.Add(country3);

            //Creating Role Objects
            Role role1 = new Role()
            {
                RoleName = "Admin",
                RoleDescription = "Can see all admin functions"
            };

            Role role2 = new Role()
            {
                RoleName = "Staff",
                RoleDescription = "Can see all staff functions"
            };

            Role role3 = new Role()
            {
                RoleName = "User",
                RoleDescription = "Can see all user functions"
            };
            context.Roles.Add(role1); context.Roles.Add(role2); context.Roles.Add(role3);


            // Creating User Objects
            User user1 = new User()
            {
                UserID = "kieron",
                UForename = "Kieron",
                USurname = "Bennett",
                UDOB = Convert.ToDateTime("12/11/1979"),
                UAddress = "12 Oak Road",
                UPostcode = "SK1 9WP",
                UEmail = "test@gmail.com",
                UPassword = "Test1!"
            };

            User user2 = new User()
            {
                UserID = "john",
                UForename = "John",
                USurname = "doe",
                UDOB = Convert.ToDateTime("12/11/1979"),
                UAddress = "12 Oak Road",
                UPostcode = "SK1 9WP",
                UEmail = "test1@gmail.com",
                UPassword = "Test1!"
            };

            User user3 = new User()
            {
                UserID = "admin",
                UForename = "Admin",
                USurname = "Admin",
                UDOB = Convert.ToDateTime("12/11/1979"),
                UAddress = "12 Oak Road",
                UPostcode = "SK1 9WP",
                UEmail = "admin@gmail.com",
                UPassword = "Admin1!"
            };
            context.Users.Add(user1); context.Users.Add(user2); context.Users.Add(user3);

            //Creating Contract Objects

            Contract contract1 = new Contract()
            {
                ContractType = "Weekly",
                ContractLength = "2 Years"
            };

            Contract contract2 = new Contract()
            {
                ContractType = "Monthly",
                ContractLength = "1 Years"
            };

            Contract contract3 = new Contract()
            {
                ContractType = "Weekly",
                ContractLength = "3 Years"
            };
            context.Contracts.Add(contract1); context.Contracts.Add(contract2); context.Contracts.Add(contract3);

            //Creating CustVehicle Objects

            CustVehicle veh1 = new CustVehicle()
            {
                TravelDate = Convert.ToDateTime("12/03/2022"),
                DistanceTravelled = 24
            };

            CustVehicle veh2 = new CustVehicle()
            {
                TravelDate = Convert.ToDateTime("12/03/2022"),
                DistanceTravelled = 24
            };

            CustVehicle veh3 = new CustVehicle()
            {
                TravelDate = Convert.ToDateTime("12/03/2022"),
                DistanceTravelled = 24
            };
            context.CustVehicles.Add(veh1); context.CustVehicles.Add(veh2); context.CustVehicles.Add(veh3);

            //Creating Location Objects
            Location location1 = new Location()
            {
                LocationName = "Norway1",
                LocationAddress = "13 Norway Street"
            };

            Location location2 = new Location()
            {
                LocationName = "Norway2",
                LocationAddress = "14 Norway Street"
            };

            Location location3 = new Location()
            {
                LocationName = "Norway3",
                LocationAddress = "15 Norway Street"
            };
            context.Locations.Add(location1); context.Locations.Add(location2); context.Locations.Add(location3);

            //Creating TollOperator Objects

            //TollOperator toll1 = new TollOperator()
            //{
            //    TollName = "Toll1"
            //};

            //TollOperator toll2 = new TollOperator()
            //{
            //    TollName = "Toll2"
            //};

            //TollOperator toll3 = new TollOperator()
            //{
            //    TollName = "Toll3"
            //};
            //context.TollOperators.Add(toll1); context.TollOperators.Add(toll2); context.TollOperators.Add(toll3);

            //Creating HighwayToll Objects
            HighwayToll highwayToll1 = new HighwayToll()
            {
                TollName = "Toll1",
                TollPrice = 21.25
            };

            HighwayToll highwayToll2 = new HighwayToll()
            {
                TollName = "Toll2",
                TollPrice = 20
            };

            HighwayToll highwayToll3 = new HighwayToll()
            {
                TollName = "Toll3",
                TollPrice = 16.75
            };
            context.HighwayTolls.Add(highwayToll1); context.HighwayTolls.Add(highwayToll2); context.HighwayTolls.Add(highwayToll3);

            //Creating Transaction Objects
            Transaction transaction1 = new Transaction()
            {
                DistanceTravelled = 12,
                Price = 21.25,
                Total = 255.00,
                IsPaymentCompleted=true
            };

            Transaction transaction2 = new Transaction()
            {
                DistanceTravelled=10,
                Price = 20,
                Total = 200.00,
                IsPaymentCompleted = true
            };

            Transaction transaction3 = new Transaction()
            {
                DistanceTravelled = 20,
                Price = 16.75,
                Total = 335.00,
                IsPaymentCompleted = true
            };
            context.Transactions.Add(transaction1); context.Transactions.Add(transaction2); context.Transactions.Add(transaction3);

            context.SaveChanges();
        }
    }
}
