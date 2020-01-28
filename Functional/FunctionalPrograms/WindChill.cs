using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class WindChill
    {
        public static double Chill()
        {
            Console.WriteLine("enter the temperature in farenheat");
            double t = Utility.DoubleInput();
            Console.WriteLine("enter the velocity in miles per hour");
            double v = Utility.DoubleInput();
            double w = 35.74 + 0.6215 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);
            Console.WriteLine("wind chill is" + w);
            return w;
        }
    }
}
