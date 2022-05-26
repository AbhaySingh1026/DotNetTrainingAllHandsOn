using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;    // for using XML serialization/de - serialization 
using System.IO;                   //for using file handling 

namespace SERIALIZATION__HANDSON
{
    public class Xml
    {
        public void Serialization(List<CustomerDetails> listObj)
        {                                                                //in filemode createFile if u opened file time but adding elements more than 1 time then it will wrk as append bt if u creating again for writing it will replace previous text
            FileStream fileStreamobj = new FileStream(@"E:\KelltonTech\.NET training kellton\Real Training Started\DotNetTrainingAllHandsOn\SERIALIZATION  HANDSON\XML.txt", FileMode.Append, FileAccess.Write);
            XmlSerializer serializerObj = new XmlSerializer(typeof(List<CustomerDetails>));
            serializerObj.Serialize(fileStreamobj, listObj);
            fileStreamobj.Close();
            return;
        }
        public void DeSerialization()
        {   
            FileStream fileStreamobjForDe = new FileStream(@"E:\KelltonTech\.NET training kellton\Real Training Started\DotNetTrainingAllHandsOn\SERIALIZATION  HANDSON\XML.txt", FileMode.Open);
            XmlSerializer serializerObjForDe = new XmlSerializer(typeof(List<CustomerDetails>));
            List<CustomerDetails> newList = (List<CustomerDetails>)serializerObjForDe.Deserialize(fileStreamobjForDe);
            fileStreamobjForDe.Close();
            for(int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine(newList[i].customerId+"\t"+ newList[i].customerName + "\t" + newList[i].noOfUnits + "\t" + newList[i].unitPerCost + "\t" + newList[i].total);
            }
            return;
        }
    }
}
