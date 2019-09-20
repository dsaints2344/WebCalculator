using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCalculator.Controllers
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

            return View("index");
        }

        [ChildActionOnly]
        public ActionResult GetHtmlPage(string path)
        {
            return new FilePathResult(path, "text/html");
        }

        public JsonResult Calculate(double first, double second)
        {
            CalculatorService.CalculatorService calculate = new CalculatorService.CalculatorService();
            var result = calculate.Addition(first, second);
            return Json(new { result = result }, JsonRequestBehavior.AllowGet);
        }

    }
}