using ReturnMgmtClientProject.Models.View_Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace ComponentProcessingAPIProject.test
{
    public partial class ProcessDetail
    {
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public long? CreditCardNumber { get; set; }
        public string ComponentType { get; set; }
        public string ComponentName { get; set; }
        public int? Quantity { get; set; }
        public string IsPriorityRequest { get; set; }
        public int RequestId { get; set; }
        public double? ProcessingCharge { get; set; }
        public double? PackagingAndDeliveryCharge { get; set; }
        public DateTime? DateofDelivery { get; set; }

        public virtual Login NameNavigation { get; set; }
    }
}
