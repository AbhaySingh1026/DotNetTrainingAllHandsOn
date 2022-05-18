using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stDotNetProject
{
    public abstract class Account
    {
        public abstract void Withdrawl();
        public abstract void Deposits();
    }

    public class SavingAccount : Account
    {
        public void SavingAccounts(string Name)
        {
            Console.WriteLine("Withdraw/Deposit - ");
            string ans = Console.ReadLine();
            if((ans == "Withdraw")||(ans == "withdraw"))
            {
                SwithdrawORdeposit WOD = new SwithdrawORdeposit();
                WOD.Withdraw();
            }
            else
            {
                SwithdrawORdeposit WOD = new SwithdrawORdeposit();
                WOD.Deposit();
            }
            return;
        }
        public override void Withdrawl()
        {
            Console.WriteLine("Current Rupees in your savingacc.- ");
            int CurrentRupees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many Rupees u want to withdraw - ");
            int ans1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Payment Done, Left Balance in your account is - {CurrentRupees - ans1}");
            return;
        }
        public override void Deposits()
        {
            Console.WriteLine("Current Rupees in your savingacc.- ");
            int CurrentRupees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many Rupees u want to Deposit - ");
            int ans1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Payment Done, Total Balance in your account is - {CurrentRupees + ans1}");
            return;

        }

    }
    public class CurrentAccount : Account
    {
        public void CurrentAccounts(string Name)
        {
            Console.WriteLine("Withdraw/Deposit - ");
            string ans = Console.ReadLine();
            if ((ans == "Withdraw") || (ans == "withdraw"))
            {
                CwithdrawORdeposit WOD = new CwithdrawORdeposit();
                WOD.Withdraw();
            }
            else
            {
                CwithdrawORdeposit WOD = new CwithdrawORdeposit();
                WOD.Deposit();
            }
            return;
        }
        public override void Withdrawl()
        {
            Console.WriteLine("Current Rupees in your currentacc.- ");
            int CurrentRupees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many Rupees u want to withdraw - ");
            int ans1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Payment Done, Left Balance in your account is - {CurrentRupees - ans1}");
            return;
        }
        public override void Deposits()
        {
            Console.WriteLine("Current Rupees in your currentacc.- ");
            int CurrentRupees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many Rupees u want to Deposit - ");
            int ans1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Payment Done, Total Balance in your account is - {CurrentRupees + ans1}");
            return;

        }
    }
}
