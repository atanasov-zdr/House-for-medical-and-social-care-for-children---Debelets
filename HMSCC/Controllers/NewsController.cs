using Microsoft.AspNetCore.Mvc;

namespace HMSCC.Controllers
{
    public class NewsController : Controller
    {
        [Route("News")]
        public IActionResult News()
        {
            return base.View();
        }
    }
}
