using OnlineShop.Migrations;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace OnlineShop.DAL
{
    public class ProductsInitializer : MigrateDatabaseToLatestVersion<ShopContext,Configuration>
    {
      

        public static void SeedShopData(ShopContext context)
        {

            var categories = new List<Category>
            {
                new Category() { CategoryID=1, CategoryName="Adidasy"},
                new Category() { CategoryID=2, CategoryName="Eleganckie"},
                new Category() { CategoryID=3, CategoryName="Klapki"},
                new Category() { CategoryID=4, CategoryName="Sandaly"},
                new Category() { CategoryID=5, CategoryName="Sportowe"},
                new Category() { CategoryID=6, CategoryName="Trampki"},

                };
            categories.ForEach(k => context.Categories.AddOrUpdate(k));
            context.SaveChanges();

            var products = new List<Product>
            {
                 new Product() { ProductID=1, CategoryID=1, ProductName="Testowe1", DateAdded=DateTime.Now,
                 NameImageFile="a.png", ShoeDescribe="To jest opis", Price=50 },
                 new Product() { ProductID=2, CategoryID=1, ProductName="Testowe2", DateAdded=DateTime.Now,
                 NameImageFile="a.png", ShoeDescribe="To jest opis", Price=150 },
                 new Product() { ProductID=3, CategoryID=2, ProductName="Testowe3", DateAdded=DateTime.Now,
                 NameImageFile="a.png", ShoeDescribe="To jest opis", Price=30 },
                 new Product() { ProductID=4, CategoryID=2, ProductName="Testowe4", DateAdded=DateTime.Now,
                 NameImageFile="a.png", ShoeDescribe="To jest opis", Price=40 },
                 new Product() { ProductID=5, CategoryID=3, ProductName="Testowe5", DateAdded=DateTime.Now,
                 NameImageFile="a.png", ShoeDescribe="To jest opis", Price=50 },
                 new Product() { ProductID=6, CategoryID=4, ProductName="Testowe6", DateAdded=DateTime.Now,
                 NameImageFile="a.png", ShoeDescribe="To jest opis", Price=70 },
                 new Product() { ProductID=7, CategoryID=5, ProductName="Testowe7", DateAdded=DateTime.Now,
                 NameImageFile="a.png", ShoeDescribe="To jest opis", Price=90 },
                 new Product() { ProductID=8, CategoryID=6, ProductName="Testowe8", DateAdded=DateTime.Now,
                 NameImageFile="a.png", ShoeDescribe="To jest opis", Price=20 },
                 new Product() { ProductID=9, CategoryID=6, ProductName="Testowe9", DateAdded=DateTime.Now,
                 NameImageFile="a.png", ShoeDescribe="To jest opis", Price=30 },






    };
            products.ForEach(k => context.Products.AddOrUpdate(k));
            context.SaveChanges();
        }
    }
}