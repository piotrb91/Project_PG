using OnlineShop.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class ProductsController : Controller
    {
        private ShopContext db = new ShopContext();

        // GET: Products
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult List(string nameCategories)
        {

            var category = db.Categories.Include("Products").Where(k => k.CategoryName.ToUpper() == nameCategories.ToUpper()).Single();
            var products = category.Products.ToList();
            return View(products);
        }


        public ActionResult Details(string id)
        {
            return View();
        }

       
        public ActionResult CategoriesMenu(string id)
        {
            var categories = db.Categories.ToList();
            return PartialView("_CategoriesMenu",categories);
        }


  

    }
}