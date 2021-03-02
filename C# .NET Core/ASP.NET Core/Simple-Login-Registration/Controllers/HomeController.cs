using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Simple_Login_Registration.Models;

namespace Simple_Login_Registration.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("register")]
        public IActionResult Registration(RegUser user)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Index");
        }
        [HttpPost("login")]
        public IActionResult Login(LogUser user)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Index");
        }
        [HttpGet("success")]
        public IActionResult Success()
        {
            return View("Success");
        }
    }
}
