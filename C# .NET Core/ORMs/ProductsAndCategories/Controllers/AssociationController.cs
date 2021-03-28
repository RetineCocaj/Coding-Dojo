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
    public class AssociationController : Controller
    {
        private Context _context;
        public AssociationController(Context context)
        {
            _context = context;
        }

        [HttpPost("AddProduct")]
        public IActionResult AddProduct(Association association)
        {
            _context.Associations.Add(association);
            _context.SaveChanges();
            return RedirectToAction("Products", "Product");
        }

        [HttpPost("AddCategory")]
        public IActionResult AddCategory(Association association)
        {
            _context.Associations.Add(association);
            _context.SaveChanges();
            return RedirectToAction("Categories", "Category");
        }
    }
}
