using Microsoft.EntityFrameworkCore;
using PIMToolCodeBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using static Pim_Tool.Enums.Enums;

namespace PIMToolCodeBase.Database {
    /// <summary>
    ///     DbContext of PIMTool.
    /// </summary>
    public class PimContext : DbContext {
        public PimContext (DbContextOptions<PimContext> options) : base(options) {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Project_Employee> ProjectEmployees { get; set; }

        public override int SaveChanges () {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            //Increment Version
            foreach (var entityEntry in entries) {
                if (entityEntry.State == EntityState.Modified) {
                    ((BaseEntity)entityEntry.Entity).Version += 1;
                }
            }

            return base.SaveChanges();
        }

        public void ProjectModelCreating (ModelBuilder modelBuilder) {
            //Table name
            modelBuilder.Entity<Project>().ToTable(nameof(Project).ToUpper());
            //Column Property
            modelBuilder.Entity<Project>(p => {
                //Primary Key & Version
                p.Property(p => p.Id).HasColumnName("ID").HasColumnType("decimal(19,0)").IsRequired().UseIdentityColumn();

                p.Property(p => p.Version).HasColumnName("VERSION").HasColumnType("decimal(10,0)").IsRequired().IsConcurrencyToken();

                //Column
                p.Property(p => p.ProjectNumber).IsRequired().HasColumnName("PROJECT_NUMBER").HasColumnType("decimal(4,0)");
                p.Property(p => p.Name).IsRequired().HasColumnName("NAME").HasColumnType("varchar(50)");
                p.Property(p => p.Customer).IsRequired().HasColumnName("CUSTOMER").HasColumnType("varchar(50)");
                p.Property(p => p.Status).IsRequired().HasColumnName("STATUS").HasColumnType("char(3)").HasDefaultValue(ProjectStatus.NEW)
                .HasConversion(s => s.ToString(), s => (ProjectStatus)Enum.Parse(typeof(ProjectStatus), s));
                p.Property(p => p.StartDate).IsRequired().HasColumnName("START_DATE").HasColumnType("date");
                p.Property(p => p.EndDate).HasColumnName("END_DATE").HasColumnType("date");
                p.Property(p => p.GroupId).IsRequired().HasColumnName("GROUP_ID").HasColumnType("decimal(19,0)");

                //Foreign Key
                p.HasOne<Group>(p => p.Group)
                .WithMany(g => g.Projects)
                .HasForeignKey(p => p.GroupId);

                //Constraint
                p.HasIndex(p => p.ProjectNumber)
                .IsUnique();

                p.HasCheckConstraint<Project>("CK_Project_Status",
                    "STATUS='NEW'" +
                "OR STATUS='PLA'" +
                "OR STATUS='INP'" +
                "OR STATUS='FIN'");

                p.Property(p => p.Version).HasDefaultValue(1);

            });
            // Seed Data
            var seedProjects = new List<Project>();
            for (int i = 1; i <= 10; i++) {
                seedProjects.Add(
                    new Project {
                        Id = i,
                        Name = $"Test{i}",
                        ProjectNumber = i,
                        Customer = $"Customer{i}",
                        Status = ProjectStatus.PLA,
                        StartDate = System.DateTime.Now,
                        GroupId = 1,
                    }
                    );
            }
            modelBuilder.Entity<Project>()
                .HasData(seedProjects);

        }

        public void GroupModelCreating (ModelBuilder modelBuilder) {
            // Table Name
            modelBuilder.Entity<Group>().ToTable(nameof(Group).ToUpper());
            // Column Property
            modelBuilder.Entity<Group>(g => {
                //Primary Key & Version
                g.Property(g => g.Id).HasColumnName("ID").HasColumnType("decimal(19,0)").IsRequired().UseIdentityColumn();

                g.Property(g => g.Version).HasColumnName("VERSION").HasColumnType("decimal(10,0)").IsRequired().IsConcurrencyToken();

                //Column
                g.Property(g => g.GroupLeaderId).HasColumnName("GROUP_LEADER_ID").HasColumnType("decimal(19,0)").IsRequired();

                //Foreign Key
                g.HasOne<Employee>(g => g.GroupLeader)
                .WithOne(e => e.GroupLed)
                .HasForeignKey<Group>(g => g.GroupLeaderId);

                //Constraint
                g.Property(g => g.Version).HasDefaultValue(1);
            });
            // Seed Data
            var seedGroups = new List<Group>();
            for (int i = 1; i <= 2; i++) {
                seedGroups.Add(
                    new Group {
                        Id = i,
                        GroupLeaderId = i,
                    }
                    );
            }
            modelBuilder.Entity<Group>()
                .HasData(seedGroups);

        }

        public void EmployeeModelCreating (ModelBuilder modelBuilder) {
            // Table Name
            modelBuilder.Entity<Employee>().ToTable(nameof(Employee).ToUpper());
            // Column Property
            modelBuilder.Entity<Employee>(e => {
                //Primary Key & Version
                e.Property(e => e.Id).HasColumnName("ID").HasColumnType("decimal(19,0)").IsRequired().UseIdentityColumn();

                e.Property(e => e.Version).HasColumnName("VERSION").HasColumnType("decimal(10,0)").IsRequired().IsConcurrencyToken();

                //Column
                e.Property(e => e.Visa).IsRequired().HasColumnName("VISA").HasColumnType("char(3)");
                e.Property(e => e.FirstName).IsRequired().HasColumnName("FIRST_NAME").HasColumnType("varchar(50)");
                e.Property(e => e.LastName).IsRequired().HasColumnName("LAST_NAME").HasColumnType("varchar(50)");
                e.Property(e => e.BirthDate).IsRequired().HasColumnName("BIRTH_DAY").HasColumnType("date");

                //Constraint
                e.Property(e => e.Version).HasDefaultValue(1);
            });
            // Seed Data
            var seedEmployees = new List<Employee>();
            for (int i = 1; i <= 9; i++) {
                seedEmployees.Add(
                    new Employee {
                        Id = i,
                        Visa = $"AB{i}",
                        FirstName = $"FirstName{i}",
                        LastName = $"LastName{i}",
                        BirthDate = System.DateTime.Now,
                    }
                    ); ;
            }
            modelBuilder.Entity<Employee>()
                .HasData(seedEmployees);
        }

        public void ProjectEmployeeModelCreating (ModelBuilder modelBuilder) {
            // Table Name
            modelBuilder.Entity<Project_Employee>().ToTable(nameof(Project_Employee).ToUpper());
            // Column Property
            modelBuilder.Entity<Project_Employee>(pe => {
                //Primary Key
                pe.HasKey(pe => new { pe.ProjectId, pe.EmployeeId });

                //Column
                pe.Ignore(pe => pe.Id);
                pe.Ignore(pe => pe.Version);

                pe.Property(pe => pe.ProjectId).IsRequired().HasColumnName("PROJECT_ID").HasColumnType("decimal(19,0)");
                pe.Property(pe => pe.EmployeeId).IsRequired().HasColumnName("EMPLOYEE_ID").HasColumnType("decimal(19,0)");
                //Foreign Key                
                pe.HasOne<Employee>(pe => pe.Employee)
                .WithMany(e => e.ProjectEmployees)
                .HasForeignKey(pe => pe.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);

                pe.HasOne<Project>(pe => pe.Project)
                .WithMany(p => p.ProjectEmployees)
                .HasForeignKey(e => e.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);
            });
            // Seed Data
            var seedProjectEmployeess = new List<Project_Employee>();
            seedProjectEmployeess.Add(
                    new Project_Employee {
                        ProjectId = 1,
                        EmployeeId = 1,
                    }
                    );
            seedProjectEmployeess.Add(
                    new Project_Employee {
                        ProjectId = 1,
                        EmployeeId = 2,
                    }
                    );
            seedProjectEmployeess.Add(
                    new Project_Employee {
                        ProjectId = 2,
                        EmployeeId = 2,
                    }
                    );
            seedProjectEmployeess.Add(
                    new Project_Employee {
                        ProjectId = 3,
                        EmployeeId = 2,
                    }
                    );
            modelBuilder.Entity<Project_Employee>()
                .HasData(seedProjectEmployeess);

        }
        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            //Project
            ProjectModelCreating(modelBuilder);

            //Group
            GroupModelCreating(modelBuilder);

            //Employee
            EmployeeModelCreating(modelBuilder);

            //ProjectEmployee
            ProjectEmployeeModelCreating(modelBuilder);
        }
    }
}