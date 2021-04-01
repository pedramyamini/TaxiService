using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WND.Models;

namespace WND.Data
{
    public interface ITaxiDbContext
    {
        DbSet<User> Users { get; set; }

        DbSet<AuthenticatedUser> AuthenticatedUsers { get; set; }

        DbSet<Models.Car> Cars { get; set; }

        DbSet<Models.Path> Paths { get; set; }

        DbSet<Models.Service> Services { get; set; }

        DbSet<Models.Transaction> Transactions { get; set; }

        DbSet<Models.ServicePath> ServicePaths { get; set; }


        void SaveChanges();

        
    }
}
