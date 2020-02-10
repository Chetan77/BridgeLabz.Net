using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OopsPrograms.StockAccountManagement
{
    public class StockAccountUtility
    {
        public static StockDetails[] ReadJson()
        {
            var jsonFile = File.ReadAllText(@"C:\Users\Bridge Labz\source\repos\OopsPrograms\StockAccountManagement\StockManagement.json");
            var stockObject=JsonConvert.DeserializeObject<StockDetails[]>(jsonFile);
            return stockObject;
        }
        public static void WriteJson(StockDetails stock)
        {
            var obj = JsonConvert.SerializeObject(stock);
            File.WriteAllText(@"C:\Users\Bridge Labz\source\repos\OopsPrograms\StockAccountManagement\StockManagement.json", obj);
        }

        public static void PrintStockDetails()
        {
            var stockDetil = StockAccountUtility.ReadJson();
            foreach (var stock in stockDetil)
            {
                Console.WriteLine(stock.Name);
            }
        }
    }
}
