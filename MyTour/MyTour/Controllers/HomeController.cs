using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProviderLayer.Interface;
using Common.Domain;

namespace MyTour.Controllers
{
    public class HomeController : Controller
    {
        private ITourProvider _provider;

        public HomeController(ITourProvider provider)
        {
            _provider = provider;
            
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var contact = new Contact {Id=1, FirstName = "Rajeev", ContactNumberOne = "406231516", ContactNumberTwo = "Nothing", Email = "rajeevkanth.m@gmail.com",LastName="M",Message="Might work" };
            _provider.AddContactInfo(contact);
           
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult AddContact()
        {
            _provider.AddContactInfo(new Contact { FirstName = "Rajeev", LastName = "M", ContactNumberOne = "0406231516", Email = "rajeevkanth.m@gmail.com", Message = "I'm Working" });
            return new EmptyResult();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
