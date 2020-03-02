using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    class ComputerFactory
    {
        public static Computer GetComputer(string type, string ram, string hdd, string cpu)
        {
            if ("PC".ToLower().Equals(type))
            {
                return new PC(ram, hdd, cpu);
            }
            else if (type.ToLower().Equals("laptop"))
            {
                return new LapTop(ram, hdd, cpu);
            }
            else if (type.ToLower().Equals("server"))
            {
                return new Server(ram, hdd, cpu);
            }
            else return null;
        }
    }
}
