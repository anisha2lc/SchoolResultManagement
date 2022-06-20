using Microsoft.AspNetCore.Mvc;

namespace DotnetProject.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
