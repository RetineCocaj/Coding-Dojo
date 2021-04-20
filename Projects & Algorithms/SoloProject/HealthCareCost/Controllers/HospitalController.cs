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
using Microsoft.EntityFrameworkCore;

namespace HealthCareCost.Controllers
{
    public class HospitalController : Controller
    {
        private Context _context;

        private User loggedInUser
        {
            get { return _context.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId")); }
        }

        public HospitalController(Context context)
        {
            _context = context;
        }

        [HttpGet("hospitals")]
        public IActionResult Hospitals()
        {
            ViewBag.User = loggedInUser;
            ViewBag.AllHospitals = _context.Hospitals.ToList();
            return View();
        }

        [HttpGet("hospital/{hospitalId}")]
        public IActionResult ShowHospital(int hospitalId)
        {
            ViewBag.User = loggedInUser;
            var hospital = _context.Hospitals.FirstOrDefault(s => s.HospitalId == hospitalId);
            var medicalProcedures = _context.HospitalMedicalProcedures
                .Include(m => m.MedicalProcedure)
                .Where(s => s.HospitalId == hospital.HospitalId).ToList();
            ViewBag.HospitalMedicalProcedures = medicalProcedures;
            return View(hospital);
        }
        
    }
}
