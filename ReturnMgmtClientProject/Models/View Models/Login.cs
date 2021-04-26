using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReturnMgmtClientProject.Models.View_Models
{
    public class Login
    {
        [Required]
        [RegularExpression("[A-za-z]*", ErrorMessage = "Username should contain alphabets only!")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(9, ErrorMessage = "Maximum Length should be 9")]
        [MinLength(3, ErrorMessage = "Minimum Length should be 3")]
        public string Password { get; set; }
    }
}
