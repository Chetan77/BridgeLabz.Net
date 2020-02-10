using System;

namespace OopsPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1 for address book problem \nenter 2 for Json Read from a file" +
                "\nenter 3 for inventory management");
            int n = OopsUtility.IntInput();
            switch (n)
            {
                case 1:
                    AddressBook.AddressBookTest();
                    break;
                case 2:
                    JsonRead.ReadJson();
                    break;
                case 3:
                    InventoryManagement.InventoryManage.Management();
                    break;
                case 4:
                    StockAccountManagement.StockAccountManagement.StockAccount();
                    break;
                default:
                    Console.WriteLine("enter correct value");
                    break;
            }
        }
    }
}
