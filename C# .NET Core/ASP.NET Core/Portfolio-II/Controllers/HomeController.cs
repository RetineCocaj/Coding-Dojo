using Microsoft.AspNetCore.Mvc;
namespace Portfolio_II
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Home()
        { return View("Home"); }

        [HttpGet("projects")]
        public ViewResult Projects()
        { return View("Projects"); }

        [HttpGet("contact")]
        public ViewResult Contact()
        { return View("Contact"); }
    }
}