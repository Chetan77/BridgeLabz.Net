using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class LeapYear
    {
        public static Boolean IsLeapYear() {
			Console.WriteLine("enetr the year to find leaf");
            int year = Utility.IntInput();
			Boolean leap = false;
			if (year % 4 == 0)
			{
				if (year % 100 == 0)
				{
					if (year % 400 == 0)
					{
						leap = true;
					}
					else
					{
						leap = false;
					}
				}
				else
				{
					leap = true;
				}
			}
			else
			{
				leap = false;
			}
			if (leap)
			{
				Console.WriteLine(year + " is a leap year.");
			}
			else
			{
				Console.WriteLine(year + " is not a leap year.");
			}
			return leap;
		}
    }
}
