using Extra_task.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace Extra_task.Controllers
{
    public class UserController : Controller
    {
        private readonly MyDbContext _context;

        public UserController(MyDbContext context)
        {
            _context = context;
        }
        // GET: UserController/Create
        public ActionResult SignUp()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        public ActionResult SignUp(User user, string Rpassword)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(user);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Login));
                }
                return View(user);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        // POST: UserController/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            var existingUser = _context.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);

            if (existingUser != null)
            {
                HttpContext.Session.SetString("UserName", existingUser.Name);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid email or password.");
                return View(user);
            }
        }

    }
}
