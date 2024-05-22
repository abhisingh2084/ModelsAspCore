using Microsoft.AspNetCore.Mvc;
using ModelsAspCore.Models;
using ModelsAspCore.Repository;
using System.Diagnostics;

namespace ModelsAspCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }

        public List<StudentModel> getAllStudents()
        {
            return _studentRepository.getAllStudent();
        }

        public StudentModel getById(int id)
        {
            return _studentRepository.getStudentById(id);
        }

        public IActionResult Index()
        {
            //var students = new List<StudentModel> 
            //{ 
            //    new StudentModel {RollNo = 1, Name = "Abhishek", Gender = "Male", Standard = 5},
            //    new StudentModel {RollNo = 2, Name = "Aryan Raj", Gender = "Male", Standard = 6},
            //    new StudentModel {RollNo = 3, Name = "Vikash Ojha", Gender = "Male", Standard = 7},
            //    new StudentModel {RollNo = 4, Name = "Vinay Singh", Gender = "Male", Standard = 5},
            //    new StudentModel {RollNo = 5, Name = "Prakash Yadav", Gender = "Male", Standard = 10},
            //};

            //ViewData["StudentsList"] = students;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
