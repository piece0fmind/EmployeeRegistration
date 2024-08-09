﻿// <auto-generated />
using System;
using EmployeeRegistration.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeRegistration.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240809100212_AddedSeedData")]
    partial class AddedSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeRegistration.Models.AppEntities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Emp_Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Entry_By")
                        .HasColumnType("int");

                    b.Property<DateTime>("Entry_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeRegistration.Models.AppEntities.EmployeeQualification", b =>
                {
                    b.Property<int>("Employee_Id")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("Q_Id")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<float>("Marks")
                        .HasColumnType("real");

                    b.HasKey("Employee_Id", "Q_Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("Q_Id");

                    b.ToTable("EmployeeQualifications");
                });

            modelBuilder.Entity("EmployeeRegistration.Models.AppEntities.Qualification", b =>
                {
                    b.Property<int>("Q_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Q_Id"));

                    b.Property<string>("Q_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Q_Id");

                    b.ToTable("Qualifications");

                    b.HasData(
                        new
                        {
                            Q_Id = 1,
                            Q_Name = "SLC"
                        },
                        new
                        {
                            Q_Id = 2,
                            Q_Name = "Intermediate"
                        },
                        new
                        {
                            Q_Id = 3,
                            Q_Name = "BE"
                        },
                        new
                        {
                            Q_Id = 4,
                            Q_Name = "ME"
                        },
                        new
                        {
                            Q_Id = 5,
                            Q_Name = "PHD"
                        });
                });

            modelBuilder.Entity("EmployeeRegistration.Models.AppEntities.EmployeeQualification", b =>
                {
                    b.HasOne("EmployeeRegistration.Models.AppEntities.Employee", "Employee")
                        .WithMany("EmployeeQualifications")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeeRegistration.Models.AppEntities.Qualification", null)
                        .WithMany("EmployeeQualifications")
                        .HasForeignKey("Q_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EmployeeRegistration.Models.AppEntities.Employee", b =>
                {
                    b.Navigation("EmployeeQualifications");
                });

            modelBuilder.Entity("EmployeeRegistration.Models.AppEntities.Qualification", b =>
                {
                    b.Navigation("EmployeeQualifications");
                });
#pragma warning restore 612, 618
        }
    }
}
