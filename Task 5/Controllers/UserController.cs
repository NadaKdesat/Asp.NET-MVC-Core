using Microsoft.AspNetCore.Mvc;
using Task_52.Models;

namespace Task_52.Controllers
{
    public class UsersController : Controller
    {
        private MyDbContext _context;

        public UsersController()
        {
            _context = new MyDbContext();
        }

        public ActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }
    }
}