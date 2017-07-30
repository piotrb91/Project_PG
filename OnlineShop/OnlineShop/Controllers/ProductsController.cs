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
            return View();
        }


        public ActionResult Details(string id)
        {
            return View();
        }

     

    }
}