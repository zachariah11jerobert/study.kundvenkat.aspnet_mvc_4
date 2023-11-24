using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {

        public string Index()
        {
            return "Hello from MVC Application";
        }

        public string GetDetails()
        {
            return "GetDetails() Invoked";
        }

        public List<string> CountryList()
        {
            return new List<string>() {
                "India",
                "US",
                "UK",
                "Canada"
            };
        }

        public ViewResult Countries()
        {
            ViewBag.Countries=new List<string>() {
                "India",
                "US",
                "UK",
                "Canada"
            };

            return View();
        }

        public ViewResult Fruits()
        {
            ViewData["Fruits"] = new List<string>() {
                "Apple",
                "Banana",
                "Grapes",
                "Orange",
                "Pomegranate"
            };

            return View();
        }

    }
}
