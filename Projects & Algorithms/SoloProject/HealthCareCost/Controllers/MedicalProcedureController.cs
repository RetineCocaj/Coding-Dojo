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
    public class MedicalProcedureController : Controller
    {
        private Context _context;

        private User loggedInUser
        {
            get { return _context.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId")); }
        }

        public MedicalProcedureController(Context context)
        {
            _context = context;
        }

        [HttpGet("medicalprocedures")]
        public IActionResult MedicalProcedures()
        {
            ViewBag.User = loggedInUser;
            ViewBag.AllMedicalProcedures = _context.MedicalProcedures.ToList();
            return View();
        }

        [HttpGet("medicalprocedure/{medicalProcedureId}")]
        public IActionResult ShowMedicalProcedure(int medicalProcedureId)
        {
            ViewBag.User = loggedInUser;
            var medicalProcedure = _context.MedicalProcedures.FirstOrDefault(s => s.MedicalProcedureId == medicalProcedureId);
            ViewBag.Hospitals = _context.HospitalMedicalProcedures
                .Include(h => h.Hospital)
                .Where(h => h.MedicalProcedureId == medicalProcedureId)
                .ToList();
            return View(medicalProcedure);
        }
        
    }
}
