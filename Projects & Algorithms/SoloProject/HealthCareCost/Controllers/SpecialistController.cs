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
    public class SpecialistController : Controller
    {
        private Context _context;

        private User loggedInUser
        {
            get { return _context.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId")); }
        }

        public SpecialistController(Context context)
        {
            _context = context;
        }

        [HttpGet("specialists")]
        public IActionResult Specialists()
        {
            ViewBag.User = loggedInUser;
            var specialists = _context.Specialists.ToList();
            return View(specialists);
        }

        [HttpGet("specialist/{specialistId}")]
        public IActionResult ShowSpecialist(int specialistId)
        {
            ViewBag.User = loggedInUser;
            var specialist = _context.Specialists.FirstOrDefault(s => s.SpecialistId == specialistId);
            var specializations = _context.SpecialistSpecializations
                .Include(s => s.Specialization)
                .Where(s => s.SpecialistId == specialist.SpecialistId)
                .ToList();
            ViewBag.SpecialistSpecializations = specializations;
            return View(specialist);
        }
        
    }
}
