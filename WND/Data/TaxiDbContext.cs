using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using WND.Models;

namespace WND.Data
{
    public class TaxiDbContext : DbContext
    {
        public TaxiDbContext():base("TaxiService")
        {
            
        }

        public DbSet<User> Users { get; set; }

        public DbSet<AuthenticatedUser> AuthenticatedUsers { get; set; }
    }
}
