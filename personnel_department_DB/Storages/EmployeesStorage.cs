using Microsoft.EntityFrameworkCore;
using personnel_department_DB.Interfaces;
using personnel_department_DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnel_department_DB.Storages
{
    public class EmployeesStorage:IEmployeesStorage
    {
        private DatabaseContext dbContext;

        public EmployeesStorage(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Employee> GetAll()
        {
            return dbContext.Employess.Include(employee=>employee.Position).Include(employee=>employee.WorkingTimeTable).ToList();
        }

        public Employee GetById(Guid id) 
        {
           return dbContext.Employess.Include(employee=>employee.Position).Include(employee=>employee.WorkingTimeTable).Include(employee=>employee.Contract).ThenInclude(contract=>contract.Company).FirstOrDefault(employee => employee.Id == id);
        }
    }
}
