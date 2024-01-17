using Microsoft.AspNetCore.Mvc;
using MVC_Day2.Models;

namespace MVC_Day2.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> list = new List<Employee>()
            {
                 new Employee() { Id = 1,Name="aa", Dept="aa", Manager="aa"},

                 new Employee() { Id = 1,Name="aa", Dept="aa", Manager="aa"},

                 new Employee() { Id = 1,Name="aa", Dept="aa", Manager="aa"},
                 new Employee() { Id = 1,Name="aa", Dept="aa", Manager="aa"},
            };
            return View(list);
        }

        public IActionResult Display()
        {
            Employee emp = new Employee
            {
                Id = 1,
                Name = "Ajay",
                Manager = "Deepak",
                Dept = "HR"

            };
            return View(emp);
        }
    }
}
