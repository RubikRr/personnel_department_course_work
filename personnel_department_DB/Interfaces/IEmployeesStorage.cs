using Microsoft.EntityFrameworkCore;
using personnel_department_DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnel_department_DB.Interfaces
{
    public interface IEmployeesStorage
    {
        public List<Employee> GetAll();

        public Employee GetById(Guid id);
        public void Add(Employee employee);

        public List<Employee> GetByPhone(string phone);

        public List<Employee> GetByTable(string tableId);

        public void AddTransfer(Transfer transfer);

        public void AddWorkingTime(WorkingTime workingTime);
        public void AddContract(Contract contract);
        public List<Employee> GetByPosition(string positionName);
        public Company GetCompany();
    }
}
