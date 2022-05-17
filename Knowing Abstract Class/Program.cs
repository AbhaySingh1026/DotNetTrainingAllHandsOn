using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowing_Abstract_Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ios iRunningCompany = new Ios();
            iRunningCompany.GiveNames();
            //Android aRunningCompany = new Android();  //U cannot define aboject for any abstract class. So u can only access member & member functn by its child class
            AllRunningOnAndroid aRunningCompany = new AllRunningOnAndroid();
            aRunningCompany.Access_abstractclass_variable();
            aRunningCompany.GiveNames();
        }
    }
}
