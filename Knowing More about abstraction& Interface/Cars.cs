using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_More_about_abstraction
{
    public abstract class Cars                       //In abstract class an abstract & non-abstract functn both can be declared but in interface class u can only have abstract method
    {
        public abstract int Gear();     //if u marked a method/functn abstract u can not write its body, it will show error
        public abstract string BreakSystem();
        public abstract int TopSpeed();
        public void Wheels()            //Non-abstract Method
        {
            Console.WriteLine("4");
        }

    }
    public class Honda : Cars        //U can only inherit from 1 class means u can only have 1 parent class. but in interface we can hav more than 1 parent class & inherit from all at same Time
    {
        public override int Gear()   //override keyword is necessary
        {
            return 4;
        }
        public override string BreakSystem()
        {
            return "ABS";
        }
        public override int TopSpeed()
        {
            return 200;
        }
        public void SpecialFeature()
        {
            Console.WriteLine("Auto Lock Car When Owner Is 10 Metres Away");
        }
    }
    public class Maruti : Cars   //if u r inheriting a abstract class so u have to write body of all abstract fnctn present in that abstract class
    {
        public override int Gear()
        {
            return 5;
        }
        public override string BreakSystem()
        {
            return "Dual Channel ABS";
        }
        public override int TopSpeed()
        {
            return 300;
        }
    }
}
