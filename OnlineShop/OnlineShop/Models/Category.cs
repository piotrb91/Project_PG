using System.Collections;
using System.Collections.Generic;


namespace OnlineShop.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryForMen { get; set; }
        public bool CategoryForWomen { get; set; }


        public virtual ICollection<Product> Products { get; set; }

    

    }
}