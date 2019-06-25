using System;
using System.ComponentModel.DataAnnotations;

namespace belt1.Models
{
    public class ActivityForm
    {
        [Required]
        [MinLength(5)]
        [Display(Name = "Message")]
        public string Message {get;set;}

        





    }
}