using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FILE_HANDLING
{
    public class ProductModule
    {
        public void Writefile(int productId, string categoryType2, string productName, int quantity, double price)
        {
            FileStream fileStreamobj = new FileStream(@"E:\KelltonTech\.NET training kellton\Real Training Started\FILE HANDLING\Product.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterobj = new StreamWriter(fileStreamobj);
            streamWriterobj.Write("Product Id - " + productId + "," + " ");
            streamWriterobj.Write("Category Type - " + categoryType2 + "," + '\t');
            streamWriterobj.Write("Product Name - " + productName + "," + '\t');
            streamWriterobj.Write("Quantity - " + quantity + "," + '\t');
            streamWriterobj.WriteLine("Price - " + price);
            streamWriterobj.Close();
            fileStreamobj.Close();
            return;
        }
    }
}
