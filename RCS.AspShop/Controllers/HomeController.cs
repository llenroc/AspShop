using System.Web.Mvc;

namespace RCS.AspShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This project is built by Robert for test and demonstration of various concepts in ASP. For further details please check the descriptions (ReadMe)of the involved repositories.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}