using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FILE_HANDLING_FOR_READING
{
    public class Read
    {
        public void Readfrom()
        {
            FileStream fileStreamobj = new FileStream("E:\\KelltonTech\\.NET training kellton\\Real Training Started\\FILE HANDLING FOR READING\\ReadFrom.txt",FileMode.Open,FileAccess.Read);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            Console.WriteLine("Id\tSource\tDestination\tDate\tTime\tStatus\tNetwork");
            while (streamReaderobj.Peek() > 0)
            {
                string line = streamReaderobj.ReadLine();
                if(line != "")
                {
                    if (line.StartsWith("Date"))
                    {
                        string[] newLine1 = line.Split(' ');
                        string[] newLine2 = newLine1[0].Split(':');
                        Console.Write(newLine2[1] + "\t" + newLine1[1] + "\t");
                        continue;
                    }
                    string[] newLine = line.Split(':');
                    Console.Write(newLine[1]+"\t");
                }
                else{
                    Console.WriteLine();
                }
            }
        }
    }
}
