using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ViewModelsFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        public List<User> GenerateUsers()
        {
            return new List<User>()
            {
                new User(){ FirstName="Chandler", LastName="Bing"},
                new User(){ FirstName="Phoebe", LastName="Buffay"},
                new User(){ FirstName="Joey", LastName="Tribbiani"},
                new User(){ FirstName="Monica", LastName="Geller"},
                new User(){ FirstName="Rachel", LastName="Green"},
                new User(){ FirstName="Ross", LastName="Geller"}
            };
        }
        // GET: /Home/
        [HttpGet("")]
        public IActionResult Index()
        {
            string stringModel = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.";

            return View("Index", stringModel);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]{1,2,3,10,43,5};
            return View(numbers);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            var users = GenerateUsers();
            return View(users);
        }

        [HttpGet("user")]
        public IActionResult RandUser()
        {
            Random rand = new Random();
            var users = GenerateUsers();

            var randUser = users[rand.Next(users.Count)];
            return View(randUser);
        }
    }
}