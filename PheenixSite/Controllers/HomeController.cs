using System.Web.Mvc;

namespace PheenixSite.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			//return Content("Hello world.");
            ViewBag.ActiveUser = "Nobody";
            return View();
		}
	}
}
