using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OopsPrograms
{
    public class JsonRead
    {
        public static void ReadJson()
        {
            String file = File.ReadAllText(@"C:\Users\Bridge Labz\source\repos\OopsPrograms\Demo.json");
            var jsonWrit = JsonConvert.DeserializeObject<List<JsonWrite>>(file);

            foreach(var i in jsonWrit)
            {
                Console.WriteLine("name is  "+i.Name);
                Console.WriteLine("weight is"+i.Weight);
                Console.WriteLine("price is "+i.Price);
            }

        }
    }
}

