using Microsoft.AspNetCore.Mvc;

namespace HMSCC.Controllers
{
    public class BuyerProfilesController : Controller
    {
        public IActionResult AnnouncedOrders()
        {
            return base.View();
        }

        public IActionResult AssignedOrders()
        {
            return base.View();
        }

        public IActionResult FinishedOrders()
        {
            return base.View();
        }
        public IActionResult InternalRegulations()
        {
            return base.View();
        }
    }
}
