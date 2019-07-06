using Microsoft.AspNetCore.Mvc;

namespace HMSCC.Controllers
{
    public class GalleriesController : Controller
    {
        public IActionResult PhotosByProject()
        {
            return base.View();
        }

        public IActionResult PhotosOfDailyCenter()
        {
            return base.View();
        }

        public IActionResult PhotosOfHmscc()
        {
            return base.View();
        }
    }
}
