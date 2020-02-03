using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Calender
    {
        /*static int[,] calender = new int[5, 7];
        int[] days = {
            0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
        };
        static void PutCalender(int d)
        {
            int d1 = 1;
            for (int i = d; i < calender.Length; i++)
            {
                // System.out.print(d1);
                calender[0,i] = d1++;
            }
            for (int i = 1; i < calender.Length; i++)
            {
                for (int j = 0; j < calender.Length; j++)
                {
                    calender[i,j] = d1++;
                }
            }

        }*/
        public static int DAyOfMonth(int year,int month,int day)
        {
            
            int y = year - (14 - month) / 12;
            int x = y + y / 4 - y / 100 + y / 400;
            int m = month + 12 * ((14 - month) / 12) - 2;
            int d = (day + x + (31 * m) / 12) % 7;
            return d;
        }
        public static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0) && (year % 100 != 0)) return true;
            if (year % 400 == 0) return true;
            return false;
        }
        public static void CalenderPrint()
        {
            Console.WriteLine("enter the year");
            int year = Utility.IntInput();
            Console.WriteLine("enetr the month");
            int month = Utility.IntInput();
            //Console.WriteLine("enter start day of the month");
            //int day = Utility.IntInput();
            String[] months = {
                "","January", "February", "March","April", "May", 
                "June","July", "August", "September",
                "October", "November", "December"
        };
            int[] days = {
            0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
        };

            if (month == 2 && IsLeapYear(year)) days[month] = 29;

            Console.WriteLine("   " + months[month] + " " + year);
            Console.WriteLine(" S  M  Tu  W  Th  F  S");

            int d = DAyOfMonth(year, month, 1);

            for (int i = 0; i < d; i++)
                Console.Write("    ");
            for (int i = 1; i <= days[month]; i++)
            {
                Console.Write(i+"  ");
                if (((i + d) % 7 == 0) || (i == days[month])) 
                    Console.WriteLine();
            }
        }
    }
}

