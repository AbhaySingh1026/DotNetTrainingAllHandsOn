using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stDotNetProject
{
    public class SwithdrawORdeposit
    {
        public void Withdraw()
        {
            SavingAccount newobj = new SavingAccount();
            newobj.Withdrawl();
        }
        public void Deposit()
        {
            SavingAccount newobj1 = new SavingAccount();
            newobj1.Deposits();
        }
    }
    public class CwithdrawORdeposit
    {
        public void Withdraw()
        {
            CurrentAccount newobj = new CurrentAccount();
            newobj.Withdrawl();
        }
        public void Deposit()
        {
            CurrentAccount newobj1 = new CurrentAccount();
            newobj1.Deposits();
        }
    }
}
