using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.ViewModels
{
    public class PaymentGatewayVM
    {
        public string CardNo { get; set; }
        public string CCV { get; set; }
        public string ExpiryDate { get; set; }
    }
}
