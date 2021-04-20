using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HealthCareCost.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HealthCareCost.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;

        private User loggedInUser
        {
            get { return _context.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId")); }
        }

        public HomeController(Context context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.User = loggedInUser;
            ViewBag.AllSpecializations = _context.Specializations.ToList();
            return View();
        }
        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("Register")]
        public IActionResult Registration(User user)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use");
                    return View("Register");
                }
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                user.Password = hasher.HashPassword(user, user.Password);

                var newUser = _context.Users.Add(user).Entity;
                _context.SaveChanges();

                if (newUser.UserId == 1) newUser.Role = "admin";
                else newUser.Role = "user";
                _context.SaveChanges();

                HttpContext.Session.SetInt32("userId", newUser.UserId);
                return RedirectToAction("Index");
            }
            return View("Register");
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                User login = _context.Users.FirstOrDefault(u => u.Email == user.EmailAttempt);
                if (login == null)
                {
                    ModelState.AddModelError("EmailAttempt", "Invalid Email");
                    return View("Login");
                }

                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(user, login.Password, user.PasswordAttempt);
                if (result == PasswordVerificationResult.Failed)
                {
                    ModelState.AddModelError("EmailAttempt", "Invalid Password");
                    return View("Login");
                }

                HttpContext.Session.SetInt32("userId", login.UserId);
                return RedirectToAction("Index");
            }
            return View("Login");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }    

        [HttpGet("showprofile/{userId}")]
        public IActionResult ShowProfile(int userId)
        {
            if (loggedInUser == null)
                return RedirectToAction("Index", "Home");

            ViewBag.User = loggedInUser;
            var userProfile = _context.Users.FirstOrDefault(u => u.UserId == userId);
            return View(userProfile);
        }

        [HttpGet("users")]
        public IActionResult AllUsers()
        {
            if (loggedInUser == null)
                return RedirectToAction("Index", "Home");

            ViewBag.User = loggedInUser;
            var allUsers = _context.Users.ToList();
            return View(allUsers);
        }

        [HttpGet("makeadmin/{userId}")]
        public IActionResult MakeAdmin(int userId)
        {
            if (loggedInUser == null)
                return RedirectToAction("Index", "Home");

            ViewBag.User = loggedInUser;
            _context.Users.FirstOrDefault(u => u.UserId == userId).Role = "admin";
            _context.SaveChanges();
            return RedirectToAction("AllUsers");
        }

        [HttpGet("removeadmin/{userId}")]
        public IActionResult RemoveAdmin(int userId)
        {
            if (loggedInUser == null)
                return RedirectToAction("Index", "Home");

            ViewBag.User = loggedInUser;
            _context.Users.FirstOrDefault(u => u.UserId == userId).Role = "user";
            _context.SaveChanges();
            return RedirectToAction("AllUsers");
        }


        public IActionResult Privacy()
        {
            ViewBag.User = loggedInUser;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            ViewBag.User = loggedInUser;
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
