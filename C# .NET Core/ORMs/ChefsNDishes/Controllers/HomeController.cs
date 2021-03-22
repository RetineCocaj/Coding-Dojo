using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Chefs = _context.Chefs
                .Include(chef => chef.Dishes)
                .ToList();
            return View();
        }

        [HttpGet("new")]
        public IActionResult AddChef()
        {
            return View("AddChef");
        }
        [HttpPost("chefAdded")]
        public IActionResult ChefAdded(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                _context.Chefs.Add(newChef);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("AddChef");
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            ViewBag.Dishes = _context.Dishes
                .Include(dish => dish.Chef)
                .ToList();
            return View("Dishes");
        }

        [HttpGet("dishes/new")]
        public IActionResult AddDish()
        {
            ViewBag.Chefs = _context.Chefs.ToList();
            return View("AddDish");
        }

        [HttpPost("dishAdded")]
        public IActionResult DishAdded(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Dishes.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Dishes");
            }
            return View("AddDish");
        }
    }
}
