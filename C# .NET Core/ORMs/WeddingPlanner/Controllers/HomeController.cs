using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Registration")]
        public IActionResult Registration(User user)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use");
                    return View("Index");
                }
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                user.Password = hasher.HashPassword(user, user.Password);

                var newUser = _context.Users.Add(user).Entity;
                _context.SaveChanges();

                HttpContext.Session.SetInt32("userId", newUser.UserId);
                return RedirectToAction("Index", "Wedding");
            }
            return View("Index");
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginUser user)
        {
            if(ModelState.IsValid)
            {
                User login = _context.Users.FirstOrDefault(u => u.Email == user.EmailAttempt);
                if(login == null)
                {
                    ModelState.AddModelError("EmailAttempt", "Invalid Email");
                    return View("Index");
                }

                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(user, login.Password, user.PasswordAttempt);
                if(result == PasswordVerificationResult.Failed)
                {
                    ModelState.AddModelError("EmailAttempt", "Invalid Password");
                    return View("Index");
                }

                HttpContext.Session.SetInt32("userId", login.UserId);
                return RedirectToAction("Index", "Wedding");
            }
            return View("Index");
        }

        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
