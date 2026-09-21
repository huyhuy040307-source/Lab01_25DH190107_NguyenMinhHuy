using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Lap01_BT1a()
        {
            return View();
        }

        public ActionResult Lap01_BT2a()
        {
            return View();
        }

        public ActionResult Lap01_BT3a()
        {
            return View();
        }
        public ActionResult Lap01_BT2b()
        {
            return View();
        }
        public ActionResult Lap01_BT3b()
        {
            return View();
        }
        public ActionResult Lap01_BT1b2()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}