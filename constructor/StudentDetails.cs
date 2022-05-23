using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    public class StudentDetails
    {
        public static string grade;
        public int stuId { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public StudentDetails()   //default constructor. no parameters
        {
            stuId = 4;
            Console.WriteLine(stuId);
        }
        public StudentDetails(int stuId, string name, int age)   //parameterized constructor.
        {
            this.stuId = stuId;
            this.name = name;
            this.age = age;
        }
        public void ShowDetails()
        {
            Console.WriteLine(this.stuId);
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
        }
        static StudentDetails() //no parameters. its called automatically before obj is created. its only called once. others could be called multiple times
        {
            grade = "A";
            Console.WriteLine(grade);
        }
    }
}
