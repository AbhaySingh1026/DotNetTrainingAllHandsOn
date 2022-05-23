using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_More_about_abstraction
{
    public interface Truck  //Declaration of interface class. Do not write class keyword here
    {                       //obj of interface class can also not be created so it is accesed by its child class
        int Gear();  //By default it is public & abstract
        string BreakSystem();
        int TopSpeed();
    }
    public interface Bus 
    {
        int Wheels();
    }
    public class Volvo : Truck,Bus     //u can inherit from all parent class at same time
    {                                  //U have to define body for all functns present in all parents classes from u r inheriting child class
        public int Gear()             //Here override keyword is not required
        {
            return 4;
        }
        public string BreakSystem()
        {
            return "Simple Breaks";
        }
        public int TopSpeed()
        {
            return 80;
        }
        public int Wheels()
        {
            return 10;
        }
    }
}
