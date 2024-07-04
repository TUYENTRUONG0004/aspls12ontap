using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tdtless10c.Controllers
{
    public class TdtHomeController : Controller
    {
        public ActionResult TdtIndex()
        {
            return View();
        }

        public ActionResult TdtAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult TdtContact()
        {
            ViewBag.msv = "2210900134";
            ViewBag.FullName = "Truong Dinh Tuyen";
            return View();
        }
    }
}