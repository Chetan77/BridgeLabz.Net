using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public abstract class Computer
    {
        public abstract string GetRam();
        public abstract string GetHDD();
        public abstract string GetCPU();
    }
}
