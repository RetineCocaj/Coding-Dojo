using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ECommerce.Models;

namespace ECommerce.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.AllCustomers = _context.Customers.ToList().Take(3);
            ViewBag.AllProducts = _context.Products.ToList().Take(5);
            ViewBag.AllOrders = _context.Orders.OrderByDescending(o => o.CreatedAt).ToList().Take(3);
            return View();
        }
        [HttpGet("settings")]
        public IActionResult Settings()
        {
            return View();
        }

        [HttpGet("products")]
        public IActionResult Products()
        {
            ViewBag.AllProducts = _context.Products.ToList();
            return View();
        }

        [HttpPost("AddProduct")]
        public IActionResult AddProduct(Product newProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(newProduct);
                _context.SaveChanges();
                return RedirectToAction("Products");
            }
            return View("Customers");
        }

        [HttpGet("customers")]
        public IActionResult Customers()
        {
            ViewBag.AllCustomers = _context.Customers.ToList();
            return View();
        }

        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer(Customer newCustomer)
        {
            if (!_context.Customers.Any(c => c.Name == newCustomer.Name))
            {
                if (ModelState.IsValid)
                {
                    _context.Customers.Add(newCustomer);
                    _context.SaveChanges();
                    return RedirectToAction("Customers");
                }
                return RedirectToAction("Customers");
            }
            TempData["ErrorMessage"] = "This customer already exists!";
            return RedirectToAction("Customers");
        }

        [HttpGet("RemoveCustomer/{customerId}")]
        public IActionResult RemoveCustomer(int customerId)
        {
            Customer toDelete = _context.Customers.FirstOrDefault(c => c.CustomerId == customerId);
            if (toDelete == null)
                return RedirectToAction("Customers");

            _context.Customers.Remove(toDelete);
            _context.SaveChanges();
            return RedirectToAction("Customers");
        }

        [HttpGet("orders")]
        public IActionResult Orders()
        {
            ViewBag.AllCustomers = _context.Customers.ToList();
            ViewBag.AllProducts = _context.Products.ToList();
            ViewBag.AllOrders = _context.Orders.OrderByDescending(o => o.CreatedAt).ToList();
            return View();
        }

        [HttpPost("AddOrder")]
        public IActionResult AddOrder(Order newOrder)
        {
            newOrder.Customer = _context.Customers.FirstOrDefault(c => c.CustomerId == newOrder.CustomerId);
            newOrder.Product = _context.Products.FirstOrDefault(p => p.ProductId == newOrder.ProductId);
            if (ModelState.IsValid)
            {
                var stock = newOrder.Product.Quantity;
                if (stock - newOrder.Quantity > 0)
                {
                    _context.Products.FirstOrDefault(p => p.ProductId == newOrder.ProductId).Quantity -= newOrder.Quantity;
                    _context.Orders.Add(newOrder);
                    _context.SaveChanges();
                    return RedirectToAction("Orders");
                }
                TempData["ErrorMessage"] = "The stock for the \"" + newOrder.Product.Name + "\" is only " + stock;
                return RedirectToAction("Orders");
            }
            TempData["ErrorMessage"] = "You should fill all fields!";
            return RedirectToAction("Orders");
        }
    }
}
