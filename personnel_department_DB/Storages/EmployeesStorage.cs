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
        public void Add(Employee employee)
        {
            dbContext.Add(employee);
            dbContext.SaveChanges();
        }
        public List<Employee> GetAll()
        {
            return dbContext.Employess.Include(employee=>employee.Position).Include(employee=>employee.WorkingTimeTable).ToList();
        }

        public Employee GetById(Guid id) 
        {
           return dbContext.Employess.Include(employee=>employee.Position).Include(employee=>employee.WorkingTimeTable).Include(employee=>employee.Contract).ThenInclude(contract=>contract.Company).FirstOrDefault(employee => employee.Id == id);
        }

        public List<Employee> GetByPhone(string phone)
        {
            return dbContext.Employess.Include(employee => employee.Position).Include(employee => employee.WorkingTimeTable).Include(employee => employee.Contract).ThenInclude(contract => contract.Company).Where(employee => employee.PhoneNumber.StartsWith(phone)).ToList();
        }

        public List<Employee> GetByTable(string tableId)
        {
            return dbContext.Employess.Include(employee => employee.Position).Include(employee => employee.WorkingTimeTable).Include(employee => employee.Contract).ThenInclude(contract => contract.Company).Where(employee => employee.WorkingTimeTable.Id.ToString().StartsWith(tableId)).ToList();
        }
    }
}
