using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FILE_HANDLING
{
    public class PurchaseAndSalesModule
    {
        public void Writefile(int salesId, long productId2, string salesDate, double price2)
        {
            FileStream fileStreamobj = new FileStream(@"E:\KelltonTech\.NET training kellton\Real Training Started\FILE HANDLING\Purchase.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterobj = new StreamWriter(fileStreamobj);
            streamWriterobj.Write("Sales Id - " + salesId + "," + " ");
            streamWriterobj.Write("Product Id - " + productId2 + "," + '\t');
            streamWriterobj.Write("Sales Date - " + salesDate + "," + " ");
            streamWriterobj.WriteLine("Price - " + price2);
            streamWriterobj.Close();
            fileStreamobj.Close();
            return;
        }
    }
}
