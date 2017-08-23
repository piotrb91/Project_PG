using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Wprowadz e-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Wprowadz haslo")]
        [DataType(DataType.Password)]
        [Display (Name = "Haslo")]
        public string Password { get; set; }



        [Display(Name = "Zapamietaj mnie")]
        public bool RememberMe { get; set; }

    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [StringLength(20,ErrorMessage ="{0} musi miec co najmniej {2} znakow!", MinimumLength = 6 )]
        [DataType(DataType.Password)]
        [Display(Name = "Haslo")]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [Display(Name = "Potwierdz haslo")]
        [Compare("Password", ErrorMessage ="Haslo oraz potwierdzenie hasla musza byc identyczne!")]
        public string ConfirmPassword { get; set; }


    }
}