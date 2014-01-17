using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IHOWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return RedirectToAction("NewsandEvents");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Connect()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult NewsandEvents()
        {
            IHODbEntities db = new IHODbEntities();
            return View("NewsandEvents");
        }

        public ActionResult TestAccordion()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult NewsandEvents()
        //{
        //    return View();
        //}
    }
}