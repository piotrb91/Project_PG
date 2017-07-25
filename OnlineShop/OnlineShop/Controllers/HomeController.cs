using OnlineShop.DAL;
using OnlineShop.Models;
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

            var ListCategories = db.Categories.ToList();

            return View();
        }
    }
}