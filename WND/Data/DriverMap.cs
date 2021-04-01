using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WND.Data
{
    public class DriverMap:EntityTypeConfiguration<Models.Driver>
    {
        //1:1 relationship between Driver & Car
        public DriverMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.HasRequired(c1 => c1.Car).WithRequiredPrincipal(c2 => c2.Driver);
        }
    }
}
