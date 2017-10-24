using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StrictDesign.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.BackgroundColor = "#fff";
            return View();
        }
        [Authorize]
        public ActionResult Hemlig()
        {
            ViewBag.Message = "Detta är en hemlig sida.";

            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}