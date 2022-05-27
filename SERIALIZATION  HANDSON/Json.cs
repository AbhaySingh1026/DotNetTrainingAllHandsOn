using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;                // for using JSON serialization/de - serialization 
using System.IO;                      //for file handling

namespace SERIALIZATION__HANDSON
{
    public class Json
    {
        public void Serialization(List<CustomerDetails> listObj)
        {
            FileStream fileStreamobj = new FileStream(@"E:\KelltonTech\.NET training kellton\Real Training Started\DotNetTrainingAllHandsOn\SERIALIZATION  HANDSON\JSON.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStreamobj);
            JsonWriter jsonWriter = new JsonTextWriter(streamWriter);
            JsonSerializer serializer = new JsonSerializer();
            serializer.Serialize(jsonWriter, listObj);
            jsonWriter.Close();
            streamWriter.Close();
            return;
        }
        public void DeSerialization(List<CustomerDetails> listObj)
        {
            FileStream fileStreamobj = new FileStream(@"E:\KelltonTech\.NET training kellton\Real Training Started\DotNetTrainingAllHandsOn\SERIALIZATION  HANDSON\JSON.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStreamobj);
            string a = streamReader.ReadToEnd();
            List<CustomerDetails> newList = JsonConvert.DeserializeObject<List<CustomerDetails>>(a);
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine(newList[i].customerId + "\t" + newList[i].customerName + "\t" + newList[i].noOfUnits + "\t" + newList[i].unitPerCost + "\t" + newList[i].total);
            }
            return;
        }
    }
}
