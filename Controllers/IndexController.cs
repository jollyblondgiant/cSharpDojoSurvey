using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey
{
    public class IndexController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("result")]
        public IActionResult Submit(string name, string location, string language, string comment)
        {
            ViewBag.Name = " ";
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comment = comment;
            return View();
        }
    }
}