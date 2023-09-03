using Microsoft.EntityFrameworkCore;
using personnel_department_DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnel_department_DB
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Position> Positions { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options) 
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var posDirector = new Position { Id = Guid.NewGuid(), Name = "Директор" };
            var posAccountant = new Position { Id = Guid.NewGuid(), Name = "Бухгалтер" };
            modelBuilder.Entity<Position>().HasData(posDirector,posAccountant);



            var director = new Employee
            {
                Id = Guid.NewGuid(),
                FIO = "Василий Петрович Вознесенский",
                DateOfBirth = new DateTime(2003, 1, 26),
                FamilyComposition = 2,
                INH = 1234567890,
                PassportId = 11148,
                PhoneNumber = "+7 919 922 32 23",
                PlaceOfResidence = "Пр.Мира 1",
                WorkExperience=12,
                Position=posDirector
            };
            modelBuilder.Entity<Employee>().HasData(director);

            var directorWorkingTimeTable = new WorkingTimeTable
            {
                Id=Guid.NewGuid(),
                DaysWorked=31,
                ActualDaysWorked=20,
                DaysOff=4,
                BusinessTrip=4,
                SickLeave=3,
                Vacation=0,
                Employee=director,
            };

            modelBuilder.Entity<WorkingTimeTable>().HasData(directorWorkingTimeTable);
        }
    }
}
