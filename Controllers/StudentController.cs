// File: Controllers/StudentController.cs
using EduWebsite.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace EduWebsite.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        // Controller actions here
    }
}
