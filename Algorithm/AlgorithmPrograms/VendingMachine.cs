using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
	class VendingMachine
	{
		static int i = 0;
		static int total = 0;

		//Initialization of New Array
		static int[] notes = { 2000, 500, 100, 50, 20, 10, 5, 2, 1 };
		static int money;
		public static int MoneyInptu()
		{
			Console.WriteLine("enter the amount");
			money = Utility.IntInput();
			Calculate(money, notes);
			Console.WriteLine("total number of notes are " + total);
			return total;
		}
		// Function for Calculating the notes
		public static int Calculate(int money, int[] notes)
		{
			//calling calculate Function
			int rem;
			if (money == 0)
			{
				return -1;
			}
			else
			{
				if (money >= notes[i])
				{
					// logic for Calculating The notes
					int calNotes = money / notes[i];
					rem = money % notes[i];
					money = rem;
					total = total + calNotes;
					Console.WriteLine(notes[i] + " Notes ---> " + calNotes);
				}
				i++;
				return Calculate(money, notes);
			}
		}
	}
}
