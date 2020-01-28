using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class FlipCoin
    {
        public static Double FlipCoinPercent() {
			Console.WriteLine("enter a how meny times the coin has to flip");
			int times =Utility.IntInput();
			double heads = 0;
			Random random = new Random();
			for (int i = 0; i < times; i++)
			{
				if (random.NextDouble() > 0.5)
				{
					heads++;
				}
			}
			Double hPercentage = (float)(heads / times) * 100;
			Double tPercentage=(float)((times-heads)/times)*100;
			Console.WriteLine("heads percentage is " + (heads / times) * 100);
			Console.WriteLine("tails percentage is " + (times - heads) / times * 100);
			return hPercentage;
		}
    }
}
