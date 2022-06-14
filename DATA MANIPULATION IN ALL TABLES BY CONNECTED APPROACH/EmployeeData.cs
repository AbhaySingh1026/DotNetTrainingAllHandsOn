using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATAENTRYINSQL
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
            Console.Write("Enter employee Id - ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter employee name - ");
            name = Console.ReadLine();

            Console.Write("Enter employee mobile - ");
            mobile = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter employee address - ");
            address = Console.ReadLine();

            //insert data to sql - 

            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlCommand sqlCommandObj = new SqlCommand("insert into employee values(" + id + ",'" + name + "','" + address + "','" + mobile + "')", sqlConnectionObj);
            sqlConnectionObj.Open();
            int check = sqlCommandObj.ExecuteNonQuery();  //return typ is int & tells how many records affected in a table by above query.
            sqlConnectionObj.Close();
            if (check == 0) return "Not Inserted";
            return "Inserted";
        }
        public string UpdateEmployee(int Eid)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlCommand sqlCommandObj = new SqlCommand("select * from employee", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader reader = sqlCommandObj.ExecuteReader();
            DataTable dataTableObj = new DataTable();
            dataTableObj.Load(reader);
            sqlConnectionObj.Close();
            Console.WriteLine("Which column u want to update - ");
            for (int i = 1; i < dataTableObj.Columns.Count; i++)
            {
                Console.WriteLine((i) + $". {dataTableObj.Columns[i].ColumnName}");
            }
            int columnNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter new value of {dataTableObj.Columns[columnNumber].ColumnName} - ");
            string value = Console.ReadLine();
            SqlConnection sqlConnection = new SqlConnection(databaseConnection);
            if (!(dataTableObj.Columns[columnNumber].DataType == typeof(string)))  //checking datatype of column in table
            {
                Convert.ToInt32(value);
                SqlCommand sqlCommand = new SqlCommand($"update employee set {dataTableObj.Columns[columnNumber].ColumnName} = " + value + " where Eid = " + Eid + "", sqlConnection);
                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (result == 0) return "Not Updated";
                return "Updated";
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand($"update employee set {dataTableObj.Columns[columnNumber].ColumnName} = '" + value + "' where Eid = " + Eid + "", sqlConnection);
                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (result == 0) return "Not Updated";
                return "Updated";
            }
        }
        public string DeleteEmployee(int Eid)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlCommand sqlCommandObj = new SqlCommand("Delete from employee where Eid = " + Eid + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            int check = sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            if (check == 0) return "Not Deleted";
            return $"Deleted {check} row";
        }
        public DataTable SelectEmployee()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlCommand sqlCommandObj = new SqlCommand("select * from Employee", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader reader = sqlCommandObj.ExecuteReader(); //executereader functn reads line by line & stores line by line in reader obj.
            DataTable dataTableObj = new DataTable(); //making obj
            dataTableObj.Load(reader); //converting data present in reader obj to a table with Datatable object
            sqlConnectionObj.Close();
            return dataTableObj;
        }
        public DataTable SelectEmployeeById(int Eid)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlCommand sqlCommandObj = new SqlCommand("select * from employee where Eid = " + Eid + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader reader = sqlCommandObj.ExecuteReader();
            DataTable dataTableObj = new DataTable();
            dataTableObj.Load(reader);
            sqlConnectionObj.Close();
            return dataTableObj;
        }
    }
}
