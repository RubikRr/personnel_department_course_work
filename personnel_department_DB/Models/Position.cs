using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnel_department_DB.Models
{
    [Table("Positions")]
    public class Position
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
