using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnel_department_DB.Models
{
    public class WorkingTime
    {
        public Guid Id { get; set; }
        public int DaysWorked { get; set; }
        public int ActualDaysWorked { get; set; }
        public int DaysOff { get; set; }
        public int Vacation { get; set; }
        public int BusinessTrip { get; set; }
        public int SickLeave { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
