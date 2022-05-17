using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowing_Abstract_Class
{
    public abstract class Android
    {
        public int a = 2;                      //initialized for understanding how can this be accessed if obj can't be made for this class
        public abstract void GiveNames();
    }
    public class AllRunningOnAndroid : Android
    {
        public void Access_abstractclass_variable()
        {
            Console.WriteLine(a);             //we can access variable/functions directly in abstract class by its child class & then by this child we can access in main function.
        }
        public override void GiveNames()     //here, its not function of this class its function of parent class v r jst writing body of it here in this class.
        {
            Console.WriteLine("There are many Companies Runnign on Android like - Samsung,MI,Realme,Nokia");
        }
    }
}
