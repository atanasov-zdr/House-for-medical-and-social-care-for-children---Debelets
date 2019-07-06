using Microsoft.AspNetCore.Mvc;

namespace HMSCC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return base.View();
        }
    }
}
