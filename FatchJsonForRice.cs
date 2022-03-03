using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagement
{
    public class FetchJsonForRice
    {
        public Rice Read(string path)
        {
            using (StreamReader file = new StreamReader(path))

            {
                try
                {
                    string json = file.ReadToEnd();
                    var riceobject = JsonConvert.DeserializeObject<Rice>(json);
                    return riceobject;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Problem in reading the file");
                    return null;
                }
            }
        }

    }
}