using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task
//u have to create 4 functions
//Succes(), Failed(), Missed(), Dailed()
//wen u call the function name
//you should display only part of rows
//example if i call succes method. thn display success calls only

namespace FILE_HANDLING_FOR_READING_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            A:
            Console.WriteLine("For which status you want to see records - ");
            Console.WriteLine("1. Success");
            Console.WriteLine("2. Failed");
            Console.WriteLine("3. Missed");
            Console.WriteLine("4. Dialled");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Read obj = new Read();
                    obj.Reading("Success");
                    break;
                case 2:
                    Read obj1 = new Read();
                    obj1.Reading("Failed");
                    break;
                case 3:
                    Read obj2 = new Read();
                    obj2.Reading("Missed");
                    break;
                case 4:
                    Read obj3 = new Read();
                    obj3.Reading("Dialled");
                    break;
                default:
                    Console.WriteLine("--------Oops u entered wrong number-------");
                    Console.WriteLine("Please try again.");
                    goto A;
            }
            Console.WriteLine();
            Console.WriteLine("Do you want to check another status also - type yes/no");
            string ans1 = Console.ReadLine();
            if ((ans1 == "yes") || (ans1 == "Yes")||(ans1=="YES"))
            {
                goto A;
            }
            return;

        }
    }
}
