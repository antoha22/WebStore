using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private static List<Employee> __Employees = new List<Employee>
        {
            new Employee
            {
                Id = 0,
                FirstName = "Anton",
                SurName = "Lvov",
                Patronomyc = "Johnovich",
                Age = 22
            },
            new Employee
            {
                Id = 0,
                FirstName = "sad",
                SurName = "Lv123123ov",
                Patronomyc = "Johnofdsfsvich",
                Age = 23
            },
            new Employee
            {
                Id = 0,
                FirstName = "FFFF",
                SurName = "SSSS",
                Patronomyc = "AAAAA",
                Age = 25
            }
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SomeAction() 
        {
            return View();
        }
        public IActionResult Employees() 
        {
            return View(__Employees);
        }
        public IActionResult Employee(int Id) 
        {
            var employee = __Employees.FirstOrDefault(e => e.Id == Id);
            if (employee is null)
                return NotFound();
            return View(employee);
        }
    }
}