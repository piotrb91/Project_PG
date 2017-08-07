using MvcSiteMapProvider.Caching;
using OnlineShop.DAL;
using OnlineShop.Infrastructure;
using OnlineShop.Models;
using OnlineShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        private ShopContext db = new ShopContext();


        

        public ActionResult Index()
        {

            
            //var categories = db.Categories.ToList();

            ICacheProvider cache = new DefaultCacheProvider();







            List<Category> categories;
            if (cache.IsSet(Consts.CategoriesCacheKey))
            {
                categories = cache.Get(Consts.CategoriesCacheKey) as List<Category>;
            }
            else
            {

                categories = db.Categories.OrderBy(a => a.CategoryName).ToList();
                
                cache.Set(Consts.CategoriesCacheKey, categories, 120);
            }








          




            List<Product> recent;
            if (cache.IsSet(Consts.RecentCacheKey))
            {
                recent = cache.Get(Consts.RecentCacheKey) as List<Product>;
            }
            else
            {
                recent = db.Products.OrderByDescending(a => a.DateAdded).Take(6).ToList();
                cache.Set(Consts.RecentCacheKey, recent, 1);
            }

            

            var vm = new HomeViewModel
           {
                Categories = categories,
                Recent = recent

            };
            //var ListCategories = db.Categories.ToList();


            

            return View(vm);
        }

       

        public ActionResult StaticSites(string name)
        {
            return View(name);
        }



     


        }
    }