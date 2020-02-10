using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms.StockAccountManagement
{
    class StockAccountManagement
    {
        public static void StockAccount()
        {
            StockAccountUtility.PrintStockDetails();
            Console.WriteLine("enter 1 to buy the share \nenter 2 to sell the share");
            int option = OopsUtility.IntInput();
            switch (option)
            {
                case 1:
                    BuyShares();
                    break;
                case 2:
                    SellShares();
                    break;
            }
        }
        public static void BuyShares()
        {
            Console.WriteLine("select the option from which company you want to buy  \nfrom HoneyWell eneter 1   \nfrom Oracle enter 2 " +
                "\nfrom microland enter 3");
            int company = OopsUtility.IntInput();
            Console.WriteLine("enter the number of shares you want to buy");
            int shares = OopsUtility.IntInput();
            var totalShares = StockAccountUtility.ReadJson();
            int count = 0;
            foreach(var share in totalShares)
            {
                if (company-1 == count)
                {
                    share.Shares = share.Shares - shares;
                }
                else
                {
                    count++;
                }
                if (count == 2)
                {
                    StockAccountUtility.WriteJson(share);
                }
            }
        }
        public static void SellShares()
        {
            Console.WriteLine("select the option from which company you want to sell  \nto HoneyWell eneter 1   \nto Oracle enter 2 " +
                "\nto microland enter 3");
            int company = OopsUtility.IntInput();
            Console.WriteLine("enter the number of shares you want to sell");
            int shares = OopsUtility.IntInput();
            var totalShares = StockAccountUtility.ReadJson();
            int count = 0;
            foreach (var share in totalShares)
            {
                if (company - 1 == count)
                {
                    share.Shares = share.Shares + shares;
                    return;
                }
                else
                {
                    count++;
                }
                if (count==2)
                {
                    StockAccountUtility.WriteJson(share);
                }
            }
        }
    }
}
