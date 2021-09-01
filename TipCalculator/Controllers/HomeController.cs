using Microsoft.AspNetCore.Mvc;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    //This class is used to take input from the view adn send it to be calculated in the model.
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.T1 = 0;
            ViewBag.T2 = 0;
            ViewBag.T3 = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(TipCalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.T1 = model.CalculateT1();
                ViewBag.T2 = model.CalculateT2();
                ViewBag.T3 = model.CalculateT3();
            }
            else
            {
                ViewBag.T1 = 0;
                ViewBag.T2 = 0;
                ViewBag.T3 = 0;
            }
            return View(model);
        }

    }
}