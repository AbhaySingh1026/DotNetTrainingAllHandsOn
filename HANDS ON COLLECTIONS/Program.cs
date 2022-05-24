using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANDS_ON_COLLECTIONS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TOP:
            int size;
            Console.WriteLine("1. Create interger array to hold int values 0 to 9");
            Console.WriteLine("2. Create array to hold names Tim, Martin, Nikki, & Sara");
            Console.WriteLine("3. Create array of length 10 alternating between true & false, starting with true.");
            Console.WriteLine("4. Create list of 5 icecream flavours");
            string cases = Console.ReadLine();
            MakingArray obj = new MakingArray();
            switch (cases)
            {
                case "1":
                    size = 10;
                    obj.MakeArray<int>(size,cases);
                    break;
                case "2":
                    size = 4;
                    obj.MakeArray<string>(size,cases);
                    break;
                case "3":
                    size = 10;
                    obj.MakeArray<bool>(size,cases);
                    break;
                case "4":
                    List <string> flavour = new List<string>();
                    for (int i = 0; i < 5; i++)
                    {
                        flavour.Add(Console.ReadLine());
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(flavour[i]);
                    }
                    Console.WriteLine(flavour.Count());
                    flavour.RemoveAt(2);
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine(flavour[i]);
                    }
                    Console.WriteLine(flavour.Count());
                    break;
                default:
                    Console.WriteLine("Entered wrong number please try again");
                    goto TOP;
            }
        }
    }
}
