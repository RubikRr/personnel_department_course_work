using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace personnel_department_DB.Migrations
{
    /// <inheritdoc />
    public partial class AddAccountantInEmployeeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("25d21304-84c7-4265-8330-9233eb5b348e"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("868a7b9f-c7f9-4d6a-af98-efa116dda5f8"));

            migrationBuilder.DeleteData(
                table: "WorkingTime",
                keyColumn: "Id",
                keyValue: new Guid("d1ad6666-a48f-4775-af3e-3b05d5954952"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("653a4518-c678-41cf-9fa3-a36d85888a94"));

            migrationBuilder.DeleteData(
                table: "Employess",
                keyColumn: "Id",
                keyValue: new Guid("a25b2458-4b9f-40bc-a1f6-5dc5c70c61e3"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("0fcdb750-2c8d-4b5a-9468-b348ad517cde"));

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("d822d75a-be30-47a9-88f0-3856de397f94"), "ООО Рубик экспресс" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("15158a53-2a5c-433b-92f5-7e814edf5cce"), "Директор" },
                    { new Guid("f2bcae4f-9cde-4243-89fe-3defda74d82f"), "Бухгалтер" }
                });

            migrationBuilder.InsertData(
                table: "Employess",
                columns: new[] { "Id", "DateOfBirth", "FIO", "FamilyComposition", "INH", "PassportId", "PhoneNumber", "PlaceOfResidence", "PositionId", "WorkExperience" },
                values: new object[,]
                {
                    { new Guid("20d70040-ffbd-4f0d-978a-38e4ecc2af82"), new DateTime(2003, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Василий Петрович Вознесенский", 2L, 1234567890L, 11148L, "+7 919 922 32 23", "Пр.Мира 1", new Guid("15158a53-2a5c-433b-92f5-7e814edf5cce"), 12L },
                    { new Guid("961c878a-3c1d-4210-8cad-a246f1655041"), new DateTime(2001, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Владимир Сергеевич Алханчуртов", 3L, 1292374892L, 22233L, "+9 123 653 12 22", "Пр.Коста 1", new Guid("f2bcae4f-9cde-4243-89fe-3defda74d82f"), 7L }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "AcceptanceDate", "Allowance", "CompanyId", "DateOfPreparation", "EmployeeId", "Salary" },
                values: new object[,]
                {
                    { new Guid("aecb7a32-2be5-4387-9c58-f83a35ecee45"), new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000m, new Guid("d822d75a-be30-47a9-88f0-3856de397f94"), new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("961c878a-3c1d-4210-8cad-a246f1655041"), 60000m },
                    { new Guid("bfccdd76-001a-4e10-b47f-98cb47b91519"), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000m, new Guid("d822d75a-be30-47a9-88f0-3856de397f94"), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("20d70040-ffbd-4f0d-978a-38e4ecc2af82"), 10000m }
                });

            migrationBuilder.InsertData(
                table: "WorkingTime",
                columns: new[] { "Id", "ActualDaysWorked", "BusinessTrip", "DaysOff", "DaysWorked", "EmployeeId", "SickLeave", "Vacation" },
                values: new object[,]
                {
                    { new Guid("3a4484b2-a3b3-49b8-8ff6-e3bc4f2f52be"), 20, 4, 4, 31, new Guid("20d70040-ffbd-4f0d-978a-38e4ecc2af82"), 3, 0 },
                    { new Guid("51df34db-5092-4e35-8099-0258b1b8a3a1"), 17, 4, 7, 31, new Guid("961c878a-3c1d-4210-8cad-a246f1655041"), 3, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("aecb7a32-2be5-4387-9c58-f83a35ecee45"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("bfccdd76-001a-4e10-b47f-98cb47b91519"));

            migrationBuilder.DeleteData(
                table: "WorkingTime",
                keyColumn: "Id",
                keyValue: new Guid("3a4484b2-a3b3-49b8-8ff6-e3bc4f2f52be"));

            migrationBuilder.DeleteData(
                table: "WorkingTime",
                keyColumn: "Id",
                keyValue: new Guid("51df34db-5092-4e35-8099-0258b1b8a3a1"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("d822d75a-be30-47a9-88f0-3856de397f94"));

            migrationBuilder.DeleteData(
                table: "Employess",
                keyColumn: "Id",
                keyValue: new Guid("20d70040-ffbd-4f0d-978a-38e4ecc2af82"));

            migrationBuilder.DeleteData(
                table: "Employess",
                keyColumn: "Id",
                keyValue: new Guid("961c878a-3c1d-4210-8cad-a246f1655041"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("15158a53-2a5c-433b-92f5-7e814edf5cce"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("f2bcae4f-9cde-4243-89fe-3defda74d82f"));

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("653a4518-c678-41cf-9fa3-a36d85888a94"), "ООО Рубик экспресс" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0fcdb750-2c8d-4b5a-9468-b348ad517cde"), "Директор" },
                    { new Guid("868a7b9f-c7f9-4d6a-af98-efa116dda5f8"), "Бухгалтер" }
                });

            migrationBuilder.InsertData(
                table: "Employess",
                columns: new[] { "Id", "DateOfBirth", "FIO", "FamilyComposition", "INH", "PassportId", "PhoneNumber", "PlaceOfResidence", "PositionId", "WorkExperience" },
                values: new object[] { new Guid("a25b2458-4b9f-40bc-a1f6-5dc5c70c61e3"), new DateTime(2003, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Василий Петрович Вознесенский", 2L, 1234567890L, 11148L, "+7 919 922 32 23", "Пр.Мира 1", new Guid("0fcdb750-2c8d-4b5a-9468-b348ad517cde"), 12L });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "AcceptanceDate", "Allowance", "CompanyId", "DateOfPreparation", "EmployeeId", "Salary" },
                values: new object[] { new Guid("25d21304-84c7-4265-8330-9233eb5b348e"), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000m, new Guid("653a4518-c678-41cf-9fa3-a36d85888a94"), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a25b2458-4b9f-40bc-a1f6-5dc5c70c61e3"), 10000m });

            migrationBuilder.InsertData(
                table: "WorkingTime",
                columns: new[] { "Id", "ActualDaysWorked", "BusinessTrip", "DaysOff", "DaysWorked", "EmployeeId", "SickLeave", "Vacation" },
                values: new object[] { new Guid("d1ad6666-a48f-4775-af3e-3b05d5954952"), 20, 4, 4, 31, new Guid("a25b2458-4b9f-40bc-a1f6-5dc5c70c61e3"), 3, 0 });
        }
    }
}
