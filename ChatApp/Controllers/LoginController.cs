using Microsoft.AspNetCore.Mvc;
using ChatApp.Models;
using System.Diagnostics;

namespace ChatApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Authenticate(string username, string password)
        {
            if (IsValidUser(username, password))
            {
                if (username == "user1")
                {
                    return Redirect("https://localhost:6968");
                }
                else if (username == "user2")
                {
                    return Redirect("https://localhost:6969");
                }
            }

            ViewBag.ErrorMessage = "Invalid username or password";
            return View("Login");
        }

        private bool IsValidUser(string username, string password)
        {
            // Validate credentials against predefined values
            // This could be replaced with a more secure authentication mechanism
            return (username == "user1" && password == "password1") ||
                   (username == "user2" && password == "password2");
        }

    }
}
