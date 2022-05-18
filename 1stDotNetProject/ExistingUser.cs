using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stDotNetProject
{
    public class ExistingUser
    {
        public void ExistingUsers(string Name)
        {
            Console.WriteLine("Saving Or Current Account - ");
            string AccountType = Console.ReadLine();
            if ((AccountType == "Saving")||(AccountType == "saving"))
            {
                SavingAccount Sobj = new SavingAccount();
                Sobj.SavingAccounts(Name);
            }
            else
            {
                CurrentAccount Cobj = new CurrentAccount();
                Cobj.CurrentAccounts(Name);
            }
            return;
        }

    }
}
