using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FILE_HANDLING
{
    public class CategoryModule
    {
        public void Writefile(long categoryId, string categoryType)
        {
            FileStream fileStreamobj = new FileStream(@"E:\KelltonTech\.NET training kellton\Real Training Started\FILE HANDLING\Category.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterobj = new StreamWriter(fileStreamobj);
            streamWriterobj.Write("Category Id - " + categoryId + "," + " ");
            streamWriterobj.WriteLine("Category Type - " + categoryType);
            streamWriterobj.Close();
            fileStreamobj.Close();
            return;
        }
    }
}
