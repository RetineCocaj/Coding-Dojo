using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DojoSurveyWithValidation.Models;

namespace DojoSurveyWithValidation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index(){
            return View("Index");
        }

        [HttpPost("StoreSurvey")]
        public IActionResult StoreSurvey(Survey result){
            if(ModelState.IsValid){ return View("Result", result); }
            return View("Index");
        }
    }
}
