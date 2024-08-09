using EmployeeRegistration.Models.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Reflection.Metadata;

namespace EmployeeRegistration.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeQualification>()
                  .HasKey(m => new { m.Employee_Id, m.Q_Id });
            modelBuilder.Entity<Qualification>()
                .HasData(
                    new Qualification { Q_Id =1,Q_Name="SLC"},
                    new Qualification { Q_Id =2,Q_Name="Intermediate"},
                    new Qualification { Q_Id =3,Q_Name="BE"},
                    new Qualification { Q_Id =4,Q_Name="ME"},
                    new Qualification { Q_Id =5,Q_Name="PHD"}
                );

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<EmployeeQualification> EmployeeQualifications { get; set; }

    }
}
