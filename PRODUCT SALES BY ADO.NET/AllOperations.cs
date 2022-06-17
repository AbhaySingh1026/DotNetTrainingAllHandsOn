using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace PRODUCT_SALES_BY_ADO.NET
{
    public class AllOperations
    {
        #region Properties
        string connection = "Data Source=DESKTOP-I3CUF5I;Initial Catalog=BankDb;Integrated Security=True";
        int id { get; set; }
        int sId { get; set; }
        int quantity { get; set; }
        string name { get; set; }
        double price { get; set; }
        string temp { get; set; }
        int count { get; set; }
        string columnName { get; set; }
        #endregion

        #region Methods
        public void InsertRecord(string tablename)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(connection);
            DataTable dt = new DataTable();
            #region InsertForProductTable
            if (tablename == "Product")
            {
                TOP:
                try
                {
                    Console.Write("Enter product Id - ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter product name - ");
                    name = Console.ReadLine();
                    Console.Write("Enter product price - ");
                    price = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please try again, and provide correct details.");
                    goto TOP;
                }
                try
                {
                    SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter($"insert into {tablename}(pid,pname,price) values(" + id + ",'" + name + "'," + price + ")", sqlConnectionObj);
                    sqlDataAdapterObj.Fill(dt);
                }
                catch
                {
                    Console.WriteLine("Either product id or product name already exists in record, please try again - ");
                    goto TOP;
                }
                Console.WriteLine("RECORD INSERTED");
            }
            #endregion
            #region InsertForSalesTable
            else
            {
                TOP1:
                try
                {
                    Console.Write("Enter sale Id - ");
                    sId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter product Id - ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter quantity - ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter sales date(year-month-day) - ");
                    name = Console.ReadLine();
                    SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter("select price from product where pid = " + id + "", sqlConnectionObj);
                    sqlDataAdapterObj.Fill(dt);
                    temp = dt.Rows[0][0].ToString();
                    price = Convert.ToDouble(temp) * quantity;
                }
                catch
                {
                    Console.WriteLine("Please try again, and provide correct details.");
                    goto TOP1;
                }
                try
                {
                    SqlDataAdapter sqlDataAdapterObj1 = new SqlDataAdapter($"insert into {tablename}(sid,pid,quantity,totalcost,salesdate) values(" + sId + "," + id + "," + quantity + ","+price+",'"+name+"')", sqlConnectionObj);
                    sqlDataAdapterObj1.Fill(dt);
                }
                catch
                {
                    Console.WriteLine("Either Sales id already exists in record/product id entered not exists in record/ date order entered is not correct,please try again - ");
                    goto TOP1;
                }
                Console.WriteLine("RECORD INSERTED");
            }
            #endregion
        }
        public void UpdateRecord(string tablename)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(connection);
            DataTable dt = new DataTable();
            #region UpdateForProductTable
            if (tablename == "Product")
            {
                SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter("select * from product",sqlConnectionObj);
                sqlDataAdapterObj.Fill(dt);
                if(dt.Rows.Count == 0)
                {
                    Console.WriteLine("There are no records present.");
                    return;
                }
                Line103:
                Console.WriteLine("Which column u want to update - ");
                for(int i = 1; i < dt.Columns.Count; i++)
                {
                    Console.WriteLine((i) + ". " + dt.Columns[i].ColumnName);
                }
                try
                {
                    count = Convert.ToInt32(Console.ReadLine());
                    if (count <= 0)
                    {
                        Console.WriteLine("Please enter correct option - ");
                        goto Line103;
                    }
                    Console.WriteLine("Enter Product Id - ");
                    id = Convert.ToInt32(Console.ReadLine());
                    columnName = dt.Columns[count].ColumnName;
                }
                catch
                {
                    Console.WriteLine("Please only enter numbers");
                    goto Line103;
                }
                count = 0;
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt.Rows[i][0]) == id)
                    {
                        count = 1;
                        break;
                    }
                }
                if(count == 0)
                {
                    Console.WriteLine("Entered product Id doesn't exists, Please try again -");
                    goto Line103;
                }
                Console.WriteLine("Enter new value - ");
                string newValue = Console.ReadLine();
                try
                {
                    if (dt.Columns[count].DataType == typeof(string))
                    {
                        SqlDataAdapter sqlDataObj = new SqlDataAdapter($"update {tablename} set {columnName} = '" + newValue + "' where pid = " + id + "", sqlConnectionObj);
                        sqlDataObj.Fill(dt);
                    }
                    else
                    {
                        SqlDataAdapter sqlDataObj = new SqlDataAdapter($"update {tablename} set {columnName} = " + newValue + " where pid = " + id + "", sqlConnectionObj);
                        sqlDataObj.Fill(dt);
                    }
                }
                catch
                {
                    Console.WriteLine("Datatype of entered new value is incorrect please enter new value again with its correct datatype - ");
                    goto Line103;
                }
                Console.WriteLine("RECORD UPDATED");
            }
            #endregion
            #region UpdateForSalesTable
            else
            {
                SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter("select * from sales", sqlConnectionObj);
                sqlDataAdapterObj.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    Console.WriteLine("There are no records present.");
                    return;
                }
            Line150:
                Console.WriteLine("Which column u want to update - ");
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    Console.WriteLine((i) + ". " + dt.Columns[i].ColumnName);
                }
                try
                {
                    count = Convert.ToInt32(Console.ReadLine());
                    if (count <= 0)
                    {
                        Console.WriteLine("Please enter correct option - ");
                        goto Line150;
                    }
                    Console.WriteLine("Enter Sales Id - ");
                    sId = Convert.ToInt32(Console.ReadLine());
                    columnName = dt.Columns[count].ColumnName;
                }
                catch
                {
                    Console.WriteLine("Please only enter numbers");
                    goto Line150;
                }
                count = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt.Rows[i][0]) == sId)
                    {
                        count = 1;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("Entered Sales Id doesn't exists, Please try again -");
                    goto Line150;
                }
                Console.WriteLine("Enter new value - ");
                string newValue = Console.ReadLine();
                try
                {
                    if (dt.Columns[count].DataType == typeof(string))
                    {
                        SqlDataAdapter sqlDataObj = new SqlDataAdapter($"update {tablename} set {columnName} = '" + newValue + "' where sid = " + sId + "", sqlConnectionObj);
                        sqlDataObj.Fill(dt);
                    }
                    else
                    {
                        SqlDataAdapter sqlDataObj = new SqlDataAdapter($"update {tablename} set {columnName} = " + newValue + " where sid = " + sId + "", sqlConnectionObj);
                        sqlDataObj.Fill(dt);
                    }
                }
                catch
                {
                    Console.WriteLine("Datatype of entered new value is incorrect please enter new value again with its correct datatype - ");
                    goto Line150;
                }
                Console.WriteLine("RECORD UPDATED");
            }
            #endregion
        }
        public void DeleteRecord(string tablename)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(connection);
            DataTable dt = new DataTable();
            #region DeleteForProductTable
            if (tablename == "Product")
            {
                SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter($"select * from {tablename}",sqlConnectionObj);
                sqlDataAdapterObj.Fill(dt);
                if(dt.Rows.Count == 0)
                {
                    Console.WriteLine("There are currently no records present to delete.");
                    return;
                }
                Line246:
                Console.Write("Enter product Id - ");
                try
                {
                    id = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter correct product Id with correct datatype -");
                    goto Line246;
                }
                count = 0;
                for (int i =0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt.Rows[i][0]) == id)
                    {
                        count = 1;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("Entered product Id doesn't exists, Please try again -");
                    goto Line246;
                }
                SqlDataAdapter obj1 = new SqlDataAdapter($"delete from sales where pid = "+id+"", sqlConnectionObj);
                obj1.Fill(dt);
                SqlDataAdapter obj2 = new SqlDataAdapter($"delete from {tablename} where pid = " + id + "", sqlConnectionObj);
                obj2.Fill(dt);
                Console.WriteLine("RECORD DELETED");
            }
            #endregion
            #region DeleteForSalesTable
            else
            {
                SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter($"select * from {tablename}", sqlConnectionObj);
                sqlDataAdapterObj.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    Console.WriteLine("There are currently no records present to delete.");
                    return;
                }
            Line286:
                Console.Write("Enter Sales Id - ");
                try
                {
                    sId = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter correct sales Id with correct datatype -");
                    goto Line286;
                }
                count = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt.Rows[i][0]) == sId)
                    {
                        count = 1;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("Entered sales Id doesn't exists, Please try again -");
                    goto Line286;
                }
                SqlDataAdapter obj1 = new SqlDataAdapter($"delete from {tablename} where sId = " + sId + "", sqlConnectionObj);
                obj1.Fill(dt);
                Console.WriteLine("RECORD DELETED");
            }
            #endregion
        }
        public void ShowAllRecord(string tablename)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(connection);
            DataTable dt = new DataTable();
            #region ShowProductTable
            if (tablename == "Product")
            {
                SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter($"select * from {tablename}", sqlConnectionObj);
                sqlDataAdapterObj.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    Console.WriteLine("There are currently no records present to show.");
                    return;
                }
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            Console.Write(dt.Columns[j].ColumnName + " ");
                        }
                        Console.WriteLine();
                    }
                    for(int j = 0; j<dt.Columns.Count; j++)
                    {
                        Console.Write(dt.Rows[i][j] + " ");
                    }Console.WriteLine();
                }Console.WriteLine();
            }
            #endregion
            #region ShowSalesTable
            else
            {
                SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter($"select * from {tablename}", sqlConnectionObj);
                sqlDataAdapterObj.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    Console.WriteLine("There are currently no records present to show.");
                    return;
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            Console.Write(dt.Columns[j].ColumnName + " ");
                        }
                        Console.WriteLine();
                    }
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        Console.Write(dt.Rows[i][j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            #endregion
        }
        public void ShowOneRecord(string tablename)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(connection);
            DataTable dt = new DataTable();
            #region ShowOneRecordOfProductTable
            if (tablename == "Product")
            {
                SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter($"select * from {tablename}", sqlConnectionObj);
                sqlDataAdapterObj.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    Console.WriteLine("There are currently no records present to show.");
                    return;
                }
                TOP:
                Console.Write("Enter product Id - ");
                try
                {
                    id = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter correct product Id with correct datatype -");
                    goto TOP;
                }
                count = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt.Rows[i][0]) == id)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            Console.Write(dt.Columns[j].ColumnName + " ");
                        }
                        Console.WriteLine();
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            Console.Write(dt.Rows[i][j] + " ");
                            count = 1;
                        }Console.WriteLine();
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("Entered product Id doesn't exists, Please try again -");
                    goto TOP;
                }
            }
            #endregion
            #region ShowOneRecordOfSalesTable
            else
            {
                SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter($"select * from {tablename}", sqlConnectionObj);
                sqlDataAdapterObj.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    Console.WriteLine("There are currently no records present to show.");
                    return;
                }
            TOP1:
                Console.Write("Enter Sales Id - ");
                try
                {
                    sId = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter correct product Id with correct datatype -");
                    goto TOP1;
                }
                count = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt.Rows[i][0]) == sId)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            Console.Write(dt.Columns[j].ColumnName + " ");
                        }
                        Console.WriteLine();
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            Console.Write(dt.Rows[i][j] + " ");
                            count = 1;
                        }
                        Console.WriteLine();
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("Entered Sales Id doesn't exists, Please try again -");
                    goto TOP1;
                }
            }
            #endregion
        }
        #endregion
    }
}