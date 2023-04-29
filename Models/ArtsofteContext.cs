using Microsoft.EntityFrameworkCore;

namespace Artsofte.Models
{
    public class ArtsofteContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }

        public ArtsofteContext(DbContextOptions<ArtsofteContext> options)
        : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<EmployeeProgrammingLanguage>()
                .HasKey(epl => new { epl.EmployeeId, epl.ProgrammingLanguageId });

            modelBuilder.Entity<EmployeeProgrammingLanguage>()
                .HasOne(epl => epl.Employee)
                .WithMany(e => e.EmployeeProgrammingLanguages)
                .HasForeignKey(epl => epl.EmployeeId);

            modelBuilder.Entity<EmployeeProgrammingLanguage>()
                .HasOne(epl => epl.ProgrammingLanguage)
                .WithMany(pl => pl.EmployeeProgrammingLanguages)
                .HasForeignKey(epl => epl.ProgrammingLanguageId);
        }
    }
}

