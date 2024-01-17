using Microsoft.AspNetCore.Mvc;
using MVC_Day2.Models;
namespace MVC_Day2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.name = "aaa";
            //ViewBag.address 
            Employee employee = new Employee()
            { Id = 1, Name = "Deepak", Dept = "HR", Manager = "Ajay" };
            ViewBag.employee = employee;
            return View();
        }

        public IActionResult List()
        {
            List<Employee> list = new List<Employee>()
            {
                 new Employee() { Id = 1,Name="aa", Dept="aa", Manager="aa"},

                 new Employee() { Id = 1,Name="aa", Dept="aa", Manager="aa"},

                 new Employee() { Id = 1,Name="aa", Dept="aa", Manager="aa"},
                 new Employee() { Id = 1,Name="aa", Dept="aa", Manager="aa"},
            };
            ViewBag.list = list;
            return View();
        }
    }
}
