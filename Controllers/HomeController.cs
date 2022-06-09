using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// using DojoSurveyWModel.Models;
using ViewModelFun.Models;

namespace DojoSurveyWModel.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
      return View();
    }

    [HttpPost("result")]
    public IActionResult Result(Survey user)
    {

      return View("Result", user);
    }
}
