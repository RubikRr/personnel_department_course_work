
using System.ComponentModel.DataAnnotations.Schema;


namespace personnel_department_DB.Models
{
    [Table("Employess")]
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

        public WorkingTime? WorkingTimeTable { get; set; }

        public Contract? Contract { get; set; }

        public Dismissal? Dismissal { get; set; }

        public List<Transfer>Ttransfers { get; set; }
    }
}
