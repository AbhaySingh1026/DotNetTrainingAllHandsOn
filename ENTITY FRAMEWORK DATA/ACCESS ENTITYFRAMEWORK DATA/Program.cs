using EntityFramework.Data;
using EntityFramework.Data.Entities;

namespace ConsoleApp1
{
    public class program
    {
        public static void Main()
        {
            CrudManager obj = new CrudManager();

            //Console.WriteLine("Adding a new Employee");
            //obj.Insert(new Employee { Name = "Utkarsh", Address = "Gurgaon" });
            //obj.Insert(new Employee { Name = "Abhimanyu", Address = "Delhi" });
            //PrintAllEmployees();

            //Console.WriteLine("Updating Employee with EmployeeId 2");
            //obj.Update(2, new Employee { Name = "Modified Employee", Address = "Modified Address" });
            //PrintAllEmployees();

            //Console.WriteLine("Retrieving Employee details for EmployeeId 2");
            //var employee = obj.GetEmplpoyeeById(2);
            //Console.WriteLine($"Employee Name of employee ID 2 is {employee.Name}");

            //Console.WriteLine("Deleting Employee details for EmployeeId 2");
            //obj.Delete(2);
            //PrintAllEmployees();
            //----------------------------------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("Adding a new Employee Education");
            Employee employee = new Employee();

            obj.InsertEducationDetails(new EmployeeEducation { CourseName = "Btech", UniversityName = "LPU", PassingYear = 2021, MarksPercentage = 80, EmployeeId = 1 });
            obj.InsertEducationDetails(new EmployeeEducation { CourseName = "B.sc", UniversityName = "CU", PassingYear = 2022, MarksPercentage = 90, EmployeeId = 2 });
            PrintAllEmployeeEducation();

            Console.WriteLine("Updating Education with EducationId 2");
            obj.UpdateEducationDetails(2, new EmployeeEducation { CourseName = "BTech", UniversityName = "LPU", PassingYear = 2023, MarksPercentage = 70, EmployeeId = 2 });
            PrintAllEmployeeEducation();

            Console.WriteLine("Retrieving Employee Education details for eduacation Id 2");
            var education = obj.GetEmployeeEducationById(2);
            Console.WriteLine($"Employee education details of education ID 2 is {education.CourseName}");

            Console.WriteLine("Deleting Employee eduation details for Employeeeducation Id 2");
            obj.DeleteEducationDetails(2);
            PrintAllEmployeeEducation();

            Console.ReadLine();
        }

        private static void PrintAllEmployees()
        {
            Console.WriteLine("Printing all Employees");
            CrudManager obj = new CrudManager();
            foreach (Employee employee in obj.GetAllEmployees())
            {
                Console.WriteLine($"Employee Name is {employee.Name} and address is {employee.Address}");
            }
        }
        private static void PrintAllEmployeeEducation()
        {
            Console.WriteLine("Printing all Employees Education details - ");
            CrudManager obj = new CrudManager();
            foreach (EmployeeEducation employeeEducation in obj.GetAllEmployeesEducation())
            {
                Console.WriteLine($"Emp CourseName is {employeeEducation.CourseName}, UniversityName is {employeeEducation.UniversityName}, PassingYear is {employeeEducation.PassingYear},MarksPercentage is {employeeEducation.MarksPercentage},Employee Id is - {employeeEducation.EmployeeId}");
            }
        }
    }
}