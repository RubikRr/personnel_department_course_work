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
                            Id = new Guid("8106134b-f105-4d06-af94-245b2d68f6cc"),
                            Name = "ООО Рубик экспресс"
                        });
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
                            Id = new Guid("b364fe04-0315-4557-a6c8-938ed5a7b7dc"),
                            DateOfBirth = new DateTime(2003, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FIO = "Василий Петрович Вознесенский",
                            FamilyComposition = 2L,
                            INH = 1234567890L,
                            PassportId = 11148L,
                            PhoneNumber = "+7 919 922 32 23",
                            PlaceOfResidence = "Пр.Мира 1",
                            PositionId = new Guid("a202ff11-65c3-4864-b2cf-201ab78d0683"),
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
                            Id = new Guid("a202ff11-65c3-4864-b2cf-201ab78d0683"),
                            Name = "Директор"
                        },
                        new
                        {
                            Id = new Guid("3cd4ac57-5eee-4f21-a596-dec9badf4cf5"),
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
                            Id = new Guid("613325b5-9136-4fc6-9970-46975ab4a196"),
                            ActualDaysWorked = 20,
                            BusinessTrip = 4,
                            DaysOff = 4,
                            DaysWorked = 31,
                            EmployeeId = new Guid("b364fe04-0315-4557-a6c8-938ed5a7b7dc"),
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
