using EMPLOYEE_ALL_ORGANIZATIONS_WITH_ENTITY.Entities;
using Microsoft.EntityFrameworkCore;

namespace EMPLOYEE_ALL_ORGANIZATIONS_WITH_ENTITY
{
    public class AllMethods
    {
        private MakingConnection _connection;
        public AllMethods()
        {
            _connection = new MakingConnection();
        }
        public void InsertEmployeeWithOrganization()
        {
            Employee employee = new Employee();
            Console.Write("Enter Employee Name - ");
            employee.EmployeeName = Console.ReadLine();
            Console.Write("Enter Previoud Organization - ");
            string store = Console.ReadLine();
            _connection.employees.Add(employee);
            _connection.SaveChanges();
            List<EmployeeOrganization> educationDetailList = new List<EmployeeOrganization>
            {
                new EmployeeOrganization{EmployeeOrganizationName = store,Employee = employee}
            };
            _connection.employeeOrganizations.AddRange(educationDetailList);
            _connection.SaveChanges();
            Console.WriteLine("Record Inserted");
        }
        public void ShowAnEmpFullDetails()
        {
            Console.Write("Enter Emp Id - ");
            int id = Convert.ToInt32(Console.ReadLine());
            var objEmployee = _connection.employees.Where(x => x.EmployeeID == id).Include(e => e.EmployeeOrganization).First();  //This is called Lazy Loading, It also includes data from its corresponding table, So its more efficient to detch like this.
            Console.WriteLine($"Name of Employee is {objEmployee.EmployeeName} :");
            foreach (EmployeeOrganization organization in objEmployee.EmployeeOrganization)
            {
                Console.WriteLine($"Name of Organization is {organization.EmployeeOrganizationName}");
            }
        }
        public void ShowAllEmployeeDetails()
        {
            var empl = _connection.employees.Include(e => e.EmployeeOrganization).ToList();
            if (empl != null)
            {
                foreach (Employee emp in empl)
                {
                    Console.WriteLine("Employe Name   :" + emp.EmployeeName);
                    foreach (EmployeeOrganization employeeOrganizations in emp.EmployeeOrganization)
                    {
                        Console.WriteLine("Employee Organization  :" + employeeOrganizations.EmployeeOrganizationName);
                    }
                    Console.WriteLine("\n");
                }
            }
            else
            {
                Console.WriteLine(" Record not Found with Id :");
            }
        }
        public void DeleteEmployee()
        {
            Console.Write("Enter Emp Id - ");
            int empId = Convert.ToInt32(Console.ReadLine());
            var delEmp = _connection.employees.Where(x => x.EmployeeID == empId).Include(e => e.EmployeeOrganization).First();   //Lazy loading
            if (delEmp != null)
            {
                _connection.employees.Remove(delEmp);
                delEmp.EmployeeOrganization.Clear();
                _connection.SaveChanges();
            }
            else
            {
                Console.WriteLine("No Record Found With This Id : " + empId);
            }
        }
        public void UpdateEmployeeAndOrgnization()
        {
            Console.Write("Enter Emp Id - ");
            int empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Emp Name - ");
            string empname = Console.ReadLine();
            Console.Write("Enter New Org. Name - ");
            string org = Console.ReadLine();
            List<EmployeeOrganization> UpdateList = new List<EmployeeOrganization> { new EmployeeOrganization { EmployeeOrganizationName = org} };
            var updateemp = _connection.employees.Where(emp => emp.EmployeeID == empId).Include(e => e.EmployeeOrganization).First();
            if (updateemp != null)
            {
                updateemp.EmployeeName = empname;
                updateemp.EmployeeOrganization = UpdateList;
                _connection.employees.Update(updateemp);
                _connection.SaveChanges();
            }
            else
            {
                Console.WriteLine(" No Record Exist With This Id " + empId);
            }

        }
    }
}
