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
                new Category() { CategoryID=1, CategoryName="Damskie Adidasy"},
                new Category() { CategoryID=2, CategoryName="Damskie na Obcasie"},
                new Category() { CategoryID=3, CategoryName="Damskie Klapki"},
                new Category() { CategoryID=4, CategoryName="Damskie Sandaly"},
                new Category() { CategoryID=5, CategoryName="Meskie Adidasy"},
                new Category() { CategoryID=6, CategoryName="Meskie Eleganckie"},

                };
            categories.ForEach(k => context.Categories.AddOrUpdate(k));
            context.SaveChanges();

            var products = new List<Product>
            {
                 new Product() { ProductID=1, CategoryID=5, ProductName="Adidos One", DateAdded=DateTime.Now,
                 NameImageFile="adidasy1.png", ShoeDescribe="Wygodne adidasy w kolorze szarym.", Price=50 },
                 new Product() { ProductID=2, CategoryID=5, ProductName="Adidos Light", DateAdded=DateTime.Now,
                 NameImageFile="adidasy2.png", ShoeDescribe="Granatowe, lekkie adidasy.", Price=150 },
                 new Product() { ProductID=3, CategoryID=6, ProductName="Gino Lanetto", DateAdded=DateTime.Now,
                 NameImageFile="eleganckie1.png", ShoeDescribe="Obuwie przeznaczone na imprezy okolicznościowe", Price=30 },
                 new Product() { ProductID=4, CategoryID=6, ProductName="Vermicello", DateAdded=DateTime.Now,
                 NameImageFile="eleganckie2.png", ShoeDescribe="Lekkie, wygodne obuwie", Price=40 },
                 new Product() { ProductID=5, CategoryID=6, ProductName="Lanetto Millenium", DateAdded=DateTime.Now,
                 NameImageFile="eleganckie3.png", ShoeDescribe="Buty na niewielkim podwyższeniu sprawdzają się o każdej porze roku.", Price=50 },
                 new Product() { ProductID=6, CategoryID=6, ProductName="Elegant One", DateAdded=DateTime.Now,
                 NameImageFile="eleganckie4.png", ShoeDescribe="Idealne dla osób lubiących klasykę.", Price=70 },
                 new Product() { ProductID=7, CategoryID=6, ProductName="Lanetti Shoe", DateAdded=DateTime.Now,
                 NameImageFile="eleganckie5.png", ShoeDescribe="Ciemne, wygodne obuwie", Price=90 },
                 new Product() { ProductID=8, CategoryID=8, ProductName="Klaczek", DateAdded=DateTime.Now,
                 NameImageFile="klapki1.png", ShoeDescribe="Skórzane klapki.", Price=20 },
                 new Product() { ProductID=9, CategoryID=8, ProductName="Klabut", DateAdded=DateTime.Now,
                 NameImageFile="klapki2.png", ShoeDescribe="Wygodne klapki.", Price=30 },






    };
            products.ForEach(k => context.Products.AddOrUpdate(k));
            context.SaveChanges();
        }
    }
}