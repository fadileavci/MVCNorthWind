using MVCNorthWind.DAL.Mapping;
using MVCNorthWind.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCNorthWind.DAL
{
   public class NorthWindDbContext:DbContext
    {

        
            public NorthWindDbContext() : base("name=ConnectionStringAdi")
            {

                Database.SetInitializer<NorthWindDbContext>(null);
            }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Configurations.Add(new CustomerMapping());
            }

            public virtual DbSet<Customer> Customers { get; set; }
        
    }
}
