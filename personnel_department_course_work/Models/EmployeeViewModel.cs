using personnel_department_DB.Models;

namespace personnel_department_course_work.Models
{
    public class EmployeeViewModel
    {
        public Guid Id { get; set; }
        public string FIO { get; set; }
        public uint WorkExperience { get; set; }
        public uint PassportId { get; set; }
        public uint INH { get; set; }
        public uint FamilyComposition { get; set; }
        public string PhoneNumber { get; set; }
        public string PlaceOfResidence { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Guid PositionId { get; set; }
        public Position Position { get; set; }

        public WorkingTime WorkingTimeTable { get; set; }


    }
}
