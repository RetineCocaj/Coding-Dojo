using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        private string sessionPasscode
        {
            get { return HttpContext.Session.GetString("passcode"); }
            set { HttpContext.Session.SetString("passcode", value); }
        }
        private int? sessionTimes
        {
            get { return HttpContext.Session.GetInt32("times"); }
            set { HttpContext.Session.SetInt32("times", (int)value); }
        }
        public string GeneratePasscode(int size)
        {
            Random rand = new Random();
            string values = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string result = "";
            for(var i = 0; i < size; i++)
                result += values[rand.Next(values.Length)];
            return result;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            if(sessionPasscode == null) sessionPasscode = "Generate a Passcode!";
            if(sessionTimes == null) sessionTimes = 0;

            ViewBag.Passcode = sessionPasscode;
            ViewBag.Times = sessionTimes;

            return View();
        }

        [HttpGet("new")]
        public IActionResult NewPasscode()
        {
            string newPasscode = GeneratePasscode(14);
            int? currentTimes = sessionTimes;

            sessionPasscode = newPasscode;
            sessionTimes = ++currentTimes;
            //return Json(new{ passcode = newPasscode, times = currentTimes });
            return RedirectToAction("Index");
        }
    }
}
