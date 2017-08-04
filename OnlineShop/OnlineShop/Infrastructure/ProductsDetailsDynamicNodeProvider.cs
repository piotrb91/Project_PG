using MvcSiteMapProvider;
using OnlineShop.DAL;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Infrastructure
{
    public class ProductsDetailsDynamicNodeProvider : DynamicNodeProviderBase
    {
        private ShopContext db = new ShopContext();
        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode nodee)
        {

            var returnValue = new List<DynamicNode>();

            foreach (Product product in db.Products)
            {
                DynamicNode node = new DynamicNode();
                node.Title = product.ProductName;
                node.Key = "Product_" + product.ProductID;
                node.ParentKey = "Category_" + product.CategoryID;
                node.RouteValues.Add("id", product.ProductID);
                returnValue.Add(node);

            }

            return returnValue;
        }
    }
}