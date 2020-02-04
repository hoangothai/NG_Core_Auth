using System;
using System.ComponentModel.DataAnnotations;

namespace NG_Core_Auth.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } 
    }
}