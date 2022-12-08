using EmployeeGrapQL.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeGrapQL.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeSkill> EmployeeSkills { get; set; }
        public DbSet<EmployeeSalary> EmployeeSalaries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne<Department>(e => e.department)
                .WithOne(d => d.Employee)
                .HasForeignKey<Department>(d => d.EmployeeId);

            modelBuilder.Entity<Employee>()
                .HasOne<EmployeeSalary>(e => e.EmployeeSalary)
                .WithOne(es => es.Employee)
                .HasForeignKey<EmployeeSalary>(es => es.EmployeeId);

            modelBuilder.Entity<Employee>()
                .HasMany<EmployeeSkill>(a => a.EmployeeSkill)
                .WithOne(es => es.Employee)
                .HasForeignKey(es => es.EmployeeId);
               
        }

    }
}
