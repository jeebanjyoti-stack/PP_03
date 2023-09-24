using Microsoft.AspNetCore.Mvc;
using WebAppBank.Models;

namespace WebAppBank.Controllers
{
    public class AccountController : Controller
    {
        // Simulated user data (replace with your actual authentication logic)
        private readonly User _user = new User { Id = 1, Username = "sam", Password = "sam@1234" };
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User model)
        {
            if (ModelState.IsValid && model.Username == _user.Username && model.Password== _user.Password)
            {
                // Successful login, redirect to dashboard 
                return RedirectToAction("Index", "Dashboard");
            }

            // Invalid login, show error message 
            ModelState.AddModelError("", "Invalid username or password");
            return View(model);
        }
    }
}
