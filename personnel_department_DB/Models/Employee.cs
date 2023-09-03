using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnel_department_DB.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FIO { get; set; }
        public uint WorkExperience { get; set; }
        public uint PassportId { get; set; }
        public uint INH { get; set; }
        public uint FamilyComposition{ get; set; }
        public string PhoneNumber { get; set; }
        public string PlaceOfResidence { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Guid PositionId { get; set; }
        public Position Position { get; set; }

        public WorkingTimeTable WorkingTimeTable { get; set; }


    }
}
