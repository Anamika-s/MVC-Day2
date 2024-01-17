using Microsoft.AspNetCore.Mvc;

namespace MVC_Day2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            // To send data from controller to view
            // ViewBag // ViewData
            // TempData
            // ViewData uses Dictionary
            ViewData["name"] = "ajay";
            ViewBag.address = "New Delhi";
            return View();
        }

        public ViewResult Display()
        {
            return View();
        }

        public ContentResult Display4()
        {
            return Content("aaa");
        }
        public IActionResult Display1()
        {
            if (1 == 2)
                return View();
            else if(2==2)
                return Content("Error");
            else 
                return RedirectToAction("Index");

        }

        public IActionResult Display2()
        {
            if (1 == 2)
                return View();
            else
                return RedirectToAction("Index");
        }

        public IActionResult Display3()
        {
            return View("index", "home");
            //return View("display4");
        }

    }
}
