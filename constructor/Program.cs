using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentDetails obj = new StudentDetails();
            //StudentDetails obj = new StudentDetails(1,"Abhay",21); //when u make obj automatically constructor is called. no need to call separataly.
                                                                   //constructor has name same to class
            //obj.ShowDetails();         
        } 
    }
}



//Notes - 

//object can accept all types of data type
//object a = int b;
//a = string c;

//Console.Write(""); is for not breaking to next line
//in get set property if u put only get then u can't int values in that variable