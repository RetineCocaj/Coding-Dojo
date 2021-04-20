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
    public class MedicalServiceController : Controller
    {
        private Context _context;

        private User loggedInUser
        {
            get { return _context.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId")); }
        }

        public MedicalServiceController(Context context)
        {
            _context = context;
        }

        [HttpGet("medicalservices")]
        public IActionResult MedicalServices()
        {
            ViewBag.User = loggedInUser;
            var allMedicalServices = _context.MedicalServices
                .Include(m => m.HospitalMedicalProcedure).ThenInclude(h => h.Hospital)
                .Include(m => m.HospitalMedicalProcedure).ThenInclude(h => h.MedicalProcedure)
                .Include(m => m.HospitalSpecialist).ThenInclude(h => h.Hospital)
                .Include(m => m.HospitalSpecialist).ThenInclude(h => h.Specialist)
                .Include(m => m.SpecialistSpecialization).ThenInclude(h => h.Specialization)
                .Include(m => m.SpecialistSpecialization).ThenInclude(h => h.Specialist)
                .ToList();
            ViewBag.AllMedicalProcedures = _context.MedicalProcedures.ToList();
            return View(allMedicalServices);
        }

        [HttpGet("createmedicalservice")]
        public IActionResult MedicalServiceForm()
        {
            if (loggedInUser == null)
                return RedirectToAction("Index", "Home");

            ViewBag.User = loggedInUser;
            ViewBag.AllMedicalProcedures = _context.MedicalProcedures.ToList();
            ViewBag.AllHospitals = _context.Hospitals.ToList();
            ViewBag.AllSpecialists = _context.Specialists.ToList();
            ViewBag.AllSpecializations = _context.Specializations.ToList();

            return View();
        }

        [HttpPost("createmedicalservice")]
        public IActionResult CreateMedicalService(MedicalService service)
        {
            if (loggedInUser == null)
                return RedirectToAction("Index", "Home");

            ViewBag.User = loggedInUser;
            if (ModelState.IsValid)
            {
                service.HospitalMedicalProcedure.Hospital = _context.Hospitals
                    .Include(s => s.MedicalProcedures)
                    .Include(s => s.Specialists)
                    .FirstOrDefault(h => h.HospitalId == service.HospitalMedicalProcedure.HospitalId);
                service.HospitalMedicalProcedure.MedicalProcedure = _context.MedicalProcedures
                    .Include(h => h.Hospitals)
                    .FirstOrDefault(m => m.MedicalProcedureId == service.HospitalMedicalProcedure.MedicalProcedureId);
                service.HospitalSpecialist.Specialist = _context.Specialists
                    .Include(h => h.Hospitals)
                    .Include(h => h.Specializations)
                    .FirstOrDefault(s => s.SpecialistId == service.HospitalSpecialist.SpecialistId);
                service.SpecialistSpecialization.Specialization = _context.Specializations
                    .Include(h => h.Specialists)
                    .FirstOrDefault(s => s.SpecializationId == service.SpecialistSpecialization.SpecializationId);

                service.HospitalSpecialist.Hospital = service.HospitalMedicalProcedure.Hospital;
                service.HospitalSpecialist.HospitalId = service.HospitalMedicalProcedure.HospitalId;

                service.SpecialistSpecialization.Specialist = service.HospitalSpecialist.Specialist;
                service.SpecialistSpecialization.SpecialistId = service.HospitalSpecialist.SpecialistId;

                if(!_context.HospitalMedicalProcedures.Any(s => s.Hospital == service.HospitalMedicalProcedure.Hospital 
                && s.MedicalProcedure == service.HospitalMedicalProcedure.MedicalProcedure))
                {
                    _context.HospitalMedicalProcedures.Add(service.HospitalMedicalProcedure);
                }
                else{
                    var hospitalMedicalProcedure = _context.HospitalMedicalProcedures.AsNoTracking()
                        .FirstOrDefault(s => s.Hospital == service.HospitalMedicalProcedure.Hospital 
                        && s.MedicalProcedure == service.HospitalMedicalProcedure.MedicalProcedure);
                    service.HospitalMedicalProcedure.HospitalMedicalProcedureId = hospitalMedicalProcedure.HospitalMedicalProcedureId;
                }

                if(!_context.HospitalSpecialist.Any(s => s.Hospital == service.HospitalSpecialist.Hospital 
                && s.Specialist == service.HospitalSpecialist.Specialist))
                {
                    _context.HospitalSpecialist.Add(service.HospitalSpecialist);
                }
                else{
                    var hospitalSpecialist = _context.HospitalSpecialist
                        .FirstOrDefault(s => s.Hospital == service.HospitalSpecialist.Hospital 
                        && s.Specialist == service.HospitalSpecialist.Specialist);
                    service.HospitalSpecialist.HospitalSpecialistId = hospitalSpecialist.HospitalSpecialistId;
                }

                if(!_context.SpecialistSpecializations.Any(s => s.Specialist == service.SpecialistSpecialization.Specialist 
                && s.Specialization == service.SpecialistSpecialization.Specialization))
                {
                    _context.SpecialistSpecializations.Add(service.SpecialistSpecialization);
                }
                else{
                    var specialistSpecialization = _context.SpecialistSpecializations
                        .FirstOrDefault(s => s.Specialist == service.SpecialistSpecialization.Specialist 
                        && s.Specialization == service.SpecialistSpecialization.Specialization);
                    service.SpecialistSpecialization.SpecialistSpecializationId = specialistSpecialization.SpecialistSpecializationId;
                }
                
                _context.SaveChanges();

                if(_context.MedicalServices.Any(s => s.HospitalMedicalProcedureId == service.HospitalMedicalProcedureId 
                    && s.HospitalSpecialistId == service.HospitalSpecialistId
                    && s.SpecialistSpecializationId == service.SpecialistSpecializationId)) 
                {
                    TempData["Error"] = "This medical service with Hospital: "+ service.HospitalMedicalProcedure.Hospital.Name 
                    + ", Specialist: " + service.HospitalSpecialist.Specialist.FirstName + " " + service.HospitalSpecialist.Specialist.LastName
                    +", Specialization: "+ service.SpecialistSpecialization.Specialization.Name 
                    +", Medical Procedure: "+ service.HospitalMedicalProcedure.MedicalProcedure.Name 
                    +" already exists.";
                    return RedirectToAction("MedicalServiceForm");
                }    
                
                _context.MedicalServices.Add(service);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            TempData["Error"] = "All fields are required!";
            return RedirectToAction("MedicalServiceForm");
        }


        [HttpPost("addmedicalprocedure")]
        public IActionResult AddMedicalProcedure(MedicalProcedure procedure)
        {
            if (loggedInUser == null)
                return RedirectToAction("Index", "Home");

            ViewBag.User = loggedInUser;
            if (ModelState.IsValid)
            {
                var allProcedures = _context.MedicalProcedures.ToList();
                foreach (var medprocedure in allProcedures)
                {
                    if (medprocedure.Name == procedure.Name)
                    {
                        var errors = new Dictionary<string, string>();
                        errors.Add("errorName", "This Medical Procedure is already registered");
                        return Json(errors);
                    }
                }
                _context.MedicalProcedures.Add(procedure);
                _context.SaveChanges();
                return Ok(procedure);
            }
            return Json(new
            {
                Message = ModelState.ToDictionary(kvp => kvp.Key,
                kvp => kvp.Value.Errors
                                .Select(e => e.ErrorMessage).ToArray())
                                .Where(m => m.Value.Any())
            });
        }

        [HttpPost("addhospital")]
        public IActionResult AddHospital(Hospital hospital)
        {
            if (loggedInUser == null)
                return RedirectToAction("Index", "Home");

            ViewBag.User = loggedInUser;
            if (ModelState.IsValid)
            {
                var allHospitals = _context.Hospitals.ToList();
                foreach (var s in allHospitals)
                {
                    if (s.Name == hospital.Name && s.Address == hospital.Address)
                    {
                        var errors = new Dictionary<string, string>();
                        errors.Add("errorHospital", "This Hospital in this Address is already registered");
                        return Json(errors);
                    }
                }
                _context.Hospitals.Add(hospital);
                _context.SaveChanges();
                return Ok(hospital);
            }
            return Json(new
            {
                Message = ModelState.ToDictionary(kvp => kvp.Key,
                kvp => kvp.Value.Errors
                                .Select(e => e.ErrorMessage).ToArray())
                                .Where(m => m.Value.Any())
            });
        }

        [HttpPost("addspecialist")]
        public IActionResult AddSpecialist(Specialist specialist)
        {
            if (loggedInUser == null)
                return RedirectToAction("Index", "Home");

            ViewBag.User = loggedInUser;
            if (ModelState.IsValid)
            {
                var allSpecialists = _context.Specialists.ToList();
                foreach (var s in allSpecialists)
                {
                    if (s.FirstName == specialist.FirstName && s.LastName == specialist.LastName)
                    {
                        if(s.Email == specialist.Email || s.Telephone == specialist.Telephone)
                        {
                            var errors = new Dictionary<string, string>();
                            errors.Add("errorSpecialist", "This Specialist is already registered");
                            return Json(errors);
                        }
                    }
                }
                _context.Specialists.Add(specialist);
                _context.SaveChanges();
                return Ok(specialist);
            }
            return Json(new
            {
                Message = ModelState.ToDictionary(kvp => kvp.Key,
                kvp => kvp.Value.Errors
                                .Select(e => e.ErrorMessage).ToArray())
                                .Where(m => m.Value.Any())
            });
        }

        [HttpPost("addspecialization")]
        public IActionResult AddSpecialization(Specialization specialization)
        {
            if (loggedInUser == null)
                return RedirectToAction("Index", "Home");

            ViewBag.User = loggedInUser;
            if (ModelState.IsValid)
            {
                var allSpecialization = _context.Specializations.ToList();
                foreach (var s in allSpecialization)
                {
                    if (s.Name == specialization.Name)
                    {
                        var errors = new Dictionary<string, string>();
                        errors.Add("errorName", "This Specialization is already registered");
                        return Json(errors);
                    }
                }
                _context.Specializations.Add(specialization);
                _context.SaveChanges();
                return Ok(specialization);
            }
            return Json(new
            {
                Message = ModelState.ToDictionary(kvp => kvp.Key,
                kvp => kvp.Value.Errors
                                .Select(e => e.ErrorMessage).ToArray())
                                .Where(m => m.Value.Any())
            });
        }
    }
}
