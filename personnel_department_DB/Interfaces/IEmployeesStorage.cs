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
    }
}
