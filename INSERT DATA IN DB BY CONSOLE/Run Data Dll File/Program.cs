using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSERT_DATA_IN_DB_BY_CONSOLE;

namespace Run_Data_Dll_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bookId;
            string bookName;
            string author;
            int price;
            Data dataObj = new Data();
            Console.Write("Enter book id - ");
            bookId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter book name - ");
            bookName = Console.ReadLine();
            Console.Write("Enter author name - ");
            author = Console.ReadLine();
            Console.Write("Enter price - ");
            price = Convert.ToInt32(Console.ReadLine());
            dataObj.InsertData(bookId, bookName,author,price);
        }
    }
}
