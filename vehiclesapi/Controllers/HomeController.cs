using Microsoft.AspNetCore.Mvc;

namespace vehiclesapi.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
