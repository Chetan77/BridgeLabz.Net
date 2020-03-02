using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public class PC : Computer
    {
        private string ram;
        private string hdd;
        private string cpu;

        public PC(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        public string Ram { get => ram; }
        public string Hdd { get => hdd; }
        public string Cpu { get => cpu; }

        public override string GetCPU()
        {
            return this.ram;
        }

        public override string GetHDD()
        {
            return this.hdd;
        }

        public override string GetRam()
        {
            return this.cpu;
        }
    }
}
