using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataValidation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DataValidation.Controllers
{
    [Route("[controller]")]
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Student data submitted successfully!";
                return View("Success", student);
            }

            return View(student);
        }

        public IActionResult Success(Student student)
        {
            return View(student);
        }
    }
}