using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace WeddingPlanner.Controllers
{
    [Route("response")]
    public class ResponseController : Controller
    {
        private User loggedIn
        {
            get { return _context.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId")); }
        }
        private Context _context;
        public ResponseController(Context context)
        {
            _context = context;
        }

        [HttpGet("rsvp/{weddingId}/{status}")]
        public IActionResult RSVP(int weddingId, string status)
        {
            if(loggedIn == null)
                return RedirectToAction("Index", "Home");

            if(!_context.Weddings.Any(w => w.WeddingId == weddingId))
                return RedirectToAction("Index", "Wedding");

            if(status == "add") AddRSVP(weddingId);
            else RemoveRSVP(weddingId);

            return RedirectToAction("Index", "Wedding");
        }
        private void AddRSVP(int weddingId)
        {
            Response newResponse = new Response()
            {
                WeddingId = weddingId,
                UserId = loggedIn.UserId
            };

            _context.Responses.Add(newResponse);
            _context.SaveChanges();
        }

        private void RemoveRSVP(int weddingId)
        {
            Response rsvp = _context.Responses.FirstOrDefault(r => r.UserId == loggedIn.UserId && r.WeddingId == weddingId);

            if(rsvp != null)
            {
                _context.Responses.Remove(rsvp);
                _context.SaveChanges();
            }
        }
    }
}