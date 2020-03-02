using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer laptop= ComputerFactory.GetComputer("laptop", "4gb", "1tb", "2.8GHz");
            Computer pc = ComputerFactory.GetComputer("pc", "2gb", "500gb", "2.4GHz");
            Computer server = ComputerFactory.GetComputer("server", "4gb", "1tb", "2.8GHz");
            Console.WriteLine("configs are " + laptop.GetHDD()+","+laptop.GetCPU()+ ","+laptop.GetRam());
            Console.WriteLine(pc.GetHDD() + "," + pc.GetCPU() + "," + pc.GetRam());
            Console.WriteLine(server.GetHDD() + "," + server.GetCPU() + "," + server.GetRam());
        }
    }
}
