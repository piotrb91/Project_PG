using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using OnlineShop.App_Start;
using OnlineShop.DAL;
using OnlineShop.Infrastructure;
using OnlineShop.Models;
using OnlineShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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




     





        public int DownloadQuantityItemsBasket()
        {
            
            return basketManager.DownloadQuantityBasketPositions();
        }


        public ActionResult RemoveFromBasket(int productID)
        {
            int quantityPositions = basketManager.RemoveFromBasket(productID);
            int quantityBasketPositions = basketManager.DownloadQuantityBasketPositions();
            decimal basketValue = basketManager.DownloadBasketValue();

            var result = new BasketRemoveViewModel
            {
                IdPositionRemoved = productID,
                QuantityPositionsRemoved = quantityPositions,
                BasketTotalPrice = basketValue,
                BasketQuantityPositions = quantityBasketPositions
            };

            return Json(result);
        }


         public async Task<ActionResult> Pay()
        {
            if (Request.IsAuthenticated)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());

                var order = new Order
                {
                    Name = user.UserData.Name,
                    Surname = user.UserData.Surname,
                    Address = user.UserData.Address,
                    City = user.UserData.City,
                    PostCode = user.UserData.PostCode,
                    Email = user.UserData.Email,
                    Phone = user.UserData.Phone
                };

                return View(order);
            }
            else
                return RedirectToAction("Login", "Account", new { returnUrl = Url.Action("Pay", "Basket") });
        }







        [HttpPost]
        public async Task<ActionResult> Pay(Order orderDetails)
        {
            if (ModelState.IsValid)
            {
                
               var userId = User.Identity.GetUserId();
                
                var newOrder = basketManager.CreateOrder(orderDetails, userId);

                var user = await UserManager.FindByIdAsync(userId);
                TryUpdateModel(user.UserData);
                await UserManager.UpdateAsync(user);

               
               basketManager.EmptyBasket();

                return RedirectToAction("OrderConfirmation");
            }
            else
                return View(orderDetails);
        }



        public ActionResult OrderConfirmation()
        {
         
            return View();
        }













        private ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }




    }
}