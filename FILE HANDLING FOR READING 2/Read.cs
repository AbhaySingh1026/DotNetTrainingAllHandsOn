using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FILE_HANDLING_FOR_READING_2
{
    public class Read
    {
        public void Failed()
        {
            string[] arr1 = new string[100];
            string[] arr2 = new string[100];
            string[] arr3 = new string[100];
            FileStream fileStreamobj = new FileStream("E:\\KelltonTech\\.NET training kellton\\Real Training Started\\FILE HANDLING FOR READING 2\\ReadFrom.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            Console.WriteLine("Id\tSource\tDestination\tDate\tTime\tStatus\tNetwork");
            string line1 = streamReaderobj.ReadLine();
            while (streamReaderobj.Peek() > 0)
            {
                string line2 = streamReaderobj.ReadLine();
                if (line2 != "")
                {
                    line1 = line1 +"\t"+ line2;
                }
                else if(line2 == "")
                {
                    if (line1.Contains("Failed"))
                    {
                        arr1 = line1.Split('\t');
                        arr2 = arr1[0].Split(':');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[1].Split(':');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[2].Split(':');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[3].Split(' ');
                        arr3 = arr2[0].Split(':');
                        Console.Write(arr3[1] + '\t');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[4].Split(':');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[5].Split(':');
                        Console.WriteLine(arr2[1] + '\t');
                    }
                    line1 = streamReaderobj.ReadLine();
                }

            }
            return;
        }
        public void Success()
        {
            string[] arr1 = new string[100];
            string[] arr2 = new string[100];
            string[] arr3 = new string[100];
            FileStream fileStreamobj = new FileStream("E:\\KelltonTech\\.NET training kellton\\Real Training Started\\FILE HANDLING FOR READING 2\\ReadFrom.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            Console.WriteLine("Id\tSource\tDestination\tDate\tTime\tStatus\tNetwork");
            string line1 = streamReaderobj.ReadLine();
            while (streamReaderobj.Peek() > 0)
            {
                string line2 = streamReaderobj.ReadLine();
                if (line2 != "")
                {
                    line1 = line1 + "\t" + line2;
                }
                else if (line2 == "")
                {
                    if (line1.Contains("Success"))
                    {
                        arr1 = line1.Split('\t');
                        arr2 = arr1[0].Split(':');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[1].Split(':');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[2].Split(':');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[3].Split(' ');
                        arr3 = arr2[0].Split(':');
                        Console.Write(arr3[1] + '\t');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[4].Split(':');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[5].Split(':');
                        Console.WriteLine(arr2[1] + '\t');
                    }
                    line1 = streamReaderobj.ReadLine();
                }

            }
            return; ;
        }
        public void Missed()
        {
            string[] arr1 = new string[100];
            string[] arr2 = new string[100];
            string[] arr3 = new string[100];
            FileStream fileStreamobj = new FileStream("E:\\KelltonTech\\.NET training kellton\\Real Training Started\\FILE HANDLING FOR READING 2\\ReadFrom.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            Console.WriteLine("Id\tSource\tDestination\tDate\tTime\tStatus\tNetwork");
            string line1 = streamReaderobj.ReadLine();
            while (streamReaderobj.Peek() > 0)
            {
                string line2 = streamReaderobj.ReadLine();
                if (line2 != "")
                {
                    line1 = line1 + "\t" + line2;
                }
                else if (line2 == "")
                {
                    if (line1.Contains("Missed"))
                    {
                        arr1 = line1.Split('\t');
                        arr2 = arr1[0].Split(':');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[1].Split(':');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[2].Split(':');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[3].Split(' ');
                        arr3 = arr2[0].Split(':');
                        Console.Write(arr3[1] + '\t');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[4].Split(':');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[5].Split(':');
                        Console.WriteLine(arr2[1] + '\t');
                    }
                    line1 = streamReaderobj.ReadLine();
                }

            }
            return;
        }
        public void Dialled()
        {
            string[] arr1 = new string[100];
            string[] arr2 = new string[100];
            string[] arr3 = new string[100];
            FileStream fileStreamobj = new FileStream("E:\\KelltonTech\\.NET training kellton\\Real Training Started\\FILE HANDLING FOR READING 2\\ReadFrom.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            Console.WriteLine("Id\tSource\tDestination\tDate\tTime\tStatus\tNetwork");
            string line1 = streamReaderobj.ReadLine();
            while (streamReaderobj.Peek() > 0)
            {
                string line2 = streamReaderobj.ReadLine();
                if (line2 != "")
                {
                    line1 = line1 + "\t" + line2;
                }
                else if (line2 == "")
                {
                    if (line1.Contains("Dialled"))
                    {
                        arr1 = line1.Split('\t');
                        arr2 = arr1[0].Split(':');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[1].Split(':');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[2].Split(':');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[3].Split(' ');
                        arr3 = arr2[0].Split(':');
                        Console.Write(arr3[1] + '\t');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[4].Split(':');
                        Console.Write(arr2[1] + '\t');
                        arr2 = arr1[5].Split(':');
                        Console.WriteLine(arr2[1] + '\t');
                    }
                    line1 = streamReaderobj.ReadLine();
                }

            }
            return;
        }
    }
}
