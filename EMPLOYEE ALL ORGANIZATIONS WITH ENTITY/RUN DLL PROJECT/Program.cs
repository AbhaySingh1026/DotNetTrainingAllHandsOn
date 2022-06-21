using EMPLOYEE_ALL_ORGANIZATIONS_WITH_ENTITY.Entities;
using EMPLOYEE_ALL_ORGANIZATIONS_WITH_ENTITY;

namespace RunDllProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TOP:
            AllMethods allMethods = new AllMethods();
            Console.WriteLine("1. Insert Emp Full Details\n2. Update Emp Full Details\n3. Delete 1 Emp All Details\n4. Show 1 Emp Full Details\n5. Show All Emp Full Details\n6. Close App");
            switch (Console.ReadLine())
            {
                case "1": allMethods.InsertEmployeeWithOrganization();
                    break;
                case "2": allMethods.UpdateEmployeeAndOrgnization();
                    break;
                case "3": allMethods.DeleteEmployee();
                    break;
                case "4": allMethods.ShowAnEmpFullDetails();
                    break;
                case "5": allMethods.ShowAllEmployeeDetails();
                    break;
                case "6":return;
                    break;
                default:Console.WriteLine("Entered Wrog Option, Please Try Again - ");
                    goto TOP;
            }goto TOP;
        }
    }
}