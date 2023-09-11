using Microsoft.EntityFrameworkCore;
using personnel_department_DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnel_department_DB
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Position> Positions { get; set; }

        public DbSet<Employee> Employess { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var company1 = new Company { Id = Guid.NewGuid(), Name = "ООО Рубик экспресс" };

            var posDirector = new Position { Id = Guid.NewGuid(), Name = "Директор" };
            var posAccountant = new Position { Id = Guid.NewGuid(), Name = "Бухгалтер" };



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
                WorkExperience = 12,
                PositionId = posDirector.Id,
            };
            var accountant = new Employee
            {
                Id = Guid.NewGuid(),
                FIO = "Владимир Сергеевич Алханчуртов",
                DateOfBirth = new DateTime(2001, 10, 10),
                FamilyComposition = 3,
                INH = 1292374892,
                PassportId = 22233,
                PhoneNumber = "+9 123 653 12 22",
                PlaceOfResidence = "Пр.Коста 1",
                WorkExperience = 7,
                PositionId = posAccountant.Id,
            };
            var contractDirector = new Contract
            {
                Id = Guid.NewGuid(),
                DateOfPreparation = new DateTime(2023, 9, 1),
                AcceptanceDate = new DateTime(2023, 9, 5),
                Salary = 10000,
                Allowance = 2000,
                EmployeeId = director.Id,
                CompanyId = company1.Id,
            };
            var contractAccountant = new Contract
            {
                Id = Guid.NewGuid(),
                DateOfPreparation = new DateTime(2022, 8, 3),
                AcceptanceDate = new DateTime(2022, 8, 4),
                Salary = 60000,
                Allowance = 1000,
                EmployeeId = accountant.Id,
                CompanyId = company1.Id,
            };
            var directorWorkingTimeTable = new WorkingTime
            {
                Id = Guid.NewGuid(),
                DaysWorked = 31,
                ActualDaysWorked = 20,
                DaysOff = 4,
                BusinessTrip = 4,
                SickLeave = 3,
                Vacation = 0,
                EmployeeId = director.Id
            };
            var acountantWorkingTimeTable = new WorkingTime
            {
                Id = Guid.NewGuid(),
                DaysWorked = 31,
                ActualDaysWorked = 17,
                DaysOff = 7,
                BusinessTrip = 4,
                SickLeave = 3,
                Vacation = 0,
                EmployeeId = accountant.Id
            };
            modelBuilder.Entity<Position>().HasData(posDirector, posAccountant);
            modelBuilder.Entity<Company>().HasData(company1);
            modelBuilder.Entity<Employee>().HasData(director,accountant);
            modelBuilder.Entity<Contract>().HasData(contractDirector,contractAccountant);
            modelBuilder.Entity<WorkingTime>().HasData(directorWorkingTimeTable,acountantWorkingTimeTable);
        }
    }
}
