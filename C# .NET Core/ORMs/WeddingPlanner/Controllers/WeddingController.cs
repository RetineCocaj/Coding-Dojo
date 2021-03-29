using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    [Route("weddings")]
    public class WeddingController : Controller
    {
        private Context _context;
        private User loggedIn
        {
            get { return _context.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId")); }
        } 

        public WeddingController(Context context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            if(loggedIn == null)
                return RedirectToAction("Index", "Home");

            var weddings = _context.Weddings
                .Include(w => w.Responses)
                .OrderByDescending(w => w.Date);

            ViewBag.UserId = loggedIn.UserId;
            var responsed = weddings.Where(w => w.Responses.Any(r => r.UserId == 1));
            return View(weddings.ToList());
        }

        [HttpGet("{weddingId}")]
        public IActionResult ShowWedding(int weddingId)
        {
            if(loggedIn == null)
                return RedirectToAction("Index", "Home");
            
            Wedding wedding = _context.Weddings
                .Include(w => w.Responses)
                    .ThenInclude(r => r.Guest)
                .FirstOrDefault(w => w.WeddingId == weddingId);

            return View(wedding);
        }

        [HttpGet("NewWedding")]
        public IActionResult NewWedding()
        {
            if(loggedIn == null)
                return RedirectToAction("Index", "Home");

            ViewBag.UserId = loggedIn.UserId;
            return View("NewWedding");
        }

        [HttpPost("CreateWedding")]
        public IActionResult CreateWedding(Wedding newWedding)
        {
            if(ModelState.IsValid)
            {
                newWedding.UserId = loggedIn.UserId;
                _context.Weddings.Add(newWedding);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = loggedIn.UserId;
            return View("NewWedding");
        }

        [HttpGet("remove/{weddingId}")]
        public IActionResult Remove(int weddingId)
        {
            if(loggedIn == null)
                return RedirectToAction("Index", "Home");

            Wedding delete = _context.Weddings.FirstOrDefault(w => w.WeddingId == weddingId && w.UserId == loggedIn.UserId);
            
            if(delete == null)
                return RedirectToAction("Index");
            
            _context.Weddings.Remove(delete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
