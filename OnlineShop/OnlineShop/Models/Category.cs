using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class Category
    {
        
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Podaj nazwe kategorii")]
        [StringLength(50)]
        public string CategoryName { get; set; }
       


        public virtual ICollection<Product> Products { get; set; }
    }
}