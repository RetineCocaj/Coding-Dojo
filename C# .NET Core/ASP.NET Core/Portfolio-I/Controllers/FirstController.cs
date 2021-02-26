using Microsoft.AspNetCore.Mvc;
namespace Portfolio_I
{
    public class FirstController : Controller
    {
        [HttpGet("")]
        public string Index()
        {
            return "This is my index!";
        }

        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my projects";
        }

        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my contact";
        }
    }
}