using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMPLOYEE_ALL_ORGANIZATIONS_WITH_ENTITY.Entities
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EmployeeID { get; set; }
        [Column(TypeName = "Varchar(50)")]
        public string? EmployeeName { get; set; }
        public ICollection<EmployeeOrganization>? EmployeeOrganization { get; set; }
    }
}






//This is basically one to many relationship, many to one is just opposite.
//In one to one u have to declare obj of each other class in both classes
//In many to many u have to declare Icollection of both class in both of the classes