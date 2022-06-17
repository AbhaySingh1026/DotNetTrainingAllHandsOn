using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODUCT_SALES_BY_ADO.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tableName;
        TOP:
            Console.WriteLine("WELCOME TO PRODUCT & SALES MANAGEMENT PORTAL, PLEASE SELECT WHAT YOU WANT TO MANAGE ? -\n1. Product\n2. Sales\n3. Close Application");
            switch (Console.ReadLine())
            {
                case "1":
                    tableName = "Product";
                    ShowOptions(tableName);
                    break;
                case "2":
                    tableName = "Sales";
                    ShowOptions(tableName);
                    break;
                case "3": return;
                default: Console.WriteLine("Oops.. you entered wrong option, Please try again.");
                    goto TOP;
            }
            goto TOP;
        }
        static void ShowOptions(string tableName)
        {
            AllOperations allOperations = new AllOperations();
            TOP:
            Console.WriteLine($"Which operation do you want to perform on {tableName} management portal ? -\n1. Insert a record\n2. Update a record\n3. Delete a record\n4. Show all records\n5. Show a particular record\n6. Go Back");
            switch (Console.ReadLine()){
                case "1": allOperations.InsertRecord(tableName);
                    break;
                case "2": allOperations.UpdateRecord(tableName);
                    break;
                case "3": allOperations.DeleteRecord(tableName);
                    break;
                case "4": allOperations.ShowAllRecord(tableName);
                    break;
                case "5": allOperations.ShowOneRecord(tableName);
                    break;
                case "6": return;
                default: Console.WriteLine("Oops.. you entered wrong option, Please try again.");
                    goto TOP;
            }goto TOP;
        }
    }
}