using Microsoft.AspNetCore.Mvc;

namespace HMSCC.Controllers
{
    public class ArchivesController : Controller
    {
        [Route("Archive")]
        public IActionResult Archive()
        {
            return base.View();
        }
    }
}
