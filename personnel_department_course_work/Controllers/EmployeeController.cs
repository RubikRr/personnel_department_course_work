using Microsoft.AspNetCore.Mvc;
using personnel_department_DB.Interfaces;

namespace personnel_department_course_work.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeesStorage employeesStorage;

        public EmployeeController(IEmployeesStorage employeesStorage) 
        {
            this.employeesStorage = employeesStorage;
        }

        public IActionResult Index()
        {
            var employees=employeesStorage.GetAll();
            return View(employees);
        }

        public IActionResult Details(Guid id)
        {
            var employe = employeesStorage.GetById(id);
            return View(employe);
        }
    }
}
