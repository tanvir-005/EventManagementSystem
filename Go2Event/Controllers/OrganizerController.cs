using Microsoft.AspNetCore.Mvc;

namespace Go2Event.Controllers
{
    public class OrganizerController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
