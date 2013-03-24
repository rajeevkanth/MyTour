using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProviderLayer.Interface;
using Common.Domain;
using MyTour.ViewModels;

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

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";
            return View();
        }

        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var vm = new ContactViewModel();
            ViewBag.ViewModel = vm;
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel vm)
        {
            var vmm = ViewBag.ViewModel;
            
            return new EmptyResult();
        }

    }
}
