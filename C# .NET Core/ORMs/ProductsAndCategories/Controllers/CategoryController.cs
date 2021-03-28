using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProductsAndCategories.Models;

namespace ProductsAndCategories.Controllers
{
    [Route("categories")]
    public class CategoryController : Controller
    {
        private Context _context;
        public CategoryController(Context context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Categories()
        {
            ViewBag.ExistingCategories = _context.Categories;
            return View("Categories");
        }

        [HttpPost("CreateCategory")]
        public IActionResult CreateCategory(Category newCategory)
        {
            if(ModelState.IsValid)
            {
                _context.Categories.Add(newCategory);
                _context.SaveChanges();
                return RedirectToAction("Categories");
            }
            return View("Categories");
        }

        [HttpGet("{categoryId}")]
        public IActionResult ShowCategory(int categoryId)
        {
            var category = _context.Categories
                .Include(c => c.Associations)
                    .ThenInclude(a => a.Category)
                .FirstOrDefault(c => c.CategoryId == categoryId);
            
            ViewBag.products = _context.Products
                .Include(c => c.Associations)
                .Where(c => c.Associations.All(a => a.CategoryId != categoryId))
                .ToList();

            return View(category);
        }

        [HttpPost("AddCategory")]
        public IActionResult AddCategory(Category newCategory)
        {
            if(ModelState.IsValid)
            {
                _context.Categories.Add(newCategory);
                _context.SaveChanges();
                return RedirectToAction("Categories");
            }
            ViewBag.AllCategories = _context.Categories;
            return View("Categories");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
