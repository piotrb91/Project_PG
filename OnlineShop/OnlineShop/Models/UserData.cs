﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class UserData
    {

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostCode { get; set; }

        [RegularExpression(@"(\+\d{2})*[\d\s-]+", ErrorMessage = "Bledny format numeru telefonu.")]
        public string Phone { get; set; }

        [EmailAddress(ErrorMessage = "Bledny format adresu e-mail.")]
        public string Email { get; set; }
    }
}