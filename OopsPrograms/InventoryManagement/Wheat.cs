using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms.InventoryManagement
{
    public class Wheat
    {
        private string name;
        private double price;
        private int weight;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Weight { get => weight; set => weight = value; }

        public static void PrintWheat()
        {
            var wheat= InventoryUtility.ReadJson();
            foreach(var v in wheat.Wheat)
            {
                Console.WriteLine("name :"+v.name);
                Console.WriteLine("price :" + v.price);
                Console.WriteLine("weight :" + v.weight);
            }
        }
        public static void InsertWheat(string name,double price,int weight)
        {
            InventoryDetails inventoryDetails = InventoryUtility.ReadJson();
            Wheat wheat = new Wheat();
            wheat.name = name;
            wheat.price = price;
            wheat.weight = weight;
            inventoryDetails.Wheat.Add(wheat);
            InventoryUtility.WriteIntoJson(inventoryDetails);
            Wheat.PrintWheat();
        }
        public static void DeleteWheat(string name)
        {
            InventoryDetails inventoryDetails = InventoryUtility.ReadJson();
            int count = 0;
            foreach(var wh in inventoryDetails.Wheat)
            {
                if(wh.name != name)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            inventoryDetails.Wheat.RemoveAt(count);
            InventoryUtility.WriteIntoJson(inventoryDetails);
        }
    }
}
