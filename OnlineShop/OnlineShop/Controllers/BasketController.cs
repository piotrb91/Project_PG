using OnlineShop.DAL;
using OnlineShop.Infrastructure;
using OnlineShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class BasketController : Controller
    {

        private BasketManager basketManager;
        private ISessionManager sessionManager { get; set; }

        private ShopContext db;


        public BasketController()
        {

            db = new ShopContext();
            sessionManager = new SessionManager();
            basketManager = new BasketManager(sessionManager, db);
        }

        // GET: Basket
        public ActionResult Index()
        {
            var basketPositions = basketManager.DownloadBasket();
            var totalPrice = basketManager.DownloadBasketValue();

            BasketViewModel basketVM = new BasketViewModel()
            {
                BasketPositions = basketPositions,
                TotalPrice = totalPrice
            };
            return View(basketVM);
        }


        public ActionResult AddToBasket(int id)
        {
            basketManager.AddToBasket(id);
            
            return RedirectToAction("Index");
        }
    }
}