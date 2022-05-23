using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;                          //File Handling

namespace FILE_HANDLING_FOR_READING
{
    public class Read
    {
        public void Readfrom()
        {
            FileStream fileStreamobj = new FileStream("E:\\KelltonTech\\.NET training kellton\\Real Training Started\\FILE HANDLING FOR READING\\ReadFrom.txt",FileMode.Open,FileAccess.Read);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);    //filestream & streamreader are pre defined class
            Console.WriteLine("Id\tSource\tDestination\tDate\tTime\tStatus\tNetwork");
            while (streamReaderobj.Peek() > 0)       //it checks for characters in that particular line. also it checks char. for next lines till end of file.txt
                                                     //if no char present it returns -1.1st it points to 1st line of file. if u run it 1 time then it point to next line    
                                                     
            {
                string line = streamReaderobj.ReadLine();  //declaration & initialization of string
                if(line != "")     //not empty
                {
                    if (line.StartsWith("Date"))          //their r more functns like endswith(""),contains("")
                    {
                        string[] newLine1 = line.Split(' ');           //declaration & initialization of string type array
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
