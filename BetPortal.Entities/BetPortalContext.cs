using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetPortal.Entities
{
    public class BetPortalContext : DbContext
    {
        public BetPortalContext() : base("name=BetPortalContext") { }
        public BetPortalContext(string conn) : base(conn) { }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Horse> Horses { get; set; }
        public DbSet<Bet> Bets { get; set; }
    }
}
