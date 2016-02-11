﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        // GET: Derived
        public ActionResult Index()
        {
            ViewBag.Message = "Hello from the DerivedController Index method";
            return View("MyView");
        }

        public RedirectResult Redirect()
        {
            return Redirect("/Derived/Index");
        }

        public RedirectResult RedirectPermanent()
        {
            return RedirectPermanent("/Derived/Index");
        }
    }
}