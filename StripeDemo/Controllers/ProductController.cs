using StripeDemo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StripeDemo.Controllers
{
    public class ProductController : Controller
    {
        // embedded form
        public ActionResult Index()
        {
            string stripePublishableKey = ConfigurationManager.AppSettings["stripePublishableKey"];
            var model = new ProductViewModels() { StripePublishableKey = stripePublishableKey };
            return View(model);
        }

        //custom form
        public ActionResult Custom()
        {
            return View();
        }
    }
}
