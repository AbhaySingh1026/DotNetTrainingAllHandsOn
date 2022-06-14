using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATAENTRYINSQL
{
    public class BooksData
    {
        string databaseConnection = "Data Source=DESKTOP-I3CUF5I;Initial Catalog=BankDb;Integrated Security=True";
        int id { get; set; }
        string name { get; set; }
        long price { get; set; }
        string author { get; set; }
        public string InsertBooks()
        {
            Console.Write("Enter book Id - ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter book name - ");
            name = Console.ReadLine();

            Console.Write("Enter price - ");
            price = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter author name - ");
            author = Console.ReadLine();

            //insert data to sql - 

            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlCommand sqlCommandObj = new SqlCommand("insert into bookdetail values(" + id + ",'" + name + "','" + author + "'," + price + ")", sqlConnectionObj);
            sqlConnectionObj.Open();
            int check = sqlCommandObj.ExecuteNonQuery();  //return typ is int & tells how many records affected in a table by above query.
            sqlConnectionObj.Close();
            if (check == 0) return "Not Inserted";
            return "Inserted";
        }
        public string UpdateBooks(int Bid)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlCommand sqlCommandObj = new SqlCommand("select * from bookdetail", sqlConnectionObj);
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
                SqlCommand sqlCommand = new SqlCommand($"update bookdetail set {dataTableObj.Columns[columnNumber].ColumnName} = " + value + " where Bid = " + Bid + "", sqlConnection);
                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (result == 0) return "Not Updated";
                return "Updated";
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand($"update bookdetail set {dataTableObj.Columns[columnNumber].ColumnName} = '" + value + "' where Bid = " + Bid + "", sqlConnection);
                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (result == 0) return "Not Updated";
                return "Updated";
            }
        }
        public string DeleteBooks(int Bid)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlCommand sqlCommandObj = new SqlCommand("Delete from bookdetail where Bid = " + Bid + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            int check = sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            if (check == 0) return "Not Deleted";
            return $"Deleted {check} row";
        }
        public DataTable SelectBooks()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlCommand sqlCommandObj = new SqlCommand("select * from bookdetail", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader reader = sqlCommandObj.ExecuteReader(); //executereader functn reads line by line & stores line by line in reader obj.
            DataTable dataTableObj = new DataTable(); //making obj
            dataTableObj.Load(reader); //converting data present in reader obj to a table with Datatable object
            sqlConnectionObj.Close();
            return dataTableObj;
        }
        public DataTable SelectBooksById(int Bid)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlCommand sqlCommandObj = new SqlCommand("select * from bookdetail where Bid = " + Bid + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader reader = sqlCommandObj.ExecuteReader();
            DataTable dataTableObj = new DataTable();
            dataTableObj.Load(reader);
            sqlConnectionObj.Close();
            return dataTableObj;
        }
    }
}
