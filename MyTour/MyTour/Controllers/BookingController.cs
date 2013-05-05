using System.Web.Mvc;
using MyTour.ViewModels;

namespace MyTour.Controllers
{
    public class BookingController : Controller
    {
        //
        // GET: /Booking/

        public ActionResult Index()
        {
            //if (Request.IsAjaxRequest())
            //    return PartialView("PartialBooking");

            //return View();
            return PartialView("PartialBookingsHome");
        }

        [HttpGet]
        public ActionResult Booking(string place)
        {
        
            return View("BookingPage");
        }

        [HttpPost]
        public ActionResult Booking(BookingViewModel viewmodel)
        {
            if (ModelState.IsValid)
            {
                return Redirect("Home/Index");
            }

            return View("BookingPage");
        }

    }
}
