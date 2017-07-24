using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineShop.DAL
{
    public class ShopContext : DbContext
    {
        public DbSet<Shop> Produkty {get; set;}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderPosition> OrderPositions { get; set; }

    }
}