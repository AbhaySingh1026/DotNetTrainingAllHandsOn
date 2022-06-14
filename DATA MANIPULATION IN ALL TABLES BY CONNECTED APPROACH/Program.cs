using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DATAENTRYINSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EXTREMETOP:
            Console.WriteLine("In which table u want to add/delete/updae/show records? -\n1. Customer Table\n2. Employee Table\n3. Books Table\n\nPress 4 to close application");
            int mainInput = Convert.ToInt32(Console.ReadLine());
            switch (mainInput)
            {
                case 1:
                TOP:
                    CustomerData customerDataObj = new CustomerData();
                    Console.WriteLine("What you want to do in customer Table -\n1. Insert new record\n2. Update existing record\n3. Delete a particular record\n4. Show all records\n5. Show a particular record\n\nPress 6 to return to main screen");
                    int input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine(customerDataObj.InsertCustomer() + '\n');
                            break;
                        case 2:
                            Console.Write("Enter CustId - ");
                            Console.WriteLine(customerDataObj.UpdateCustomer(Convert.ToInt32(Console.ReadLine())) + '\n');
                            break;
                        case 3:
                            Console.Write("Enter CustId - ");
                            Console.WriteLine(customerDataObj.DeleteCustomer(Convert.ToInt32(Console.ReadLine())) + '\n');
                            break;
                        case 4:
                            DataTable obj = customerDataObj.SelectCustomers();
                            for (int i = 0; i < obj.Rows.Count; i++)
                            {
                                if (i == 0)
                                {
                                    for (int j = 0; j < obj.Columns.Count; j++)
                                    {
                                        Console.Write(obj.Columns[j].ColumnName + " ");
                                    }
                                    Console.WriteLine();
                                }
                                for (int j = 0; j < obj.Columns.Count; j++)
                                {
                                    Console.Write(obj.Rows[i][j] + " ");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            break;
                        case 5:
                            Console.Write("Enter CustId - ");
                            DataTable obj1 = customerDataObj.SelectCustomerById(Convert.ToInt32(Console.ReadLine()));
                            for (int i = 0; i < obj1.Columns.Count; i++)
                            {
                                if (i == 0)
                                {
                                    for (int j = 0; j < obj1.Columns.Count; j++)
                                    {
                                        Console.Write(obj1.Columns[j].ColumnName + " ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.Write(obj1.Rows[0][i] + " ");
                            }
                            Console.WriteLine('\n');
                            break;
                        case 6: goto EXTREMETOP;
                        default:
                            Console.WriteLine("Oops.. entered wrong number, Please try again");
                            goto TOP;
                    }
                    goto TOP;
                case 2:
                TOP1:
                    EmployeeData employeeDataObj = new EmployeeData();
                    Console.WriteLine("What you want to do in employee Table -\n1. Insert new record\n2. Update existing record\n3. Delete a particular record\n4. Show all records\n5. Show a particular record\n\nPress 6 to return to main screen");
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    switch (input1)
                    {
                        case 1:
                            Console.WriteLine(employeeDataObj.InsertEmployee() + '\n');
                            break;
                        case 2:
                            Console.Write("Enter Eid - ");
                            Console.WriteLine(employeeDataObj.UpdateEmployee(Convert.ToInt32(Console.ReadLine())) + '\n');
                            break;
                        case 3:
                            Console.Write("Enter Eid - ");
                            Console.WriteLine(employeeDataObj.DeleteEmployee(Convert.ToInt32(Console.ReadLine())) + '\n');
                            break;
                        case 4:
                            DataTable obj = employeeDataObj.SelectEmployee();
                            for (int i = 0; i < obj.Rows.Count; i++)
                            {
                                if (i == 0)
                                {
                                    for (int j = 0; j < obj.Columns.Count; j++)
                                    {
                                        Console.Write(obj.Columns[j].ColumnName + " ");
                                    }
                                    Console.WriteLine();
                                }
                                for (int j = 0; j < obj.Columns.Count; j++)
                                {
                                    Console.Write(obj.Rows[i][j] + " ");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            break;
                        case 5:
                            Console.Write("Enter Eid - ");
                            DataTable obj1 = employeeDataObj.SelectEmployeeById(Convert.ToInt32(Console.ReadLine()));
                            for (int i = 0; i < obj1.Columns.Count; i++)
                            {
                                if (i == 0)
                                {
                                    for (int j = 0; j < obj1.Columns.Count; j++)
                                    {
                                        Console.Write(obj1.Columns[j].ColumnName + " ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.Write(obj1.Rows[0][i] + " ");
                            }
                            Console.WriteLine('\n');
                            break;
                        case 6: goto EXTREMETOP;
                        default:
                            Console.WriteLine("Oops.. entered wrong number, Please try again");
                            goto TOP1;
                    }
                    goto TOP1;
                case 3:
                TOP2:
                    BooksData booksDataObj = new BooksData();
                    Console.WriteLine("What you want to do in books Table -\n1. Insert new record\n2. Update existing record\n3. Delete a particular record\n4. Show all records\n5. Show a particular record\n\nPress 6 to return to main screen");
                    int input2 = Convert.ToInt32(Console.ReadLine());
                    switch (input2)
                    {
                        case 1:
                            Console.WriteLine(booksDataObj.InsertBooks() + '\n');
                            break;
                        case 2:
                            Console.Write("Enter Bid - ");
                            Console.WriteLine(booksDataObj.UpdateBooks(Convert.ToInt32(Console.ReadLine())) + '\n');
                            break;
                        case 3:
                            Console.Write("Enter Bid - ");
                            Console.WriteLine(booksDataObj.DeleteBooks(Convert.ToInt32(Console.ReadLine())) + '\n');
                            break;
                        case 4:
                            DataTable obj = booksDataObj.SelectBooks();
                            for (int i = 0; i < obj.Rows.Count; i++)
                            {
                                if (i == 0)
                                {
                                    for (int j = 0; j < obj.Columns.Count; j++)
                                    {
                                        Console.Write(obj.Columns[j].ColumnName + " ");
                                    }
                                    Console.WriteLine();
                                }
                                for (int j = 0; j < obj.Columns.Count; j++)
                                {
                                    Console.Write(obj.Rows[i][j] + " ");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            break;
                        case 5:
                            Console.Write("Enter Eid - ");
                            DataTable obj1 = booksDataObj.SelectBooksById(Convert.ToInt32(Console.ReadLine()));
                            for (int i = 0; i < obj1.Columns.Count; i++)
                            {
                                if (i == 0)
                                {
                                    for (int j = 0; j < obj1.Columns.Count; j++)
                                    {
                                        Console.Write(obj1.Columns[j].ColumnName + " ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.Write(obj1.Rows[0][i] + " ");
                            }
                            Console.WriteLine('\n');
                            break;
                        case 6: goto EXTREMETOP;
                        default:
                            Console.WriteLine("Oops.. entered wrong number, Please try again");
                            goto TOP2;
                    }
                    goto TOP2;
                case 4: return;
                default: Console.WriteLine("Please try again");
                    goto EXTREMETOP;
            }
        }
    }
}
