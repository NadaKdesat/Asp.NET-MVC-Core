using Microsoft.AspNetCore.Mvc;

namespace RIAYA.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Sign_up()
        {
            return View();
        }

        public IActionResult Log_in()
        {
            return View();
        }
    }
}
