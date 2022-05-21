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
        public void Reading(string input)
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
                    if (line1.Contains(input))
                    {
                        arr1 = line1.Split('\t');
                        for(int i = 0; i < arr1.Length; i++)
                        {
                            if (i == 3)
                            {
                                arr2 = arr1[i].Split(' ');
                            }
                            else
                            {
                                arr2 = arr1[i].Split(':');
                            }
                            Console.Write(arr2[1]+'\t');
                        }
                        Console.WriteLine();
                        
                    }
                    line1 = streamReaderobj.ReadLine();
                }

            }
            return;
        }
        
    }
}
