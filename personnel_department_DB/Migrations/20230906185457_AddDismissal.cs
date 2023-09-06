using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace personnel_department_DB.Migrations
{
    /// <inheritdoc />
    public partial class AddDismissal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("0eed40fd-d441-466a-b203-955d9b4ad991"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("6c68eec0-33aa-4394-80f3-48795e0d20c1"));

            migrationBuilder.DeleteData(
                table: "WorkingTime",
                keyColumn: "Id",
                keyValue: new Guid("030e7e31-eee7-4892-a49c-1f6059943c91"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("f0c3d142-e4a3-4348-b3a4-2949ae51dfdd"));

            migrationBuilder.DeleteData(
                table: "Employess",
                keyColumn: "Id",
                keyValue: new Guid("44763552-36f6-493e-92d0-3f2eaafddd19"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("324f1670-de29-496f-adad-947d2dde65cc"));

            migrationBuilder.CreateTable(
                name: "Dismissals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfPreparation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfDismissal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Base = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dismissals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dismissals_Employess_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employess",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Dismissals_EmployeeId",
                table: "Dismissals",
                column: "EmployeeId",
                unique: true,
                filter: "[EmployeeId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dismissals");

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
                values: new object[] { new Guid("f0c3d142-e4a3-4348-b3a4-2949ae51dfdd"), "ООО Рубик экспресс" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("324f1670-de29-496f-adad-947d2dde65cc"), "Директор" },
                    { new Guid("6c68eec0-33aa-4394-80f3-48795e0d20c1"), "Бухгалтер" }
                });

            migrationBuilder.InsertData(
                table: "Employess",
                columns: new[] { "Id", "DateOfBirth", "FIO", "FamilyComposition", "INH", "PassportId", "PhoneNumber", "PlaceOfResidence", "PositionId", "WorkExperience" },
                values: new object[] { new Guid("44763552-36f6-493e-92d0-3f2eaafddd19"), new DateTime(2003, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Василий Петрович Вознесенский", 2L, 1234567890L, 11148L, "+7 919 922 32 23", "Пр.Мира 1", new Guid("324f1670-de29-496f-adad-947d2dde65cc"), 12L });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "AcceptanceDate", "Allowance", "CompanyId", "DateOfPreparation", "EmployeeId", "Salary" },
                values: new object[] { new Guid("0eed40fd-d441-466a-b203-955d9b4ad991"), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000m, new Guid("f0c3d142-e4a3-4348-b3a4-2949ae51dfdd"), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44763552-36f6-493e-92d0-3f2eaafddd19"), 10000m });

            migrationBuilder.InsertData(
                table: "WorkingTime",
                columns: new[] { "Id", "ActualDaysWorked", "BusinessTrip", "DaysOff", "DaysWorked", "EmployeeId", "SickLeave", "Vacation" },
                values: new object[] { new Guid("030e7e31-eee7-4892-a49c-1f6059943c91"), 20, 4, 4, 31, new Guid("44763552-36f6-493e-92d0-3f2eaafddd19"), 3, 0 });
        }
    }
}
