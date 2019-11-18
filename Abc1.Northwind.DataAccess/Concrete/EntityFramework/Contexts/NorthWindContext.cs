using Abc.Northwind.Entities.Concrete;
using Abc.Northwind.DataAccess.Concrete.EntityFramework.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Northwind.DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthWindContext:DbContext
    {
        
        public NorthWindContext()
        {
            Database.SetInitializer<NorthWindContext>(null);
        }
        public DbSet<Product> Products{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}
