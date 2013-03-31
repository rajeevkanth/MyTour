using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTour.Controllers
{
    public class BookingController : Controller
    {
        //
        // GET: /Booking/

        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
                return PartialView("PartialBooking");

            return View();
        }

    }
}
