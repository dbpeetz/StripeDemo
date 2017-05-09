using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StripeDemo.Models
{
    public class IndexViewModels
    {
        public string StripePublishableKey { get; set; }
    }

    public class ChargeViewModel
    {
        public string StripeToken { get; set; }
        public string StripeEmail { get; set; }
    }

    public class CustomViewModel
    {
        public string StripePublishableKey { get; set; }
        public string StripeToken { get; set; }
        public string StripeEmail { get; set; }
    }
}