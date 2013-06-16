using System.Web.Mvc;

namespace TestingMono.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return Content("Hello world.");
		}
	}
}
