using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class EcludianDistance
    {
        public static float Distance()
        {
            Console.WriteLine("enter the value of x");
            float x = Utility.FloatInput();
            Console.WriteLine("enter the value of y");
            float y = Utility.FloatInput();
            float distance = (float) Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)));
            Console.WriteLine("ecludian distance from origine is " + distance);
            return distance;
        }
    }
}
