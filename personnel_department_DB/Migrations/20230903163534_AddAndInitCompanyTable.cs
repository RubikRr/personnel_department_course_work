using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace personnel_department_DB.Migrations
{
    /// <inheritdoc />
    public partial class AddAndInitCompanyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("5ccd29d3-59fb-4161-a8d2-4b90323d50ce"));

            migrationBuilder.DeleteData(
                table: "WorkingTime",
                keyColumn: "Id",
                keyValue: new Guid("dd2ab228-f063-4101-bf51-2189281bece3"));

            migrationBuilder.DeleteData(
                table: "Employess",
                keyColumn: "Id",
                keyValue: new Guid("b404163e-52a5-4e06-b79a-28305acbbf2c"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("c9155894-e047-4a81-972e-ed5f9308b15c"));

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("8106134b-f105-4d06-af94-245b2d68f6cc"), "ООО Рубик экспресс" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3cd4ac57-5eee-4f21-a596-dec9badf4cf5"), "Бухгалтер" },
                    { new Guid("a202ff11-65c3-4864-b2cf-201ab78d0683"), "Директор" }
                });

            migrationBuilder.InsertData(
                table: "Employess",
                columns: new[] { "Id", "DateOfBirth", "FIO", "FamilyComposition", "INH", "PassportId", "PhoneNumber", "PlaceOfResidence", "PositionId", "WorkExperience" },
                values: new object[] { new Guid("b364fe04-0315-4557-a6c8-938ed5a7b7dc"), new DateTime(2003, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Василий Петрович Вознесенский", 2L, 1234567890L, 11148L, "+7 919 922 32 23", "Пр.Мира 1", new Guid("a202ff11-65c3-4864-b2cf-201ab78d0683"), 12L });

            migrationBuilder.InsertData(
                table: "WorkingTime",
                columns: new[] { "Id", "ActualDaysWorked", "BusinessTrip", "DaysOff", "DaysWorked", "EmployeeId", "SickLeave", "Vacation" },
                values: new object[] { new Guid("613325b5-9136-4fc6-9970-46975ab4a196"), 20, 4, 4, 31, new Guid("b364fe04-0315-4557-a6c8-938ed5a7b7dc"), 3, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("3cd4ac57-5eee-4f21-a596-dec9badf4cf5"));

            migrationBuilder.DeleteData(
                table: "WorkingTime",
                keyColumn: "Id",
                keyValue: new Guid("613325b5-9136-4fc6-9970-46975ab4a196"));

            migrationBuilder.DeleteData(
                table: "Employess",
                keyColumn: "Id",
                keyValue: new Guid("b364fe04-0315-4557-a6c8-938ed5a7b7dc"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("a202ff11-65c3-4864-b2cf-201ab78d0683"));

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5ccd29d3-59fb-4161-a8d2-4b90323d50ce"), "Бухгалтер" },
                    { new Guid("c9155894-e047-4a81-972e-ed5f9308b15c"), "Директор" }
                });

            migrationBuilder.InsertData(
                table: "Employess",
                columns: new[] { "Id", "DateOfBirth", "FIO", "FamilyComposition", "INH", "PassportId", "PhoneNumber", "PlaceOfResidence", "PositionId", "WorkExperience" },
                values: new object[] { new Guid("b404163e-52a5-4e06-b79a-28305acbbf2c"), new DateTime(2003, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Василий Петрович Вознесенский", 2L, 1234567890L, 11148L, "+7 919 922 32 23", "Пр.Мира 1", new Guid("c9155894-e047-4a81-972e-ed5f9308b15c"), 12L });

            migrationBuilder.InsertData(
                table: "WorkingTime",
                columns: new[] { "Id", "ActualDaysWorked", "BusinessTrip", "DaysOff", "DaysWorked", "EmployeeId", "SickLeave", "Vacation" },
                values: new object[] { new Guid("dd2ab228-f063-4101-bf51-2189281bece3"), 20, 4, 4, 31, new Guid("b404163e-52a5-4e06-b79a-28305acbbf2c"), 3, 0 });
        }
    }
}
