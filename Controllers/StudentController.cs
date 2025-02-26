using Microsoft.AspNetCore.Mvc;
using EduWebsite.Models;
using System.Collections.Generic;

namespace EduWebsite.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new();  // Temporary storage

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                student.Id = students.Count + 1; // Auto-increment ID
                students.Add(student);
                return RedirectToAction("Success");
            }
            return View(student);
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(students);
        }
    }
}
