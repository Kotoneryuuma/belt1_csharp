using System;
using System.ComponentModel.DataAnnotations;

namespace belt1.Models
{
    public class RegisterForm
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "User Name")]
        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Use Characters only")]
        public string UserName {get;set;}

        [Required]
        [MinLength(2)]
        [Display(Name = "Alias")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Use only letters and numbers")]
        public string Alias {get;set;}



        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password {get;set;}

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Re-type Password")]
        public string ConfirmPassword {get;set;}


    }
}
