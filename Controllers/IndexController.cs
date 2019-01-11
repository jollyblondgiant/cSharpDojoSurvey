using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;
namespace DojoSurvey
{
    public class IndexController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("survey")]
        public RedirectToActionResult Method(SurveyForm survey)
        {
           
            return RedirectToAction("Submit", survey);
        }
        [HttpGet("result")]
        public IActionResult Submit(SurveyForm survey)
        {

            return View("Submit", survey);
        }
    }
}