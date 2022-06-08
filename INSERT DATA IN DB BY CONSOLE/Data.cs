using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace INSERT_DATA_IN_DB_BY_CONSOLE
{
    public class Data
    {
        string connectiion = "Data Source=DESKTOP-I3CUF5I;Initial Catalog=BankDb;Integrated Security=True";
        public string InsertData(int bookId, string bookName, string author, int price)
        {
            SqlConnection sqlConnection = new SqlConnection(connectiion);
            SqlCommand sqlCommand = new SqlCommand("insert into BOOKDETAIL values("+bookId+", '"+bookName+"', '"+author+"', "+price+")", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return "Data Inserted";
        }
    }
}
