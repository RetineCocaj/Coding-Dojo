using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BankAccounts.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;
        private bool inSession
        {
            get { return HttpContext.Session.GetInt32("userId") != null; }
        }
        private User loggedInUser
        {
            get
            {
                return _context.Users.Include(u => u.Transactions)
                    .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId"));
            }
        }

        public HomeController(Context context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult RegisterUser(User user){
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(o => o.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use");
                    return View("Index");
                }
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                user.Password = hasher.HashPassword(user, user.Password);
                var newUser = _context.Users.Add(user).Entity;
                _context.SaveChanges();
                HttpContext.Session.SetInt32("userId", newUser.UserId);
                return RedirectToAction("Account");
            }
            return View("Register");
        }

        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost("Login")]
        public IActionResult LoginUser(LoginUser user)
        {
            if(ModelState.IsValid)
            {
                User login = _context.Users.FirstOrDefault(u => u.Email == user.EmailAttempt);
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
                return RedirectToAction("Account");
            }
            return View("Login");
        }

        [HttpGet("Account")]
        public IActionResult Account(){

            if(!inSession)
                return RedirectToAction("Login", "Home");

            var user = loggedInUser;
            ViewBag.User = user;
            ViewBag.Transactions = _context.Transactions
                .OrderByDescending(t => t.CreatedAt)
                .Where(t => t.UserId == loggedInUser.UserId);
            return View("Account");
        }

        [HttpPost("money")]
        public IActionResult Money(Transaction trans)
        {
            if(ModelState.IsValid)
            {
                _context.Transactions.Add(trans);
                _context.SaveChanges();
                return RedirectToAction("Account");
            }
            var user = loggedInUser;
            ViewBag.User = user;
            ViewBag.Transactions = _context.Transactions
                .OrderByDescending(t => t.CreatedAt)
                .Where(t => t.UserId == loggedInUser.UserId);
            return View("Account");
        }
    }
}
