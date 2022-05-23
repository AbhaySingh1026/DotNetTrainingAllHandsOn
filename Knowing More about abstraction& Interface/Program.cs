using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_More_about_abstraction
{
    public class Program
    {
        static void Main(string[] args)
        {
            Honda HondaObj = new Honda();
            Maruti MarutiObj = new Maruti();
            Console.WriteLine(HondaObj.TopSpeed());
            HondaObj.Wheels();         //Wheels is non abstract functn in parent class Cars
            HondaObj.SpecialFeature();
            Console.WriteLine(MarutiObj.TopSpeed());
            MarutiObj.Wheels();

            Console.WriteLine("Concept of InterFace class is As Belows");
            Volvo VolvoObj = new Volvo();
            Console.WriteLine(VolvoObj.BreakSystem());
            Console.WriteLine(VolvoObj.Gear());
            Console.WriteLine(VolvoObj.TopSpeed());
            Console.WriteLine(VolvoObj.Wheels());
        }
    }
}
