using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProviderLayer.Interface;
using Common.Domain;
using MyTour.ViewModels;
using MyTour.Extensions;

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
            if (Request.IsAjaxRequest())
            {
                return PartialView("PartialIndex");
            }
            return View();
        }

        public ActionResult About()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView("PartialAbout");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var vm = new ContactViewModel();
            ViewBag.ViewModel = vm;
            if (Request.IsAjaxRequest())
            {
                return PartialView("PartialContact");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel vm)
        {
            if (ModelState.IsValid)
            {
                _provider.AddContactInfo(vm.ToModel());
                if(Request.IsAjaxRequest())
                return PartialView("PartialRegistrationConfirmation");

                return View("PartialRegistrationConfirmation");
            }
            return View();

        }

    }
}
