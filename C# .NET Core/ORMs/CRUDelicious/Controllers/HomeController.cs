using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private readonly DishesContext _context;

        public HomeController(DishesContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var list = _context.Dishes
                .OrderByDescending(d => d.CreatedAt);
            return View(list);
        }

        [HttpGet("new")]
        public IActionResult New(){ return View("New"); }

        [HttpGet("{dishId}")]
        public IActionResult Show(int dishId)
        {
            Dishes model = _context.Dishes.FirstOrDefault(d => d.DishId == dishId);
            if(model == null)
                return RedirectToAction("Index");
            return View("Show",  model);
        }

        [HttpGet("edit/{dishId}")]
        public IActionResult Edit(int dishId)
        {
            Dishes model = _context.Dishes.FirstOrDefault(d => d.DishId == dishId);
            if(model == null)
                return RedirectToAction("Index");
            return View("Edit", model);
        }

        [HttpPost("update/{dishId}")]
        public IActionResult Update(Dishes dish, int dishId)
        {
            Dishes toUpdate = _context.Dishes.FirstOrDefault(d => d.DishId == dishId);
            if(ModelState.IsValid)
            {
                toUpdate.Name = dish.Name;
                toUpdate.Chef = dish.Chef;
                toUpdate.Tastiness = dish.Tastiness;
                toUpdate.Calories = dish.Calories;
                toUpdate.Description = dish.Description;
                toUpdate.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Edit", dish);
        }
        
        [HttpGet("delete/{dishId}")]
        public IActionResult Delete(int dishId)
        {
            Dishes toDelete = _context.Dishes.FirstOrDefault(d => d.DishId == dishId);
            if(toDelete == null)
                return RedirectToAction("Index");
            _context.Dishes.Remove(toDelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost("create")]
        public IActionResult Create(Dishes newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Dishes.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("New");
        }
    }
}
