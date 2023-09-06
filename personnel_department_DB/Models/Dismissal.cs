using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnel_department_DB.Models
{
    [Table("Dismissals")]
    public class Dismissal
    {
        public int Id { get; set; }
        public DateTime DateOfPreparation { get; set; }
        public DateTime DateOfDismissal { get; set; }
        public string Base { get; set; }
        public Decimal Pay { get; set; }

        public Guid? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
