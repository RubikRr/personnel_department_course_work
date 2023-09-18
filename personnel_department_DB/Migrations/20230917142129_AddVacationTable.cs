using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace personnel_department_DB.Migrations
{
    /// <inheritdoc />
    public partial class AddVacationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Vacations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateoOPreparation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Payment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacations_Employess_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("2da77176-153d-4f44-a861-2712c1cc8236"), "ООО Рубик экспресс" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1915570f-8e81-41e3-a61a-fb22665ae811"), "Директор" },
                    { new Guid("d20dda2f-4db4-4ffd-89d7-209fa95eb60c"), "Бухгалтер" }
                });

            migrationBuilder.InsertData(
                table: "Employess",
                columns: new[] { "Id", "DateOfBirth", "FIO", "FamilyComposition", "INH", "PassportId", "PhoneNumber", "PlaceOfResidence", "PositionId", "WorkExperience" },
                values: new object[,]
                {
                    { new Guid("3f16653b-cee7-4e1b-a18d-1f1a6087b393"), new DateTime(2003, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Василий Петрович Вознесенский", 2L, 1234567890L, 11148L, "+7 919 922 32 23", "Пр.Мира 1", new Guid("1915570f-8e81-41e3-a61a-fb22665ae811"), 12L },
                    { new Guid("793068ec-f257-4361-a9e9-2904af794508"), new DateTime(2001, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Владимир Сергеевич Алханчуртов", 3L, 1292374892L, 22233L, "+9 123 653 12 22", "Пр.Коста 1", new Guid("d20dda2f-4db4-4ffd-89d7-209fa95eb60c"), 7L }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "AcceptanceDate", "Allowance", "CompanyId", "DateOfPreparation", "EmployeeId", "Salary" },
                values: new object[,]
                {
                    { new Guid("c1848d83-63c2-4d3d-82fe-89def4ba21a7"), new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000m, new Guid("2da77176-153d-4f44-a861-2712c1cc8236"), new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("793068ec-f257-4361-a9e9-2904af794508"), 60000m },
                    { new Guid("e37bea70-2004-4e22-a41d-673ba0ed4b54"), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000m, new Guid("2da77176-153d-4f44-a861-2712c1cc8236"), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3f16653b-cee7-4e1b-a18d-1f1a6087b393"), 10000m }
                });

            migrationBuilder.InsertData(
                table: "WorkingTime",
                columns: new[] { "Id", "ActualDaysWorked", "BusinessTrip", "DaysOff", "DaysWorked", "EmployeeId", "SickLeave", "Vacation" },
                values: new object[,]
                {
                    { new Guid("15621fc9-d759-4ed9-915e-226febbf9055"), 20, 4, 4, 31, new Guid("3f16653b-cee7-4e1b-a18d-1f1a6087b393"), 3, 0 },
                    { new Guid("7d353136-b2ab-42c2-9dc9-e476a81a767b"), 17, 4, 7, 31, new Guid("793068ec-f257-4361-a9e9-2904af794508"), 3, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vacations_EmployeeId",
                table: "Vacations",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vacations");

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("c1848d83-63c2-4d3d-82fe-89def4ba21a7"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("e37bea70-2004-4e22-a41d-673ba0ed4b54"));

            migrationBuilder.DeleteData(
                table: "WorkingTime",
                keyColumn: "Id",
                keyValue: new Guid("15621fc9-d759-4ed9-915e-226febbf9055"));

            migrationBuilder.DeleteData(
                table: "WorkingTime",
                keyColumn: "Id",
                keyValue: new Guid("7d353136-b2ab-42c2-9dc9-e476a81a767b"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("2da77176-153d-4f44-a861-2712c1cc8236"));

            migrationBuilder.DeleteData(
                table: "Employess",
                keyColumn: "Id",
                keyValue: new Guid("3f16653b-cee7-4e1b-a18d-1f1a6087b393"));

            migrationBuilder.DeleteData(
                table: "Employess",
                keyColumn: "Id",
                keyValue: new Guid("793068ec-f257-4361-a9e9-2904af794508"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("1915570f-8e81-41e3-a61a-fb22665ae811"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("d20dda2f-4db4-4ffd-89d7-209fa95eb60c"));

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
        }
    }
}
