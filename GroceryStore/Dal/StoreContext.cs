using GroceryStore.Models;
using GroceryStore.Models.Products;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace GroceryStore.Dal
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("StoreContext")
        {
        }
        public DbSet<ProductDTO> ProductDTO { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}


