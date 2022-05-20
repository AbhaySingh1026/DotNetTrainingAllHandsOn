using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stDotNetProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            string Name,existingORnew;
            Console.WriteLine("Please Enter Name of User - ");
            A:
            Name = Console.ReadLine();
            Console.WriteLine(Name + " is existing user or new user");
            existingORnew = Console.ReadLine();
            if((existingORnew == "existing")||(existingORnew == "Existing"))
            {
                ExistingUser Eobj = new ExistingUser();
                Eobj.ExistingUsers(Name);
            }
            else
            {
                NewUser Nobj = new NewUser();
                Nobj.NewUsers(Name);
            }
            Console.WriteLine("Enter Name of new User - ");
            goto A;
        }
    }
}
