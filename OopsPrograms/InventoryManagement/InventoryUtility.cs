using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OopsPrograms.InventoryManagement
{
    public class InventoryUtility
    {
        public static InventoryDetails ReadJson()
        {
            var jsonFile=File.ReadAllText(@"C:\Users\Bridge Labz\source\repos\OopsPrograms\InventoryManagement\Inventory.json");
            var jsonObj = JsonConvert.DeserializeObject<InventoryDetails>(jsonFile);
            return jsonObj;
        }
        public static void WriteIntoJson(InventoryDetails newjson)
        {
            var nJs = JsonConvert.SerializeObject(newjson);
            File.WriteAllText(@"C:\Users\Bridge Labz\source\repos\OopsPrograms\InventoryManagement\Inventory.json", nJs);
        }
    }
}
