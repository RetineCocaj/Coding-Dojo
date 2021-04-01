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
using TheWall.Models;

namespace TheWall.Controllers
{
    public class WallController : Controller
    {
        private Context _context;

        private User loggedIn
        {
            get { return _context.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId")); }
        }

        private int MessageId
        {
            get; set;
        }

        public WallController(Context context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            if(loggedIn == null)
                return RedirectToAction("Index", "Home");

            ViewBag.username = loggedIn.FirstName;
            ViewBag.messages = _context.Messages
                .Include(m => m.User)
                .OrderByDescending(m => m.CreatedAt)
                .ToList();

            ViewBag.comments = _context.Comments
                .Include(c => c.Message)
                .Include(u => u.User)
                .OrderBy(c => c.CreatedAt)
                .ToList();
            
            ViewBag.loggedInUserMessages = _context.Messages
                .Include(m => m.User)
                .Where(m => m.UserId == loggedIn.UserId)
                .ToList();

            return View();
        }

        [HttpPost("PostMessage")]
        public IActionResult PostMessage(Message newMessage)
        {
            if(ModelState.IsValid)
            {
                newMessage.UserId = loggedIn.UserId;
                _context.Messages.Add(newMessage);
                _context.SaveChanges();
                MessageId = newMessage.MessageId;
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        [HttpPost("PostComment/{messageId}")]
        public IActionResult PostComment(Comment newComment, int messageId)
        {
            if(ModelState.IsValid)
            {
                newComment.UserId = loggedIn.UserId;
                newComment.MessageId = messageId;
                _context.Comments.Add(newComment);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        [HttpPost("DeleteMessage/{messageId}")]
        public IActionResult DeleteMessage(int messageId)
        {
            var message = _context.Messages.FirstOrDefault(m => m.MessageId == messageId);
            _context.Messages.Remove(message);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
