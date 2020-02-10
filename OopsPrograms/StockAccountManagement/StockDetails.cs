using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms.StockAccountManagement
{
    public class StockDetails
    {
        private string name;
        private int shares;
        private double price;

        public string Name { get => this.name; set => this.name = value; }
        public int Shares { get => this.shares; set => this.shares = value; }
        public double Price { get => this.price; set => this.price = value; }


       
    }
}
