using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
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
        [HttpPost("")]
        public IActionResult Index(SurveyForm newForm)
        {
            SurveyForm NewForm = newForm;
            if(ModelState.IsValid){
                return RedirectToAction("Success", newForm);
            }
            else{
                return View();
            }
            
        }
        [HttpGet("result")]
        public IActionResult Success(SurveyForm newForm)
        {

            return View("Submit", newForm);
        }

    }
}


