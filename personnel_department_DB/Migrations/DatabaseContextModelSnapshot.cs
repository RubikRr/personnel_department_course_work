﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using personnel_department_DB;

#nullable disable

namespace personnel_department_DB.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("personnel_department_DB.Models.BusinessTtrip", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Funds")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Target")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Term")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("BusinessTrips");
                });

            modelBuilder.Entity("personnel_department_DB.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2da77176-153d-4f44-a861-2712c1cc8236"),
                            Name = "ООО Рубик экспресс"
                        });
                });

            modelBuilder.Entity("personnel_department_DB.Models.Contract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AcceptanceDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Allowance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfPreparation")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Contracts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e37bea70-2004-4e22-a41d-673ba0ed4b54"),
                            AcceptanceDate = new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Allowance = 2000m,
                            CompanyId = new Guid("2da77176-153d-4f44-a861-2712c1cc8236"),
                            DateOfPreparation = new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = new Guid("3f16653b-cee7-4e1b-a18d-1f1a6087b393"),
                            Salary = 10000m
                        },
                        new
                        {
                            Id = new Guid("c1848d83-63c2-4d3d-82fe-89def4ba21a7"),
                            AcceptanceDate = new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Allowance = 1000m,
                            CompanyId = new Guid("2da77176-153d-4f44-a861-2712c1cc8236"),
                            DateOfPreparation = new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = new Guid("793068ec-f257-4361-a9e9-2904af794508"),
                            Salary = 60000m
                        });
                });

            modelBuilder.Entity("personnel_department_DB.Models.Dismissal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Base")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfDismissal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfPreparation")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Pay")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique()
                        .HasFilter("[EmployeeId] IS NOT NULL");

                    b.ToTable("Dismissals");
                });

            modelBuilder.Entity("personnel_department_DB.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FamilyComposition")
                        .HasColumnType("bigint");

                    b.Property<long>("INH")
                        .HasColumnType("bigint");

                    b.Property<long>("PassportId")
                        .HasColumnType("bigint");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfResidence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PositionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("WorkExperience")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Employess");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3f16653b-cee7-4e1b-a18d-1f1a6087b393"),
                            DateOfBirth = new DateTime(2003, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FIO = "Василий Петрович Вознесенский",
                            FamilyComposition = 2L,
                            INH = 1234567890L,
                            PassportId = 11148L,
                            PhoneNumber = "+7 919 922 32 23",
                            PlaceOfResidence = "Пр.Мира 1",
                            PositionId = new Guid("1915570f-8e81-41e3-a61a-fb22665ae811"),
                            WorkExperience = 12L
                        },
                        new
                        {
                            Id = new Guid("793068ec-f257-4361-a9e9-2904af794508"),
                            DateOfBirth = new DateTime(2001, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FIO = "Владимир Сергеевич Алханчуртов",
                            FamilyComposition = 3L,
                            INH = 1292374892L,
                            PassportId = 22233L,
                            PhoneNumber = "+9 123 653 12 22",
                            PlaceOfResidence = "Пр.Коста 1",
                            PositionId = new Guid("d20dda2f-4db4-4ffd-89d7-209fa95eb60c"),
                            WorkExperience = 7L
                        });
                });

            modelBuilder.Entity("personnel_department_DB.Models.Position", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1915570f-8e81-41e3-a61a-fb22665ae811"),
                            Name = "Директор"
                        },
                        new
                        {
                            Id = new Guid("d20dda2f-4db4-4ffd-89d7-209fa95eb60c"),
                            Name = "Бухгалтер"
                        });
                });

            modelBuilder.Entity("personnel_department_DB.Models.Transfer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NewWork")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreviousWork")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Transfers");
                });

            modelBuilder.Entity("personnel_department_DB.Models.Vacation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateoOPreparation")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Payment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Vacations");
                });

            modelBuilder.Entity("personnel_department_DB.Models.WorkingTime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ActualDaysWorked")
                        .HasColumnType("int");

                    b.Property<int>("BusinessTrip")
                        .HasColumnType("int");

                    b.Property<int>("DaysOff")
                        .HasColumnType("int");

                    b.Property<int>("DaysWorked")
                        .HasColumnType("int");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SickLeave")
                        .HasColumnType("int");

                    b.Property<int>("Vacation")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("WorkingTime");

                    b.HasData(
                        new
                        {
                            Id = new Guid("15621fc9-d759-4ed9-915e-226febbf9055"),
                            ActualDaysWorked = 20,
                            BusinessTrip = 4,
                            DaysOff = 4,
                            DaysWorked = 31,
                            EmployeeId = new Guid("3f16653b-cee7-4e1b-a18d-1f1a6087b393"),
                            SickLeave = 3,
                            Vacation = 0
                        },
                        new
                        {
                            Id = new Guid("7d353136-b2ab-42c2-9dc9-e476a81a767b"),
                            ActualDaysWorked = 17,
                            BusinessTrip = 4,
                            DaysOff = 7,
                            DaysWorked = 31,
                            EmployeeId = new Guid("793068ec-f257-4361-a9e9-2904af794508"),
                            SickLeave = 3,
                            Vacation = 0
                        });
                });

            modelBuilder.Entity("personnel_department_DB.Models.BusinessTtrip", b =>
                {
                    b.HasOne("personnel_department_DB.Models.Employee", "Employee")
                        .WithMany("BusinessTtrips")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("personnel_department_DB.Models.Contract", b =>
                {
                    b.HasOne("personnel_department_DB.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("personnel_department_DB.Models.Employee", "Employee")
                        .WithOne("Contract")
                        .HasForeignKey("personnel_department_DB.Models.Contract", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("personnel_department_DB.Models.Dismissal", b =>
                {
                    b.HasOne("personnel_department_DB.Models.Employee", "Employee")
                        .WithOne("Dismissal")
                        .HasForeignKey("personnel_department_DB.Models.Dismissal", "EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("personnel_department_DB.Models.Employee", b =>
                {
                    b.HasOne("personnel_department_DB.Models.Position", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");
                });

            modelBuilder.Entity("personnel_department_DB.Models.Transfer", b =>
                {
                    b.HasOne("personnel_department_DB.Models.Employee", "Employee")
                        .WithMany("Ttransfers")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("personnel_department_DB.Models.Vacation", b =>
                {
                    b.HasOne("personnel_department_DB.Models.Employee", "Employee")
                        .WithMany("Vacations")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("personnel_department_DB.Models.WorkingTime", b =>
                {
                    b.HasOne("personnel_department_DB.Models.Employee", "Employee")
                        .WithOne("WorkingTimeTable")
                        .HasForeignKey("personnel_department_DB.Models.WorkingTime", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("personnel_department_DB.Models.Employee", b =>
                {
                    b.Navigation("BusinessTtrips");

                    b.Navigation("Contract");

                    b.Navigation("Dismissal");

                    b.Navigation("Ttransfers");

                    b.Navigation("Vacations");

                    b.Navigation("WorkingTimeTable");
                });

            modelBuilder.Entity("personnel_department_DB.Models.Position", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
