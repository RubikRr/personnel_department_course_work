using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace personnel_department_DB.Migrations
{
    /// <inheritdoc />
    public partial class AddTransferTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Transfers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreviousWork = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewWork = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transfers_Employess_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_EmployeeId",
                table: "Transfers",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transfers");

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
    }
}
