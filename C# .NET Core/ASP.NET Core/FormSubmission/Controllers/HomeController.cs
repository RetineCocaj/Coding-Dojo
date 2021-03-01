using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index(){
            return View("Index");
        }

        [HttpPost("AddUser")]
        public IActionResult AddUser(User user){
            if(ModelState.IsValid){ return RedirectToAction("Success"); }
            return View("Index");
        }

        [HttpGet("success")]
        public ViewResult Success()
        {
            return View();
        }
    }
}
