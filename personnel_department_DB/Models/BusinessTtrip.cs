using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnel_department_DB.Models
{
    [Table("BusinessTrips")]
    public class BusinessTtrip
    {
        public Guid Id { get; set; }

        public int Term { get; set; }
        public decimal Funds { get; set; }


        public string Destination { get; set; }
        public string Target { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
