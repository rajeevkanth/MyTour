using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTour.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        [Authorize]
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView("User");
            }
            return View("User");
        }

    }
}
