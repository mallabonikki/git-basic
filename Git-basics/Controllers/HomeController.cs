using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Git_basics.Controllers
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

        public ContentResult Multiply(int a, int b)
        {
            //return Content(a + "*" + b + " = " + a*b);
            return Content(string.Format("{0} * {1} = {2}", a, b, a*b));
        }

        public ContentResult Divide(int a, int b)
        {
            return Content((a/b).ToString());
        }
    }
}