using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class HarmonicSum
    {
		public static double nthHarmonic()
		{
			Console.WriteLine("enter the value of n to find sum of harmonic");
			int N = Utility.IntInput();
			float harmonic = 1;

			for (int i = 2; i <= N; i++)
			{
				harmonic = harmonic + (float)1 / i;
				Console.Write("1/" + i + "+");
			}
			Console.WriteLine();
			Console.WriteLine("sum of harmonic number is " + harmonic);

			return harmonic;
		}
	}
}
