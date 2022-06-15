using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATA_EDIT_IN_ALL_TABLES_BY_DISCNCTD_APPROACH
{
    public class EmployeeData
    {
        string databaseConnection = "Data Source=DESKTOP-I3CUF5I;Initial Catalog=BankDb;Integrated Security=True";
        int id { get; set; }
        string name { get; set; }
        long mobile { get; set; }
        string address { get; set; }
        public string InsertEmployee()
        {
            Console.Write("Enter Employee Id - ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee name - ");
            name = Console.ReadLine();

            Console.Write("Enter Employee mobile - ");
            mobile = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter Employee address - ");
            address = Console.ReadLine();

            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter("insert into Employee values(" + id + ",'" + name + "','" + address + "','" + mobile + "')", sqlConnectionObj);
            DataTable dataTableObj = new DataTable();
            sqlDataAdapterObj.Fill(dataTableObj);
            return "Inserted";
        }
        public string UpdateEmployee(int EId)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter("select * from Employee", sqlConnectionObj);
            DataTable dataTableObj = new DataTable();
            sqlDataAdapterObj.Fill(dataTableObj);
            Console.WriteLine("Which column u want to update - ");
            for (int i = 1; i < dataTableObj.Columns.Count; i++)
            {
                Console.WriteLine((i) + $". {dataTableObj.Columns[i].ColumnName}");
            }
            int columnNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter new value of {dataTableObj.Columns[columnNumber].ColumnName} - ");
            string value = Console.ReadLine();
            SqlConnection sqlConnection = new SqlConnection(databaseConnection);
            if (!(dataTableObj.Columns[columnNumber].DataType == typeof(string)))  
            {
                Convert.ToInt32(value);
                SqlDataAdapter sqlDataAdapterObj1 = new SqlDataAdapter($"update Employee set {dataTableObj.Columns[columnNumber].ColumnName} = " + value + " where EId = " + EId + "", sqlConnection);
                DataTable dataTableObj1 = new DataTable();
                sqlDataAdapterObj1.Fill(dataTableObj1);
                return "Updated";
            }
            else
            {
                SqlDataAdapter sqlDataAdapterObj1 = new SqlDataAdapter($"update Employee set {dataTableObj.Columns[columnNumber].ColumnName} = '" + value + "' where EId = " + EId + "", sqlConnection);
                DataTable dataTableObj1 = new DataTable();
                sqlDataAdapterObj1.Fill(dataTableObj1);
                return "Updated";
            }
        }
        public string DeleteEmployee(int EId)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Delete from Employee where Eid = " + EId + "", sqlConnectionObj);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return "Deleted";
        }
        public DataTable SelectEmployee()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Employee", sqlConnectionObj);
            DataTable dataTableObj = new DataTable();
            sqlDataAdapter.Fill(dataTableObj);
            return dataTableObj;
        }
        public DataTable SelectEmployeeById(int EId)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Employee where EId = " + EId + "", sqlConnectionObj);
            DataTable dataTableObj = new DataTable();
            sqlDataAdapter.Fill(dataTableObj);
            return dataTableObj;
        }
    }
}
