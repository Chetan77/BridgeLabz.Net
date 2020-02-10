using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms.InventoryManagement
{
    public class Pulses
    {
        private string name;
        private double price;
        private int weight;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Weight { get => weight; set => weight = value; }

        public static void PrintPulse()
        {
            InventoryDetails pulse = InventoryUtility.ReadJson();
            foreach(var p in pulse.Pulses)
            {
                Console.WriteLine("name :"+p.name);
                Console.WriteLine("price :" + p.price);
                Console.WriteLine("weight :" + p.weight);
            }
        }

        public static void InsertPulse(string name,double price,int weight)
        {
            InventoryDetails inventoryDetails = InventoryUtility.ReadJson();
            Pulses pulses = new Pulses();
            pulses.name = name;
            pulses.price = price;
            pulses.weight = weight;

            inventoryDetails.Pulses.Add(pulses);
            InventoryUtility.WriteIntoJson(inventoryDetails);
        }
        public static void DeletePulses(string name)
        {
            InventoryDetails inventoryDetails = InventoryUtility.ReadJson();
            int count = 0;
            foreach(var pu in inventoryDetails.Pulses)
            {
                if(pu.name != name)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            inventoryDetails.Pulses.RemoveAt(count);
        }
    }
}
