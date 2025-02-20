using Microsoft.AspNetCore.Mvc;

namespace Task_2.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
