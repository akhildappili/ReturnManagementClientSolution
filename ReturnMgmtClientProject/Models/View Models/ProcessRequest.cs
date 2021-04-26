using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentProcessingAPIProject.Test.view_model
{
    public class ProcessRequest
    {
        [Required]
        [RegularExpression("[A-za-z]*", ErrorMessage = "Name should contain alphabets only!")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required]
        [Display(Name = "Contact Number ")]
        public string ContactNumber { get; set; }

        [Display(Name = "Credit Card Number")]
        [Required]
        //[DataType(DataType.CreditCard)]
        //[MaxLength(16, ErrorMessage = " Length should be 16")]
        public string CreditCardNumber { get; set; }

        [Display(Name = "Component Type")]
        public string ComponentType { get; set; }

        [Required]
        [RegularExpression("[A-za-z]*", ErrorMessage = "Component Name should contain alphabets only!")]
        [Display(Name = "Component Name")]
        public string ComponentName { get; set; }

        [Required]
        [Display(Name = "Quantity")]

        public int Quantity { get; set; }

        
        public string IsPriorityRequest { get; set; }
    }
}
