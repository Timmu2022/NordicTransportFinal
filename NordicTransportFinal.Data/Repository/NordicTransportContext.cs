using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NordicTransportFinal.Data.Models.Domain;

namespace NordicTransportFinal.Data.Repository
{
    public class NordicTransportContext : DbContext
    {
        public NordicTransportContext() : base("NordicTransportContext")
        {
            Database.SetInitializer(new NordicTransportInitialiser());
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Location> Locations { get; set; }
        //public DbSet<TollOperator> TollOperators { get; set; }
        public DbSet<CustVehicle> CustVehicles { get; set; }
        public DbSet<HighwayToll> HighwayTolls { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
