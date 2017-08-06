using Microsoft.AspNet.Identity.EntityFramework;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace OnlineShop.DAL
{
    public class ShopContext : IdentityDbContext<ApplicationUser>
    {
        public ShopContext() : base("ShopContext")
        {

        }

        static ShopContext()
        {
            Database.SetInitializer<ShopContext>(null);
        }

        public static ShopContext Create()
        {
            return new ShopContext();
        }

        public DbSet<Product> Products {get; set;}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPosition> OrderPositions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}