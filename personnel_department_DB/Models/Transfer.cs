using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnel_department_DB.Models
{
    [Table("Transfers")]
    public class Transfer
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string PreviousWork { get; set; }
        public string NewWork { get; set; }
        public string Reason { get; set; }
        public Guid EmployeeId { get; set; };
        public Employee Employee { get; set; }
    }
}
