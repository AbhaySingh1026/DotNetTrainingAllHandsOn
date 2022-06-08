using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuestionsHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question - 1
            int[] positiveAndNegative = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            int[] positiveNumbers = positiveAndNegative.Where(x => x > 0).ToArray();
            Console.WriteLine("Positive numbers in given array are - ");
            foreach (int number in positiveNumbers)
            {
                Console.Write(number + " ");
            } Console.WriteLine('\n');

            //Question - 2
            int count = 1;
            int[] findFrequency = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            int[] usedNumbers = Enumerable.Repeat(-1, 100).ToArray();
            Console.WriteLine("The numbers in the array are - ");
            foreach (int number in findFrequency)
            {
                Console.Write(number + ", ");
            } Console.WriteLine();
            for (int i = 0; i < findFrequency.Length; i++)
            {
                if (usedNumbers[findFrequency[i]] == -1)
                {
                    for (int j = i + 1; j < findFrequency.Length; j++)
                    {
                        if (findFrequency[i] == findFrequency[j]) count++;
                    }
                    usedNumbers[findFrequency[i]] = 1;
                    Console.WriteLine($"Number {findFrequency[i]} appears {count} times");
                    count = 1;
                }
            } Console.WriteLine();

            //Question - 3
            Console.Write("Enter your string - ");
            string store = Console.ReadLine();
            string check = "";
            Console.WriteLine("The frequency of characters are - ");
            for (int i = 0; i < store.Length; i++)
            {
                if (!check.Contains(store[i]))
                {
                    for (int j = i + 1; j < store.Length; j++)
                    {
                        if (store[i] == store[j]) count++;
                    } check = check + store[i];
                    Console.WriteLine($"Character {store[i]}: {count} times");
                    count = 1;
                }
            }
            Console.WriteLine();

            //Question - 4
            List<string> locationsObj = new List<string> { "ROME", "LONDON", "CALIFORNIA", "NAIROBI", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            var result = from get in locationsObj where get.StartsWith("A") && get.EndsWith("I") select get;
            foreach (var location in result)
            {
                Console.WriteLine(location);
            } Console.WriteLine();

            //Question - 5
            List<int> membersObj = new List<int> { 5, 7, 13, 24, 6, 9, 8, 7 };
            Console.Write("How many records you want to display - ");
            int input = Convert.ToInt32(Console.ReadLine());
            var result1 = membersObj.Take(input);
            Console.WriteLine($"The top {input} records from the list are - ");
            foreach (int item in result1)
            {
                Console.WriteLine(item);
            } Console.WriteLine();

            //Question - 6
            List<Students> stulist = new List<Students>();
            stulist.Add(new Students { StuId = 1, StuName = "Joseph", GrPoint = 800 });
            stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
            stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
            stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
            stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
            stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
            stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });
            Console.Write("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find - ");
            input = Convert.ToInt32(Console.ReadLine());
            var result2 = (from fetchData in stulist orderby fetchData.GrPoint descending group fetchData.GrPoint by fetchData.GrPoint).ToList();
            var fetchOneRow = result2[input - 1];
            List<Students> finanlListObj = new List<Students>();
            foreach (var item in fetchOneRow)
            {
                finanlListObj = (from finalFetch in stulist where finalFetch.GrPoint == item select finalFetch).ToList();
            }
            foreach (var item in finanlListObj)
            {
                Console.WriteLine("Id : " + item.StuId + ", Name : " + item.StuName + ", Achieved Grade Point : " + item.GrPoint);
            } Console.WriteLine();

            //Question - 7
            List<Person> peoplesObj = new List<Person>()
            {
                new Person{firstName = "Bill", lastName = "Smith", age = 41 },
                new Person{firstName = "Sarah", lastName = "Jones", age = 22 },
                new Person{firstName = "Stacy",lastName = "Baker", age = 21},
                new Person{firstName = "Vivianne", lastName = "Dexter", age = 19 },
                new Person{firstName = "Bob", lastName = "Smith", age = 49 },
                new Person{firstName = "Brett", lastName = "Baker", age = 51 },
                new Person{firstName = "Mark", lastName = "Parker", age = 19},
                new Person{firstName = "Alice", lastName = "Thompson", age = 18},
                new Person{firstName = "Evelyn", lastName = "Thompson", age = 58 },
                new Person{firstName = "Mort", lastName = "Martin", age = 58 },
                new Person{firstName = "Eugene", lastName ="DeLauter", age = 84 },
                new Person{firstName = "Gail", lastName = "Dawson", age = 19 },
            };
            Console.Write("Enter letter - ");
            string letter = Console.ReadLine();
            Console.WriteLine($"People with last name that starts with letter {letter} are - ");
            var getData = (from data in peoplesObj where data.lastName.StartsWith(letter) select data).ToList();
            foreach(var data in getData)
            {
                Console.WriteLine(data.lastName);
            }Console.WriteLine();

            //Question - 8
            Console.WriteLine($"Number of people whoes last name starts with {letter} - {getData.Count}" + '\n');

            //Question - 9
            var dataByAge = from data in peoplesObj where data.age > 40 orderby data.firstName select data;
            foreach(var data in dataByAge)
            {
                Console.Write(data.firstName + ", ");
            }Console.WriteLine('\n');

            //Question - 10
            Console.WriteLine("fruits in list starting with letter L are - ");
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            var final = fruits.Where(obj => obj.StartsWith("L"));
            foreach (var fruit in final)
            {
                Console.Write(fruit + ", ");
            }Console.WriteLine('\n');

            //Question - 11
            List<int> mixedNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            var multipleOf4Or6 = mixedNumbers.Where(obj => obj%4 == 0 || obj%6 == 0);
            foreach(int finalOutput in multipleOf4Or6)
            {
                Console.Write(finalOutput + ", ");
            }
        }
    }
    public class Students
    {
        public int StuId { get; set; }
        public string StuName { get; set; }
        public int GrPoint { get; set; }
    }
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
    }
}
