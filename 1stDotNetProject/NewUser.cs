using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stDotNetProject
{
    public class NewUser
    {
        public void NewUsers(string Name)
        {
            Console.WriteLine("Which type of account u want to open - ");
            string temp = Console.ReadLine();
            Console.WriteLine("How much Money you want to add - ");
            int newaccmoney = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Payment Done, Total Balance in your account is - {newaccmoney}");
            return;        }
    }
}
