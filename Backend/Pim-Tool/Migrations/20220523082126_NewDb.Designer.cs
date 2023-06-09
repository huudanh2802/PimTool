﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PIMToolCodeBase.Database;

namespace Pim_Tool.Migrations
{
    [DbContext(typeof(PimContext))]
    [Migration("20220523082126_NewDb")]
    partial class NewDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PIMToolCodeBase.Domain.Entities.Employee", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(19,0)")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birth_date")
                        .HasColumnType("date")
                        .HasColumnName("BIRTH_DAY");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("FIRST_NAME");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("LAST_NAME");

                    b.Property<decimal>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(10,0)")
                        .HasDefaultValue(1m)
                        .HasColumnName("VERSION");

                    b.Property<string>("Visa")
                        .IsRequired()
                        .HasColumnType("char(3)")
                        .HasColumnName("VISA");

                    b.HasKey("Id");

                    b.ToTable("EMPLOYEE");

                    b.HasData(
                        new
                        {
                            Id = 1m,
                            Birth_date = new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1166),
                            First_Name = "FirstName1",
                            Last_Name = "LastName1",
                            Version = 0m,
                            Visa = "AB1"
                        },
                        new
                        {
                            Id = 2m,
                            Birth_date = new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1444),
                            First_Name = "FirstName2",
                            Last_Name = "LastName2",
                            Version = 0m,
                            Visa = "AB2"
                        },
                        new
                        {
                            Id = 3m,
                            Birth_date = new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1451),
                            First_Name = "FirstName3",
                            Last_Name = "LastName3",
                            Version = 0m,
                            Visa = "AB3"
                        },
                        new
                        {
                            Id = 4m,
                            Birth_date = new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1493),
                            First_Name = "FirstName4",
                            Last_Name = "LastName4",
                            Version = 0m,
                            Visa = "AB4"
                        },
                        new
                        {
                            Id = 5m,
                            Birth_date = new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1496),
                            First_Name = "FirstName5",
                            Last_Name = "LastName5",
                            Version = 0m,
                            Visa = "AB5"
                        },
                        new
                        {
                            Id = 6m,
                            Birth_date = new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1501),
                            First_Name = "FirstName6",
                            Last_Name = "LastName6",
                            Version = 0m,
                            Visa = "AB6"
                        },
                        new
                        {
                            Id = 7m,
                            Birth_date = new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1505),
                            First_Name = "FirstName7",
                            Last_Name = "LastName7",
                            Version = 0m,
                            Visa = "AB7"
                        },
                        new
                        {
                            Id = 8m,
                            Birth_date = new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1508),
                            First_Name = "FirstName8",
                            Last_Name = "LastName8",
                            Version = 0m,
                            Visa = "AB8"
                        },
                        new
                        {
                            Id = 9m,
                            Birth_date = new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1510),
                            First_Name = "FirstName9",
                            Last_Name = "LastName9",
                            Version = 0m,
                            Visa = "AB9"
                        });
                });

            modelBuilder.Entity("PIMToolCodeBase.Domain.Entities.Group", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(19,0)")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Group_Leader_id")
                        .HasColumnType("decimal(19,0)")
                        .HasColumnName("GROUP_LEADER_ID");

                    b.Property<decimal>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(10,0)")
                        .HasDefaultValue(1m)
                        .HasColumnName("VERSION");

                    b.HasKey("Id");

                    b.HasIndex("Group_Leader_id")
                        .IsUnique();

                    b.ToTable("GROUP");

                    b.HasData(
                        new
                        {
                            Id = 1m,
                            Group_Leader_id = 1m,
                            Version = 0m
                        },
                        new
                        {
                            Id = 2m,
                            Group_Leader_id = 2m,
                            Version = 0m
                        });
                });

            modelBuilder.Entity("PIMToolCodeBase.Domain.Entities.Project", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(19,0)")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Customer")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("CUSTOMER");

                    b.Property<DateTime?>("End_date")
                        .HasColumnType("date")
                        .HasColumnName("END_DATE");

                    b.Property<decimal>("Group_ID")
                        .HasColumnType("decimal(19,0)")
                        .HasColumnName("GROUP_ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("NAME");

                    b.Property<decimal>("Project_Number")
                        .HasColumnType("decimal(4,0)")
                        .HasColumnName("PROJECT_NUMBER");

                    b.Property<DateTime>("Start_date")
                        .HasColumnType("date")
                        .HasColumnName("START_DATE");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(3)")
                        .HasDefaultValue("NEW")
                        .HasColumnName("STATUS");

                    b.Property<decimal>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(10,0)")
                        .HasDefaultValue(1m)
                        .HasColumnName("VERSION");

                    b.HasKey("Id");

                    b.HasIndex("Group_ID");

                    b.HasIndex("Project_Number")
                        .IsUnique();

                    b.ToTable("PROJECT");

                    b.HasCheckConstraint("CK_Project_Status", "STATUS='NEW'OR STATUS='PLA'OR STATUS='INP'OR STATUS='FIN'");

                    b.HasData(
                        new
                        {
                            Id = 1m,
                            Customer = "Customer1",
                            Group_ID = 1m,
                            Name = "Test1",
                            Project_Number = 1m,
                            Start_date = new DateTime(2022, 5, 23, 15, 21, 26, 343, DateTimeKind.Local).AddTicks(4773),
                            Status = "FIN",
                            Version = 0m
                        },
                        new
                        {
                            Id = 2m,
                            Customer = "Customer2",
                            Group_ID = 1m,
                            Name = "Test2",
                            Project_Number = 2m,
                            Start_date = new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(80),
                            Status = "FIN",
                            Version = 0m
                        },
                        new
                        {
                            Id = 3m,
                            Customer = "Customer3",
                            Group_ID = 1m,
                            Name = "Test3",
                            Project_Number = 3m,
                            Start_date = new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(95),
                            Status = "FIN",
                            Version = 0m
                        },
                        new
                        {
                            Id = 4m,
                            Customer = "Customer4",
                            Group_ID = 1m,
                            Name = "Test4",
                            Project_Number = 4m,
                            Start_date = new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(99),
                            Status = "FIN",
                            Version = 0m
                        },
                        new
                        {
                            Id = 5m,
                            Customer = "Customer5",
                            Group_ID = 1m,
                            Name = "Test5",
                            Project_Number = 5m,
                            Start_date = new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(101),
                            Status = "FIN",
                            Version = 0m
                        },
                        new
                        {
                            Id = 6m,
                            Customer = "Customer6",
                            Group_ID = 1m,
                            Name = "Test6",
                            Project_Number = 6m,
                            Start_date = new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(106),
                            Status = "FIN",
                            Version = 0m
                        },
                        new
                        {
                            Id = 7m,
                            Customer = "Customer7",
                            Group_ID = 1m,
                            Name = "Test7",
                            Project_Number = 7m,
                            Start_date = new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(109),
                            Status = "FIN",
                            Version = 0m
                        },
                        new
                        {
                            Id = 8m,
                            Customer = "Customer8",
                            Group_ID = 1m,
                            Name = "Test8",
                            Project_Number = 8m,
                            Start_date = new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(111),
                            Status = "FIN",
                            Version = 0m
                        },
                        new
                        {
                            Id = 9m,
                            Customer = "Customer9",
                            Group_ID = 1m,
                            Name = "Test9",
                            Project_Number = 9m,
                            Start_date = new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(114),
                            Status = "FIN",
                            Version = 0m
                        },
                        new
                        {
                            Id = 10m,
                            Customer = "Customer10",
                            Group_ID = 1m,
                            Name = "Test10",
                            Project_Number = 10m,
                            Start_date = new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(118),
                            Status = "FIN",
                            Version = 0m
                        });
                });

            modelBuilder.Entity("PIMToolCodeBase.Domain.Entities.ProjectEmployee", b =>
                {
                    b.Property<decimal>("Project_ID")
                        .HasColumnType("decimal(19,0)")
                        .HasColumnName("PROJECT_ID");

                    b.Property<decimal>("Employee_ID")
                        .HasColumnType("decimal(19,0)")
                        .HasColumnName("EMPLOYEE_ID");

                    b.HasKey("Project_ID", "Employee_ID");

                    b.HasIndex("Employee_ID");

                    b.ToTable("PROJECT_EMPLOYEE");

                    b.HasData(
                        new
                        {
                            Project_ID = 1m,
                            Employee_ID = 1m
                        },
                        new
                        {
                            Project_ID = 1m,
                            Employee_ID = 2m
                        },
                        new
                        {
                            Project_ID = 2m,
                            Employee_ID = 2m
                        },
                        new
                        {
                            Project_ID = 3m,
                            Employee_ID = 2m
                        });
                });

            modelBuilder.Entity("Pim_Tool.Dtos.AddProjectDto", b =>
                {
                    b.Property<decimal?>("Id")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Customer")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("End_date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Group_ID")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Project_Number")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Start_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("Id");

                    b.ToTable("ProjectDTO");
                });

            modelBuilder.Entity("PIMToolCodeBase.Domain.Entities.Group", b =>
                {
                    b.HasOne("PIMToolCodeBase.Domain.Entities.Employee", "Group_Leader")
                        .WithOne("GroupLed")
                        .HasForeignKey("PIMToolCodeBase.Domain.Entities.Group", "Group_Leader_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group_Leader");
                });

            modelBuilder.Entity("PIMToolCodeBase.Domain.Entities.Project", b =>
                {
                    b.HasOne("PIMToolCodeBase.Domain.Entities.Group", "Group")
                        .WithMany("Projects")
                        .HasForeignKey("Group_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("PIMToolCodeBase.Domain.Entities.ProjectEmployee", b =>
                {
                    b.HasOne("PIMToolCodeBase.Domain.Entities.Employee", "Employee")
                        .WithMany("ProjectEmployee")
                        .HasForeignKey("Employee_ID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PIMToolCodeBase.Domain.Entities.Project", "Project")
                        .WithMany("ProjectEmployee")
                        .HasForeignKey("Project_ID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("PIMToolCodeBase.Domain.Entities.Employee", b =>
                {
                    b.Navigation("GroupLed");

                    b.Navigation("ProjectEmployee");
                });

            modelBuilder.Entity("PIMToolCodeBase.Domain.Entities.Group", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("PIMToolCodeBase.Domain.Entities.Project", b =>
                {
                    b.Navigation("ProjectEmployee");
                });
#pragma warning restore 612, 618
        }
    }
}
