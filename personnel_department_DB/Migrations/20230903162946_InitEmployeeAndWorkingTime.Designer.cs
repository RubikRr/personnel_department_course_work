﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using personnel_department_DB;

#nullable disable

namespace personnel_department_DB.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230903162946_InitEmployeeAndWorkingTime")]
    partial class InitEmployeeAndWorkingTime
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                            Id = new Guid("b404163e-52a5-4e06-b79a-28305acbbf2c"),
                            DateOfBirth = new DateTime(2003, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FIO = "Василий Петрович Вознесенский",
                            FamilyComposition = 2L,
                            INH = 1234567890L,
                            PassportId = 11148L,
                            PhoneNumber = "+7 919 922 32 23",
                            PlaceOfResidence = "Пр.Мира 1",
                            PositionId = new Guid("c9155894-e047-4a81-972e-ed5f9308b15c"),
                            WorkExperience = 12L
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
                            Id = new Guid("c9155894-e047-4a81-972e-ed5f9308b15c"),
                            Name = "Директор"
                        },
                        new
                        {
                            Id = new Guid("5ccd29d3-59fb-4161-a8d2-4b90323d50ce"),
                            Name = "Бухгалтер"
                        });
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
                            Id = new Guid("dd2ab228-f063-4101-bf51-2189281bece3"),
                            ActualDaysWorked = 20,
                            BusinessTrip = 4,
                            DaysOff = 4,
                            DaysWorked = 31,
                            EmployeeId = new Guid("b404163e-52a5-4e06-b79a-28305acbbf2c"),
                            SickLeave = 3,
                            Vacation = 0
                        });
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
                    b.Navigation("WorkingTimeTable")
                        .IsRequired();
                });

            modelBuilder.Entity("personnel_department_DB.Models.Position", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
