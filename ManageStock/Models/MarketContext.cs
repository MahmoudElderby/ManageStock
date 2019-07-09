using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ManageStock.Models
{
    public class MarketContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Broker> Brokers { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Order> Orders { get; set; }
        public MarketContext() : base("MarketContext")
        {

        }
    }
}