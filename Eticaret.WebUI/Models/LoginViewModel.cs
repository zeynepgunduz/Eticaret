﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Eticaret.WebUI.Models
{
    public class LoginViewModel
    {
        [DataType(DataType.EmailAddress),Required(ErrorMessage ="Email boş geçilemez!")]
        public string Email { get; set; }
 
        [DisplayName("Şifre"), Required(ErrorMessage = "Şifre boş geçilemez!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string? ReturnUrl  { get; set; }
        public bool RememberMe { get; set; }
    }
}
