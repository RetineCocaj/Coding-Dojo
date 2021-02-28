using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        { return View("Index"); }

        [HttpPost("Result")]
        public IActionResult Method(string Name, string DojoLocation, string FavoriteLanguage, string Comment){
            ViewBag.Name = Name;
            ViewBag.DojoLocation = DojoLocation;
            ViewBag.FavoriteLanguage = FavoriteLanguage;
            ViewBag.Comment = Comment;
            return View("Method");
        }
    }
}