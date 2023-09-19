using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using personnel_department_DB.Interfaces;
using personnel_department_DB.Models;

namespace personnel_department_course_work.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeesStorage employeesStorage;

        private IPositionsStorage positionsStorage;

        public EmployeeController(IEmployeesStorage employeesStorage, IPositionsStorage positionsStorage)
        {
            this.employeesStorage = employeesStorage;
            this.positionsStorage = positionsStorage;
        }

        public IActionResult Index()
        {
            var employees = employeesStorage.GetAll();
            return View(employees);
        }

        public IActionResult Details(Guid id)
        {
            var employe = employeesStorage.GetById(id);
            return View(employe);
        }

        public IActionResult FindByPhone(string phone)
        {
            var employees = employeesStorage.GetByPhone(phone);
            return View(employees);
        }

        public IActionResult FindByTable(string tableId)
        {
            var employees = employeesStorage.GetByTable(tableId);
            return View(employees);
        }

        public IActionResult Add()
        {
            var sl=new SelectList(positionsStorage.GetAll().Select(position => position.Name));
            ViewBag.Positions=sl;
            return View();
        }
        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            employee.Position=positionsStorage.GetByName(employee.Position.Name);
            employeesStorage.Add(employee);
            return  RedirectToAction(nameof(Index));
        }
        public IActionResult AddWorkingTime(Guid employeeId)
        {
            ViewBag.EmployeeId = employeeId;
            return View();
        }
        [HttpPost]
        public IActionResult AddWorkingTime(WorkingTime workingTime)
        {
            
            return RedirectToAction(nameof(Index));
        }
        public IActionResult AddContract(Guid employeeId)
        {
            ViewBag.EmployeeId = employeeId;
            return View();
        }
        [HttpPost]
        public IActionResult AddContract(Contract contract)
        {
            contract.CompanyId = employeesStorage.GetCompany().Id;
            employeesStorage.AddContract(contract);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult AddTransfer(Guid employeeId)
        {
            ViewBag.EmployeeId =employeeId;
            return View();
        }
        [HttpPost]
        public IActionResult AddTransfer(Transfer transfer)
        {
            employeesStorage.AddTransfer(transfer);
            return RedirectToAction(nameof(Index));
        }
    }
}
