using OnlineShop.DAL;
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
            var categories = db.Categories.ToList();

            var vm = new HomeViewModel
            {
                Categories = categories,


            };
            //var ListCategories = db.Categories.ToList();

            return View(vm);
        }

        public ActionResult StaticSites(string name)
        {
            return View(name);
        }


        public ActionResult CategoriesMenu1(string id)
        {
            var categories1 = db.Categories.ToList();
            return PartialView("_CategoriesMenu1", categories1);
        }

    }
}