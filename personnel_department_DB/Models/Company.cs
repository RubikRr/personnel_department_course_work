using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnel_department_DB.Models
{
    [Table("Companies")]

    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        List<Contract> Contracts { get; set; }
    }
}
