using ControllerToView.Models;
using ControllerToView.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ControllerToView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly StudentRepository _studentRepository;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }



        public IActionResult Index()
        {
            var emp = new List<Employee>
            {
                new Employee {EmpID = 1, Name="Shyam", Address="Male", Salary=10},
                new Employee {EmpID = 2, Name="Bahadur", Address="Female", Salary=11},
                new Employee {EmpID = 3, Name="Singh", Address="Male", Salary=12},
                new Employee {EmpID = 4, Name="Teknur", Address="Male", Salary=13},
            };

            return View(emp);
            //Employee emp = new Employee()
            //{
            //    EmpID = 101,
            //    Name = "Santosh",
            //    Address = "Pune",
            //    Salary = 2024

            //};

            //ViewData["myEmp"] =emp;   
            //ViewBag.myEmp = emp;
            // return View(emp);
        }
        public List<StudentModel> getStudents()
        {
            return _studentRepository.getAllStudent();
        }

        public StudentModel getByID(int id)
        {
            return _studentRepository.getStudentBy(id);
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

//public IActionResult Index()
//{
//    var emp = new Employee
//    {
//        EmpID = 101,
//        Name = "Santosh",
//        Salary = 35000,
//        Address = "Delhi"
//    };

//    ViewData["emp"] = emp;
//    ViewBag.Employee = emp;
//    return View();
//}

//public IActionResult Index()
//{
//    var students = new List<StudentModel>
//    {
//        new StudentModel {rollnumber = 1, Name="Shyam", Gender="Male", Standard=10},
//        new StudentModel {rollnumber = 2, Name="Bahadur", Gender="Female", Standard=11},
//        new StudentModel {rollnumber = 3, Name="Singh", Gender="Male", Standard=12},
//        new StudentModel {rollnumber = 4, Name="Teknur", Gender="Male", Standard=13},
//    };
//    ViewData["myStudents"] = students;
//    return View();
//}