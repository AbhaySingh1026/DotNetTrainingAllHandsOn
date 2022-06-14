using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//these 2 namespaces r required for connecting & performing operations from consoleapp to backend sqldatabases - 
using System.Data.SqlClient; //responsible for connecting to your sql server
using System.Data;  //Datatable, dataset

namespace DATAENTRYINSQL
{//ADO.NET - is of two types connected mode & disconnected mode. in connected mode u have to manually open & close connection but in disconnected mode it automatically happens.
 //here suppose 1 user is using connection so any other person can't come and use that connection 1st that 1st person must close that conncetn then 2nd can open & use it.
 // here we r using connected mode. example of disconnocted mode is ATM.
    public class CustomerData
    {
        string databaseConnection = "Data Source=DESKTOP-I3CUF5I;Initial Catalog=BankDb;Integrated Security=True";
        int id { get; set; }
        string name { get; set; }
        string email { get; set; }
        long mobile { get; set; }
        string address { get; set; }
        public string InsertCustomer()
        {
            Console.Write("Enter customer Id - ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter customer name - ");
            name = Console.ReadLine();
            
            Console.Write("Enter customer email - ");
            email = Console.ReadLine();
            
            Console.Write("Enter customer mobile - ");
            mobile = Convert.ToInt64(Console.ReadLine());
            
            Console.Write("Enter customer address - ");
            address = Console.ReadLine();
            
            //insert data to sql - 

            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlCommand sqlCommandObj = new SqlCommand("insert into CUSTOMER values("+id+",'"+name+"','"+email+"','"+mobile+"','"+address+"')", sqlConnectionObj);
            sqlConnectionObj.Open();
            int check = sqlCommandObj.ExecuteNonQuery();  //return typ is int & tells how many records affected in a table by above query.
            sqlConnectionObj.Close();
            if (check == 0) return "Not Inserted";
            return "Inserted";
        }
        public string UpdateCustomer(int CustId)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlCommand sqlCommandObj = new SqlCommand("select * from customer", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader reader = sqlCommandObj.ExecuteReader(); 
            DataTable dataTableObj = new DataTable(); 
            dataTableObj.Load(reader); 
            sqlConnectionObj.Close();
            Console.WriteLine("Which column u want to update - ");
            for(int i = 1; i < dataTableObj.Columns.Count; i++)
            {
                Console.WriteLine((i) + $". {dataTableObj.Columns[i].ColumnName}");
            }int columnNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter new value of {dataTableObj.Columns[columnNumber].ColumnName} - ");
            string value = Console.ReadLine();
            SqlConnection sqlConnection = new SqlConnection(databaseConnection);
            if (!(dataTableObj.Columns[columnNumber].DataType == typeof(string)))  //checking datatype of column in table
            {
                Convert.ToInt32(value);
                SqlCommand sqlCommand = new SqlCommand($"update customer set {dataTableObj.Columns[columnNumber].ColumnName} = "+value+" where CustId = " + CustId + "", sqlConnection);
                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (result == 0) return "Not Updated";
                return "Updated";
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand($"update customer set {dataTableObj.Columns[columnNumber].ColumnName} = '"+value+"' where CustId = " + CustId + "", sqlConnection);
                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (result == 0) return "Not Updated";
                return "Updated";
            }
        }
        public string DeleteCustomer(int CustId)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlCommand sqlCommandObj = new SqlCommand("Delete from customer where custid = "+CustId+"", sqlConnectionObj);
            sqlConnectionObj.Open();
            int check = sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            if (check == 0) return "Not Deleted";
            return $"Deleted {check} row";
        }
        public DataTable SelectCustomers()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlCommand sqlCommandObj = new SqlCommand("select * from customer", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader reader =  sqlCommandObj.ExecuteReader(); //executereader functn reads line by line & stores line by line in reader obj.
            DataTable dataTableObj = new DataTable(); //making obj
            dataTableObj.Load(reader); //converting data present in reader obj to a table with Datatable object
            sqlConnectionObj.Close();
            return dataTableObj;
        }
        public DataTable SelectCustomerById(int CustId)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlCommand sqlCommandObj = new SqlCommand("select * from customer where CustId = "+CustId+"", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader reader = sqlCommandObj.ExecuteReader();
            DataTable dataTableObj = new DataTable(); 
            dataTableObj.Load(reader); 
            sqlConnectionObj.Close();
            return dataTableObj;
        }
    }
}
