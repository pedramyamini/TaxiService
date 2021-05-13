using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection.Emit;
using Models;

namespace WND.Data
{
    public class TaxiDbContext : DbContext
    {
        public TaxiDbContext() : base("TaxiService")
        {

        }
        private static readonly Lazy<TaxiDbContext> lazy = new Lazy<TaxiDbContext>(() => new TaxiDbContext());
        public static TaxiDbContext Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //using fluent api to make 1:1 between Driver and Car
            modelBuilder.Configurations.Add(new Data.DriverMap());

            //1:1 relationship Service & Transaction
            modelBuilder.Entity<Models.Service>()
                .HasRequired(t => t.Transaction)
                .WithRequiredDependent(s => s.Service);

            //remove cascadeOnDelete on Driver-Services since we have multiple cascade paths
            modelBuilder.Entity<Models.Driver>()
                .HasMany(s => s.Services)
                .WithRequired(d => d.Driver)
                .HasForeignKey(s=>s.DriverId)
                .WillCascadeOnDelete(false);

            //OriginDestination Index On Path
            modelBuilder.Entity<Models.Path>()
                .HasIndex(p => new { p.Origin,p.Destination})
                .IsClustered(false)
                .IsUnique();

            
        }

        public TaxiDbContext Create()
        {
            throw new NotImplementedException();
        }

        public DbSet<Models.User> Users { get; set; }

        public DbSet<Models.AuthenticatedUser> AuthenticatedUsers { get; set; }

        public DbSet<Models.Car> Cars { get; set; }
        public DbSet<Models.Path> Paths { get; set; }

        public DbSet<Models.Service> Services { get; set; }
        public DbSet<Models.ServicePath> ServicePaths { get; set; }
        public DbSet<Models.Transaction> Transactions { get; set; }


    }
}
