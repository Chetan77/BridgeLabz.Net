using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OopsPrograms.InventoryManagement
{
    public class InventoryManage
    {
        public static void Management()
        {
            

            string jsonFile = File.ReadAllText(@"C:\Users\Bridge Labz\source\repos\OopsPrograms\InventoryManagement\Inventory.json");
            InventoryDetails jsonObj = JsonConvert.DeserializeObject<InventoryDetails>(jsonFile);

            //Console.WriteLine(jsonObj.Rice[0].Name);
            //Rice.PrintRice();
            //foreach (var iy in jsonObj.Rice)
            //{
            //    Console.WriteLine(iy.Name);
            //    Console.WriteLine(iy.Price);
            //    Console.WriteLine(iy.Weight);
            //}
            Console.WriteLine("enter 1 to add inventory \nenter 2 to delete inventory");
            int number = OopsUtility.IntInput();
            switch (number)
            {
                case 1:
                    Console.WriteLine("To add rice enter :1 \nTo add Wheat enter :2 \nTo add Pulses enter 3");

                    int option = OopsUtility.IntInput();
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("enter the name");
                            string name = OopsUtility.StringInput();
                            Console.WriteLine("enter price");
                            double price = OopsUtility.DoubleInput();
                            Console.WriteLine("enter weight");
                            int weight = OopsUtility.IntInput();
                            Rice.InsertRice(name, price, weight);
                            break;

                        case 2:
                            Console.WriteLine("enter the name");
                            string wname = OopsUtility.StringInput();
                            Console.WriteLine("enter price");
                            double wprice = OopsUtility.DoubleInput();
                            Console.WriteLine("enter weight");
                            int wweight = OopsUtility.IntInput();
                            Wheat.InsertWheat(wname, wprice, wweight);

                            break;

                        case 3:
                            Console.WriteLine("enter the name");
                            string pname = OopsUtility.StringInput();
                            Console.WriteLine("enter price");
                            double pprice = OopsUtility.DoubleInput();
                            Console.WriteLine("enter weight");
                            int pweight = OopsUtility.IntInput();
                            Pulses.InsertPulse(pname, pprice, pweight);
                            Pulses.PrintPulse();
                            break;
                        default:
                            Console.WriteLine("enter correct value");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("To delete rice enter :1 \nTo delete Wheat enter :2 \nTo delete Pulses enter 3");

                    int delete = OopsUtility.IntInput();
                    switch (delete)
                    {
                        case 1:
                            Console.WriteLine("enter the name of rice to delete");
                            string rice = OopsUtility.StringInput();
                            Rice.DeleteRice(rice);
                            break;
                        case 2:
                            Console.WriteLine("enter the name of rice to delete");
                            string wheat = OopsUtility.StringInput();
                            Wheat.DeleteWheat(wheat);
                            break;
                        case 3:
                            Console.WriteLine("enter the name of rice to delete");
                            string pulse = OopsUtility.StringInput();
                            Pulses.DeletePulses(pulse);
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("enetr corrwct option");
                    break;
            }
            
            Rice.PrintRice();

        }
    }
}
