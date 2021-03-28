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
    [Route("products")]
    public class ProductController : Controller
    {
        private Context _context;
        public ProductController(Context context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Products()
        {
            ViewBag.ExistingProducts = _context.Products;
            return View("Products");
        }

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(Product newProduct)
        {
            if(ModelState.IsValid)
            {
                _context.Products.Add(newProduct);
                _context.SaveChanges();
                return RedirectToAction("Products");
            }
            return View("Products");
        }
        [HttpGet("{productId}")]
        public IActionResult ShowProduct(int productId)
        {
            var product = _context.Products
                .Include(p => p.Associations)
                    .ThenInclude(a => a.Category)
                .FirstOrDefault(p => p.ProductId == productId);
            
            ViewBag.categories = _context.Categories
                .Include(c => c.Associations)
                .Where(c => c.Associations.All(a => a.ProductId != productId))
                .ToList();

            return View(product);
        }

    }
}
