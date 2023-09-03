using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace personnel_department_DB.Migrations
{
    /// <inheritdoc />
    public partial class InitEmployeeAndWorkingTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("07963ef7-0894-4af5-a01c-a666a90bd686"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("59660276-57c2-4fb0-9f3a-f2769e28733d"));

            migrationBuilder.CreateTable(
                name: "Employess",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FIO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkExperience = table.Column<long>(type: "bigint", nullable: false),
                    PassportId = table.Column<long>(type: "bigint", nullable: false),
                    INH = table.Column<long>(type: "bigint", nullable: false),
                    FamilyComposition = table.Column<long>(type: "bigint", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceOfResidence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employess_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkingTime",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaysWorked = table.Column<int>(type: "int", nullable: false),
                    ActualDaysWorked = table.Column<int>(type: "int", nullable: false),
                    DaysOff = table.Column<int>(type: "int", nullable: false),
                    Vacation = table.Column<int>(type: "int", nullable: false),
                    BusinessTrip = table.Column<int>(type: "int", nullable: false),
                    SickLeave = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingTime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkingTime_Employess_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Employess_PositionId",
                table: "Employess",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkingTime_EmployeeId",
                table: "WorkingTime",
                column: "EmployeeId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkingTime");

            migrationBuilder.DropTable(
                name: "Employess");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("5ccd29d3-59fb-4161-a8d2-4b90323d50ce"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("c9155894-e047-4a81-972e-ed5f9308b15c"));

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("07963ef7-0894-4af5-a01c-a666a90bd686"), "Директор" },
                    { new Guid("59660276-57c2-4fb0-9f3a-f2769e28733d"), "Бухгалтер" }
                });
        }
    }
}
