using OnlineShop.DAL;
using OnlineShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;





namespace OnlineShop.Controllers
{
    public class ProductsController : Controller
    {
        private ShopContext db =  new ShopContext();

        // GET: Products

        
        public ActionResult Index()
        {

         
        return View();
        }
        


    


    public ActionResult List(string nameCategories, string searchQuery = null)
            {
            
            var category = db.Categories.Include("Products").Where(k => k.CategoryName.ToUpper() == nameCategories.ToUpper()).Single();
            //var products = category.Products.ToList();

            var products = category.Products.Where(a => (searchQuery == null || a.ProductName.ToLower().Contains(searchQuery.ToLower())));


            if (Request.IsAjaxRequest())
            {
                return PartialView("_ProductsList", products);
            }
            return View(products);

            
      

        }

        



        public ActionResult Details(int id)
        {
            var product = db.Products.Find(id);
            return View(product);
        }

        [OutputCache(Duration = 60000)]
        [ChildActionOnly]
        public ActionResult CategoriesMenu()
        {
          
        var categories = db.Categories.ToList();
            return PartialView("_CategoriesMenu",categories);

        }


     


        public ActionResult ProductsTips(string term)
        {
            var products = this.db.Products.Where(a => a.ProductName.ToLower().Contains(term.ToLower()))
            .Take(6).Select(a=>new { label = a.ProductName });

            return Json(products,JsonRequestBehavior.AllowGet);
        }




}
}