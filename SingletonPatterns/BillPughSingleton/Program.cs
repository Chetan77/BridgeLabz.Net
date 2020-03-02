using System;
using System.Reflection;

namespace BillPughSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Bridge obj1 = Bridge.GetBridge();
            Bridge obj2 = null;
            Type type = typeof(Bridge);
            Console.WriteLine("class name is " + type.Name);
            ConstructorInfo[] constructorInfos = type.GetConstructors();
            string name = ConstructorInfo.TypeConstructorName;
            Console.WriteLine(name.ToString());
            //obj2 = ConstructorInfo.TypeConstructorName();
            foreach (ConstructorInfo co in constructorInfos)
            {
                Console.WriteLine(co);
            }
        }
    }
}
