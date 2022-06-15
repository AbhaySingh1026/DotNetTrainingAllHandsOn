using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATA_EDIT_IN_ALL_TABLES_BY_DISCNCTD_APPROACH
{
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


            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter("insert into CUSTOMER values(" + id + ",'" + name + "','" + email + "','" + mobile + "','" + address + "')", sqlConnectionObj);
            //var timeout = sqlConnectionObj.ConnectionTimeout;    //Tells how many minutes connectn remains open.
            DataTable dataTableObj = new DataTable(); 
            sqlDataAdapterObj.Fill(dataTableObj); //baically this executes ur upper query & if in query u r returning table then it will exc ur query & store returned table in datatableobj then u cn fetch it as doing earlier 
            // bt if frm ur query u r nt returng table & just performing edit(insert,update,delete etc) operation inside that table then it will exc ur query and set datatableobj empty.
            //& here it fetches all data of table at once not like connected approach in which it reads data from table 1 row by row.
            //so acc to project need u can use cncted/discntd apprch. for ex - if u want to fetch data from table having 1lakh records then discnctd will be better coz it will take less time bt if
            //want to check each row like if salary is less than anydigit then perform x operation on that record then use concted approach
            return "Inserted"; //& here u can't tell how many rows effected by ur query as u can do in cncted approach.
        }
        public string UpdateCustomer(int CustId)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter("select * from customer", sqlConnectionObj);
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
                SqlDataAdapter sqlDataAdapterObj1 = new SqlDataAdapter($"update customer set {dataTableObj.Columns[columnNumber].ColumnName} = " + value + " where CustId = " + CustId + "", sqlConnection);
                DataTable dataTableObj1 = new DataTable();
                sqlDataAdapterObj1.Fill(dataTableObj1);
                return "Updated";
            }
            else
            {
                SqlDataAdapter sqlDataAdapterObj1 = new SqlDataAdapter($"update customer set {dataTableObj.Columns[columnNumber].ColumnName} = '" + value + "' where CustId = " + CustId + "", sqlConnection);
                DataTable dataTableObj1 = new DataTable();
                sqlDataAdapterObj1.Fill(dataTableObj1);
                return "Updated";
            }
        }
        public string DeleteCustomer(int CustId)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Delete from customer where custid = " + CustId + "", sqlConnectionObj);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return "Deleted";
        }
        public DataTable SelectCustomers()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from customer", sqlConnectionObj);
            DataTable dataTableObj = new DataTable();
            sqlDataAdapter.Fill(dataTableObj);
            return dataTableObj;
        }
        public DataTable SelectCustomerById(int CustId)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(databaseConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from customer where CustId = " + CustId + "", sqlConnectionObj);
            DataTable dataTableObj = new DataTable();
            sqlDataAdapter.Fill(dataTableObj);
            return dataTableObj;
        }
    }
}
