using EntityFramework.Data.Entities;
using Microsoft.EntityFrameworkCore; // needed for using entity framwork

namespace EntityFramework.Data
{
    public class DemoDbContext : DbContext //DbContext is a predefined class we r inherting it to access its methods and properties.
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations { get; set; }
        public DemoDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-I3CUF5I;Initial Catalog=EntityFramework;Integrated Security=True");
        }
    }   
}