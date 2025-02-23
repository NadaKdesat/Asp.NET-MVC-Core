using Microsoft.AspNetCore.Mvc;
using Task_5.Models;

namespace Task_5.Controllers
{
    public class UserController : Controller
    {
        private readonly MyDbContext _context;

        public UserController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Users
        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Create(Users user)
        {

            _context.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}