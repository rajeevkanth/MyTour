using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTour.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        [Authorize]
        public ActionResult Index()
        {
                if (Request.IsAjaxRequest())
                {
                    return PartialView(viewName: "PartialAdmin");
                }
                return View(viewName: "Admin");

          
        }

    }
}
