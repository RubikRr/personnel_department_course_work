using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnel_department_DB.Models
{
    [Table("Vacations")]
    public class Vacation
    {
        public Guid Id { get; set; }
        public DateTime DateoOPreparation { get; set; }

        public int Amount { get; set; }
        public decimal Payment { get; set; }

        public string Reason { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
