using OnlineShop.DAL;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Infrastructure
{
    public class BasketManager
    {

        private ShopContext db;
        private ISessionManager session;

        public BasketManager(ISessionManager session, ShopContext db)
        {
            this.session = session;
            this.db = db;

        }



        public List<BasketPosition> DownloadBasket()
        {

            List<BasketPosition> basket;

            if (session.Get<List<BasketPosition>>(Consts.BasketSessionKey)==null)
            {
                basket = new List<BasketPosition>();
            }
            else
            {
                basket = session.Get<List<BasketPosition>>(Consts.BasketSessionKey) as List<BasketPosition>;
            }
            return basket;
        }


        public void AddToBasket(int productID)
        {
            var basket = DownloadBasket();
            var basketPosition = basket.Find(a => a.Product.ProductID == productID);

            if (basketPosition != null)
                basketPosition.Quantity++;
            else
            {
                var productToAdd = db.Products.Where(a => a.ProductID == productID).SingleOrDefault();

                if (productToAdd != null)
                {
                    var newBasketPosition = new BasketPosition()
                    {
                        Product = productToAdd,
                        Quantity = 1,
                        Value = productToAdd.Price,

                    };

                    basket.Add(newBasketPosition);

                }

            }

            session.Set(Consts.BasketSessionKey, basket);
        }


        public int RemoveFromBasket(int productID)
        {
            var basket = DownloadBasket();
            var basketPosition = basket.Find(a => a.Product.ProductID == productID);

            if (basketPosition != null)
            {
                if(basketPosition.Quantity > 1)
                {
                    basketPosition.Quantity--;
                    return basketPosition.Quantity;
                }
                else
                {
                    
                    basket.Remove(basketPosition);
                }
            }


            return 0;
        }


        public decimal DownloadBasketValue()
        {
            var basket = DownloadBasket();
            return basket.Sum(a => (a.Quantity * a.Product.Price));
        }

        public int DownloadQuantityBasketPositions()
        {
            var basket = DownloadBasket();
            int quantity = basket.Sum(a => a.Quantity);
            return quantity;
          
        }


        public Order CreateOrder(Order newOrder,string userId)
        {
            var basket = DownloadBasket();
            newOrder.DateAdded = DateTime.Now;
            newOrder.UserId = userId;

            db.Orders.Add(newOrder);
            
            if (newOrder.OrderPositions == null)

            
                newOrder.OrderPositions = new List<OrderPosition>();
                decimal basketValue = 0;

                foreach (var basketItem in basket)
                {
                    var newOrderPosition = new OrderPosition()
                    {
                        ProductID = basketItem.Product.ProductID,
                        Quantity = basketItem.Quantity,
                        PurchasePrice = basketItem.Product.Price
                    };

                    basketValue += (basketItem.Quantity * basketItem.Product.Price);
                    newOrder.OrderPositions.Add(newOrderPosition);
                }

                newOrder.OrderValue = basketValue;
                db.SaveChanges();

                return newOrder;
            }
        
            public void EmptyBasket()
            {
                session.Set<List<BasketPosition>>(Consts.BasketSessionKey, null);
            }

    }
}