using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class TemperatureConversion
    {
        public static double MethodType()
        {
            Console.WriteLine("for farenheat to °c enter 1 \nfor celcius to farenheat enter 2");
            int n = Utility.IntInput();
            switch (n)
            {
                case 1:
                    double t=convertTemperatureToCelcius();
                    return t;
                    //break;

                case 2:
                    double f=convertTemperatureTofarenheat();
                    return f;
                   // break;
            }
            return 0;
        }
        public static double convertTemperatureToCelcius()
        {
            Console.WriteLine("enter temperature in °F");
            Double t = Utility.DoubleInput();
            Double c = (t - 32) * 5 / 9;
            Console.WriteLine("temperatuure in °c is =" + c);
            return c;
        }
        public static double convertTemperatureTofarenheat()

        {
            Console.WriteLine("enter temperature in °c");
            Double t = Utility.DoubleInput();
            Double f = (t * 9 / 5) + 32;
            Console.WriteLine("temperatuure in °f is =" + f);
            return f;
        }
    }
}
