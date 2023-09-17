using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace personnel_department_DB.Migrations
{
    /// <inheritdoc />
    public partial class AddBusinessTripTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("ba624155-2f35-4b0e-a27a-6b090b3f3057"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("cac5b915-5584-431f-b04f-f06c1fb3f0e0"));

            migrationBuilder.DeleteData(
                table: "WorkingTime",
                keyColumn: "Id",
                keyValue: new Guid("047a66c3-a0f4-43b0-91ec-d5255e417712"));

            migrationBuilder.DeleteData(
                table: "WorkingTime",
                keyColumn: "Id",
                keyValue: new Guid("74827e20-e7fc-4a0d-b276-62f7304d4fa0"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("8b70e6c6-c0f3-47af-92bb-e3827384f71c"));

            migrationBuilder.DeleteData(
                table: "Employess",
                keyColumn: "Id",
                keyValue: new Guid("060917a1-6bd1-45c8-88d8-d907e687098b"));

            migrationBuilder.DeleteData(
                table: "Employess",
                keyColumn: "Id",
                keyValue: new Guid("714e614a-8cb2-4c44-9171-22a8885f0f18"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("1f62fce3-dd28-4b3e-ae76-35574b009271"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("886ff80c-a37f-4e08-874f-e29331f0df7c"));

            migrationBuilder.CreateTable(
                name: "BusinessTrips",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Term = table.Column<int>(type: "int", nullable: false),
                    Funds = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessTrips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessTrips_Employess_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("6e751d0b-8bf0-44b6-a972-e15cfd651c3a"), "ООО Рубик экспресс" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("39e7b21f-f3df-4e4f-9bda-4b4f56efd2cd"), "Директор" },
                    { new Guid("867437f0-6504-464a-b1c1-0f4ed8b4d5fb"), "Бухгалтер" }
                });

            migrationBuilder.InsertData(
                table: "Employess",
                columns: new[] { "Id", "DateOfBirth", "FIO", "FamilyComposition", "INH", "PassportId", "PhoneNumber", "PlaceOfResidence", "PositionId", "WorkExperience" },
                values: new object[,]
                {
                    { new Guid("38965252-c9c0-4448-8e6a-4ea9f95413c5"), new DateTime(2001, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Владимир Сергеевич Алханчуртов", 3L, 1292374892L, 22233L, "+9 123 653 12 22", "Пр.Коста 1", new Guid("867437f0-6504-464a-b1c1-0f4ed8b4d5fb"), 7L },
                    { new Guid("be5c66ef-e6c1-46e4-ab9a-64f2105729c0"), new DateTime(2003, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Василий Петрович Вознесенский", 2L, 1234567890L, 11148L, "+7 919 922 32 23", "Пр.Мира 1", new Guid("39e7b21f-f3df-4e4f-9bda-4b4f56efd2cd"), 12L }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "AcceptanceDate", "Allowance", "CompanyId", "DateOfPreparation", "EmployeeId", "Salary" },
                values: new object[,]
                {
                    { new Guid("17069bbc-d5d9-47b2-af86-f41d54a8cd95"), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000m, new Guid("6e751d0b-8bf0-44b6-a972-e15cfd651c3a"), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("be5c66ef-e6c1-46e4-ab9a-64f2105729c0"), 10000m },
                    { new Guid("290ec50a-9213-48c3-abd7-addb7c8c9846"), new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000m, new Guid("6e751d0b-8bf0-44b6-a972-e15cfd651c3a"), new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("38965252-c9c0-4448-8e6a-4ea9f95413c5"), 60000m }
                });

            migrationBuilder.InsertData(
                table: "WorkingTime",
                columns: new[] { "Id", "ActualDaysWorked", "BusinessTrip", "DaysOff", "DaysWorked", "EmployeeId", "SickLeave", "Vacation" },
                values: new object[,]
                {
                    { new Guid("216a859b-bd64-4520-b224-f5b0784971a0"), 17, 4, 7, 31, new Guid("38965252-c9c0-4448-8e6a-4ea9f95413c5"), 3, 0 },
                    { new Guid("f43ea9b5-1d2f-4fc8-ab0a-cf55b22d47bd"), 20, 4, 4, 31, new Guid("be5c66ef-e6c1-46e4-ab9a-64f2105729c0"), 3, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTrips_EmployeeId",
                table: "BusinessTrips",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessTrips");

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("17069bbc-d5d9-47b2-af86-f41d54a8cd95"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("290ec50a-9213-48c3-abd7-addb7c8c9846"));

            migrationBuilder.DeleteData(
                table: "WorkingTime",
                keyColumn: "Id",
                keyValue: new Guid("216a859b-bd64-4520-b224-f5b0784971a0"));

            migrationBuilder.DeleteData(
                table: "WorkingTime",
                keyColumn: "Id",
                keyValue: new Guid("f43ea9b5-1d2f-4fc8-ab0a-cf55b22d47bd"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("6e751d0b-8bf0-44b6-a972-e15cfd651c3a"));

            migrationBuilder.DeleteData(
                table: "Employess",
                keyColumn: "Id",
                keyValue: new Guid("38965252-c9c0-4448-8e6a-4ea9f95413c5"));

            migrationBuilder.DeleteData(
                table: "Employess",
                keyColumn: "Id",
                keyValue: new Guid("be5c66ef-e6c1-46e4-ab9a-64f2105729c0"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("39e7b21f-f3df-4e4f-9bda-4b4f56efd2cd"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("867437f0-6504-464a-b1c1-0f4ed8b4d5fb"));

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("8b70e6c6-c0f3-47af-92bb-e3827384f71c"), "ООО Рубик экспресс" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1f62fce3-dd28-4b3e-ae76-35574b009271"), "Бухгалтер" },
                    { new Guid("886ff80c-a37f-4e08-874f-e29331f0df7c"), "Директор" }
                });

            migrationBuilder.InsertData(
                table: "Employess",
                columns: new[] { "Id", "DateOfBirth", "FIO", "FamilyComposition", "INH", "PassportId", "PhoneNumber", "PlaceOfResidence", "PositionId", "WorkExperience" },
                values: new object[,]
                {
                    { new Guid("060917a1-6bd1-45c8-88d8-d907e687098b"), new DateTime(2003, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Василий Петрович Вознесенский", 2L, 1234567890L, 11148L, "+7 919 922 32 23", "Пр.Мира 1", new Guid("886ff80c-a37f-4e08-874f-e29331f0df7c"), 12L },
                    { new Guid("714e614a-8cb2-4c44-9171-22a8885f0f18"), new DateTime(2001, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Владимир Сергеевич Алханчуртов", 3L, 1292374892L, 22233L, "+9 123 653 12 22", "Пр.Коста 1", new Guid("1f62fce3-dd28-4b3e-ae76-35574b009271"), 7L }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "AcceptanceDate", "Allowance", "CompanyId", "DateOfPreparation", "EmployeeId", "Salary" },
                values: new object[,]
                {
                    { new Guid("ba624155-2f35-4b0e-a27a-6b090b3f3057"), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000m, new Guid("8b70e6c6-c0f3-47af-92bb-e3827384f71c"), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("060917a1-6bd1-45c8-88d8-d907e687098b"), 10000m },
                    { new Guid("cac5b915-5584-431f-b04f-f06c1fb3f0e0"), new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000m, new Guid("8b70e6c6-c0f3-47af-92bb-e3827384f71c"), new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("714e614a-8cb2-4c44-9171-22a8885f0f18"), 60000m }
                });

            migrationBuilder.InsertData(
                table: "WorkingTime",
                columns: new[] { "Id", "ActualDaysWorked", "BusinessTrip", "DaysOff", "DaysWorked", "EmployeeId", "SickLeave", "Vacation" },
                values: new object[,]
                {
                    { new Guid("047a66c3-a0f4-43b0-91ec-d5255e417712"), 17, 4, 7, 31, new Guid("714e614a-8cb2-4c44-9171-22a8885f0f18"), 3, 0 },
                    { new Guid("74827e20-e7fc-4a0d-b276-62f7304d4fa0"), 20, 4, 4, 31, new Guid("060917a1-6bd1-45c8-88d8-d907e687098b"), 3, 0 }
                });
        }
    }
}
