using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReturnMgmtClientProject.Models.View_Models
{
    public class PaymentModel
    {
        [Display(Name = "Request Id")]
        public int RequestId { get; set; }

        [Display(Name = "Credit Card Number")]
        [Required]
        //[DataType(DataType.CreditCard)]
        //[MaxLength(16, ErrorMessage = " Length should be 16")]
        public string CreditCardNumber { get; set; }

        [Display(Name = "Credit Limit(in ₹.)")]
        [Required]
        //[MinLength(1000, ErrorMessage = "Credit Limit must be minimum of 1000(₹.)")]
        //[MaxLength(10000, ErrorMessage = "Credit Limit can be maximum of 10000(₹.)")]
        public int CreditLimit { get; set; }
    }
}
