using Microsoft.AspNetCore.Mvc;
using MVC_Day2.Models;
namespace MVC_Day2.Controllers
{
    public class AddNumbersController : Controller
    {
        [HttpGet]
        public IActionResult Add1()
        {
            return View();
        }

        [HttpPost] 
        public IActionResult Add1(IFormCollection form) {
            int no1 = int.Parse(form["no1"]);
            int no2 = int.Parse(form["no2"]);
            int res = no1 + no2;
            ViewBag.res = res;
            //return Content(res.ToString());
            return View();
        }
         
        public IActionResult Add2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add2(string no1, string no2) {
            ViewBag.res = (int.Parse(no1)+ int.Parse(no2)).ToString();
            return View();
        }

        public IActionResult Add3()
        {
            Numbers numbers = new Numbers();

            return View(numbers);
        }
    }
}
