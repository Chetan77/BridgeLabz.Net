using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class PowerOfTwo
    {
		public static void printTable()
		{
			Console.WriteLine("enter the number between 2 and 32");
			int pow = Utility.IntInput();
			int val = 1;
			if (pow < 32)
			{
				for (int i = 1; i <= pow; i++)
				{
					val = val * 2;
					Console.WriteLine(val);
				}
			}
			else {
				Console.WriteLine("enter the correct input");
				}
			}

		
	}
}