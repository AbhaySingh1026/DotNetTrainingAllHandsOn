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
            FileStream fileStreamobj = new FileStream(@"E:\KelltonTech\.NET training kellton\Real Training Started\DotNetTrainingAllHandsOn\SERIALIZATION  HANDSON\JSON.txt", FileMode.Append, FileAccess.Write);
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
            
        }
    }
}
