using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms.InventoryManagement
{
    public class Rice
    {
        private string name;
        private double price;
        private int weight;

        public string Name { get => this.name; set => this.name = value; }
        public double Price { get => price; set => price = value; }
        public int Weight { get => weight; set => weight = value; }

        public static void PrintRice()
        {
            InventoryDetails details= InventoryUtility.ReadJson();
            foreach(var rc in details.Rice)
            {
                Console.WriteLine("name :" + rc.name);
                Console.WriteLine("Price :" + rc.price);
                Console.WriteLine("weight" + rc.weight);
            }
        }
        public static void InsertRice(string name,double price,int weight)
        {
            InventoryDetails inventoryDetails= InventoryUtility.ReadJson();
            Rice rice = new Rice();
            rice.name = name;
            rice.price = price;
            rice.weight = weight;
            inventoryDetails.Rice.Add(rice);
            InventoryUtility.WriteIntoJson(inventoryDetails);
            Rice.PrintRice();

        }
        public static void DeleteRice(string name)
        {
            InventoryDetails inventoryDetails = InventoryUtility.ReadJson();
            int count = 0;
            foreach(var rs in inventoryDetails.Rice)
            {
                if(rs.name != name)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            inventoryDetails.Rice.RemoveAt(count);
            InventoryUtility.WriteIntoJson(inventoryDetails);
        }
    }
}
