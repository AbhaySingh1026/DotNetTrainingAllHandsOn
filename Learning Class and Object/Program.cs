using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Class_and_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            string Animal;
            Console.WriteLine("Please Enter Your Animal - ");
            A:
            Animal = Console.ReadLine();
            if (Animal == "Cat")
            {
                Cat Voice = new Cat();
                Voice.ofCat();
            }
            else if (Animal == "Dog")
            {
                Dog Voice = new Dog();
                Voice.ofDog();
            }
            else
            {
                Console.WriteLine("Please Enter Either Dog or Cat");
                goto A;
                Console.ReadLine();
            }
        }
    }
}
