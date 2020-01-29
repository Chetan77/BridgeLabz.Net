using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class DayOfWeek
    {
        public static int WeeekDay()
        {
            Console.WriteLine("enter the to find the day");
            int year =Utility.IntInput();
            Console.WriteLine("enter the month");
            int month = Utility.IntInput();
            Console.WriteLine("enter date ");
            int day = Utility.IntInput();
            int y0 = year-((14 - month)/12);
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (day + x + 31*m0 / 12) % 7;
            Console.WriteLine("day of the week is" + d0);
            return d0;
        }
    }
}
