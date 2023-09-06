using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace personnel_department_DB.Models
{
    [Table("EmploymentContracts")]
    public class EmploymentContract
    {
        public Guid Id { get; set; }
        public DateTime DateOfPreparation { get; set; }
        public DateTime AcceptanceDate { get; set; }
        public Decimal Salary { get; set; }
        public Decimal Allowance { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        

    }
}
