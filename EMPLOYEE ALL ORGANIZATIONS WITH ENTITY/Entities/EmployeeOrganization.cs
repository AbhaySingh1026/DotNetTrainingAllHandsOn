using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMPLOYEE_ALL_ORGANIZATIONS_WITH_ENTITY.Entities
{
    public class EmployeeOrganization
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]     //if u want 2 set start identity custom thn use this otherwise [Key] will set primary key & also set inc. starting frm 1
        [Key]                                                             //primary key 
        public int EmployeeOrganizationID { get; set; }
        [Column(TypeName = "Varchar(50)")]                        //For Setting Datatype
        public string? EmployeeOrganizationName { get; set; }
        [Required]                                                 //Not null
        public Employee? Employee { get; set; }
    }
}
