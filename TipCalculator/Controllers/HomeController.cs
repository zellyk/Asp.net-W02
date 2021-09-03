using Microsoft.AspNetCore.Mvc;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    //This class is used to take input from the url and routes it through the
    //model to load the dynamic webpage

    public class HomeController : Controller
    {
        //HttpGet to initiate the function with data of 0's
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.T1 = 0;
            ViewBag.T2 = 0;
            ViewBag.T3 = 0;
            return View();
        }
        //httpPost will take the input and return the results from the model
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