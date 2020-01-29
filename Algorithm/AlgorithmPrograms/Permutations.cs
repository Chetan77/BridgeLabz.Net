﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
	class Permutations
	{
		public static void CallerMethods()
		{
			Console.Write("enter a string to check permutations using recursion:");
			char[] ch = Utility.StringInput().ToCharArray();
			string s1 = PermutationsRec(ch, 0);
			Console.WriteLine(s1);
			Console.WriteLine("\n enter a string to check permutations using iteration:");
			string s = Utility.StringInput();
			Console.WriteLine();
			String s2 = PermutationUsingIteration(s);
			Console.WriteLine(s2);
			IsEqual(s1, s2);
		}
		public static void IsEqual(String s1, String s2)
		{
			Boolean result = s1.Contains(s2);
			if (result)
			{
				Console.WriteLine("two permutations are equal");
			}

		}
		public static String PermutationsRec(char[] ch, int currentIndex)
		{

			String result = "";

			if (currentIndex == ch.Length - 1)
			{
				result = new string(ch);
				Console.Write(result);
				Console.Write(" ");
			}

			for (int i = currentIndex; i < ch.Length; i++)
			{
				Swap(ch, currentIndex, i);
				PermutationsRec(ch, currentIndex + 1);
				Swap(ch, currentIndex, i);
			}
			return result;
		}
		public static void Swap(char[] ch, int i, int j)
		{
			char temp = ch[i];
			ch[i] = ch[j];
			ch[j] = temp;
		}

		public static String PermutationUsingIteration(String s)
		{
			string result = "";
			// convert string to a character array (Since String is immutable)
			char[] chars = s.ToCharArray();
			int[] p = new int[s.Length];
			Console.Write(s);
			int i = 1;
			while (i < chars.Length)
			{
				if (p[i] < i)
				{
					int j = ((i % 2) == 0) ? 0 : p[i];
					Swap(chars, i, j);
					result = new string(join(chars));
					Console.Write(" "+result);
					p[i]++;
					i = 1;    // reset index i to 1
				}
				// otherwise p[i] == i
				else
				{
					// reset p[i] to zero
					p[i] = 0;
					i++;
				}
			}
			return "";

		}
		private static String join(char[] a)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append(a);
			return builder.ToString();
		}
	}
}
		
		
