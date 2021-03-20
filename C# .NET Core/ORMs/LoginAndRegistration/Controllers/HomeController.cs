using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginAndRegistration.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LoginAndRegistration.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult RegisterUser(RegisterUser user)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Register");
                }
                PasswordHasher<RegisterUser> hasher = new PasswordHasher<RegisterUser>();
                user.Password = hasher.HashPassword(user, user.Password);

                var newUser = _context.Users.Add(user).Entity;
                _context.SaveChanges();

                HttpContext.Session.SetInt32("userId", newUser.UserId);
                return RedirectToAction("Success");
            }
            return View("Register");
        }


        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser user)
        {
            if(ModelState.IsValid)
            {
                RegisterUser login = _context.Users.FirstOrDefault(u => u.Email == user.EmailAttempt);
                if(login == null)
                {
                    ModelState.AddModelError("EmailAttempt", "Invalid Email/Password");
                    return View("Login");
                }
                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(user, login.Password, user.PasswordAttempt);
                if(result == PasswordVerificationResult.Failed)
                {
                    ModelState.AddModelError("EmailAttempt", "Invalid Email/Password");
                    return View("Login");
                }
                
                HttpContext.Session.SetInt32("userId", login.UserId);
                return RedirectToAction("Success");
            }
            return View("Login");
        }

        [HttpGet("logout")]
        public RedirectToActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Register");
        }
        [HttpGet("success")]
        public IActionResult Success()
        {
            if(HttpContext.Session.GetInt32("userId") == null)
                return RedirectToAction("Register");
            return View();
        }
    }
}
