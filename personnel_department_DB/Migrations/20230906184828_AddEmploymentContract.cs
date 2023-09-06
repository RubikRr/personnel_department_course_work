using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace personnel_department_DB.Migrations
{
    /// <inheritdoc />
    public partial class AddEmploymentContract : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("8106134b-f105-4d06-af94-245b2d68f6cc"));

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

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfPreparation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AcceptanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Allowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_Employess_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_CompanyId",
                table: "Contracts",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_EmployeeId",
                table: "Contracts",
                column: "EmployeeId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("f0c3d142-e4a3-4348-b3a4-2949ae51dfdd"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("6c68eec0-33aa-4394-80f3-48795e0d20c1"));

            migrationBuilder.DeleteData(
                table: "WorkingTime",
                keyColumn: "Id",
                keyValue: new Guid("030e7e31-eee7-4892-a49c-1f6059943c91"));

            migrationBuilder.DeleteData(
                table: "Employess",
                keyColumn: "Id",
                keyValue: new Guid("44763552-36f6-493e-92d0-3f2eaafddd19"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("324f1670-de29-496f-adad-947d2dde65cc"));

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
    }
}
