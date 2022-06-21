using Microsoft.EntityFrameworkCore;
using EMPLOYEE_ALL_ORGANIZATIONS_WITH_ENTITY.Entities;

namespace EMPLOYEE_ALL_ORGANIZATIONS_WITH_ENTITY
{
    public class MakingConnection : DbContext
    {
        public DbSet<Employee>? employees { get; set; }   //Table name goes from these properties Obj
        public DbSet<EmployeeOrganization>? employeeOrganizations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-I3CUF5I;Initial Catalog=EntityFramework;Integrated Security=True");
        }
        //protected override void OnModelCreating(ModelBuilder builder)  //By this u can set any constraint to any column
        //{
        //    builder.Entity<Employee>(entity => {
        //        entity.HasIndex(e => e.EmployeeID).IsUnique();  //here Employeeid if Employees Table put as uique
        //    });
        //}
    }
}