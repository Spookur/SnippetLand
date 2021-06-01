using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Glassy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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

        public ActionResult PurchaseGlass()
        {
            ViewBag.Message = "Customer can purchase glass here.";

            return View();
        }

        public ActionResult Coffee()
        {
            ViewBag.Message = "Purchase coffee here.";

            return View();
        }
    }
}