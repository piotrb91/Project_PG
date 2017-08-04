using MvcSiteMapProvider;
using OnlineShop.DAL;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Infrastructure
{
    public class CategoriesDynamicNodeProvider : DynamicNodeProviderBase
    {
        private ShopContext db = new ShopContext();
    public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode nodee)
    {

        var returnValue = new List<DynamicNode>();

        foreach (Category category in db.Categories)
        {
            DynamicNode node = new DynamicNode();
            node.Title = category.CategoryName;
            node.Key = "Category_" + category.CategoryID;
            node.RouteValues.Add("nameCategories", category.CategoryName);
            returnValue.Add(node);

        }

        return returnValue;
    }
}
}