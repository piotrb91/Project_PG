using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        [Required(ErrorMessage = "Podaj imie")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Podaj nazwisko")]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Podaj ulice")]
        [StringLength(50)]
        public string Street { get; set; }
        [Required(ErrorMessage = "Podaj miasto")]
        [StringLength(80)]
        public string City { get; set; }
        [Required(ErrorMessage = "Podaj kod pocztowy")]
        [StringLength(50)]
        public string PostCode { get; set; }
        [Required(ErrorMessage = "Podaj numer telefonu")]
        [StringLength(50)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Podaj mail")]
        [StringLength(50)]
        public string Email { get; set; }
        public string Comment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal OrderValue { get; set; }
        public DateTime DateAdded { get; set; }

        public List<OrderPosition> OrderPositions { get; set; }
    }


    public enum OrderStatus
    {
        New,
        Realized
    }
}