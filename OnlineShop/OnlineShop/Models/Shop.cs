using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Shop
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public DateTime DateAdded { get; set; }
        public string NameImageFile { get; set; }
        public string ShoeDescribe { get; set; }
        public decimal Price { get; set; }


        public virtual Category Kategoria { get; set; }
    }
}