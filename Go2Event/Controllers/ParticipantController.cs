using Microsoft.AspNetCore.Mvc;

namespace Go2Event.Controllers
{
    public class ParticipantController : Controller
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
