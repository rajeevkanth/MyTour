﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyTour.ViewModels;

namespace MyTour.Controllers
{
    public class PlaceController : Controller
    {
        //
        // GET: /Place/

        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView("PartialPlace");
            }
            return View();
        }

    }
}
