using System;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PermutationOfString
    {
		static Collection<String> s = new Collection<string>();
		static Collection<String> RecursivePermutation(String str, String ans)
		{
			s.ToString();
			if (str.Length == 0)
			{
				s.Add(ans);
			}

			for (int i = 0; i < str.Length; i++)
			{

				char ch = str[i];

				String ros = str.Substring(0, i) + str.Substring(i + 1);
				RecursivePermutation(ros, ans + ch);
			}
			return s;
		}
		public static void AllPermutation()
		{
			//taking the string to find the permutations
			Console.WriteLine("enetr a string to find permuatations");
			String str = Utility.StringInput();
			// recursive methodb  to find the permutations of a string
			Collection<String> rec = RecursivePermutation(str, "");
			//iterative method to find the permutations
			Console.WriteLine("permutations from recursive method");
			foreach (String r in rec)
			{
				Console.WriteLine(r);
			}
			int n = str.Length;
			Collection<String> itrtv = Permute(str, 0, n - 1);
			Console.WriteLine("permutations from iterative method");
			foreach (String a in itrtv)
			{
				Console.WriteLine(a);
			}
			Boolean b = permuteEqual(rec, itrtv);
			if (b)
			{
				Console.WriteLine("permutations returned by two methods are equal");
			}
			else
			{
				Console.WriteLine("permutations returned by two methods are not equal");
			}
		}
		static Collection<String> c = new Collection<String>();
		public static Collection<String> Permute(String str,
								int l, int r)
		{

			if (l == r)
			{
				c.Add(str);
			}

			else
			{
				for (int i = l; i <= r; i++)
				{
					str = swap(str, l, i);
					Permute(str, l + 1, r);
					str = swap(str, l, i);
				}
			}
			return c;
		}
		public static String swap(String a,
							  int i, int j)
		{
			char temp;
			char[] charArray = a.ToCharArray();
			temp = charArray[i];
			charArray[i] = charArray[j];
			charArray[j] = temp;
			string s = new string(charArray);
			return s;
		}
		private static Boolean permuteEqual(Collection<String> al1, Collection<String> al2)
		{
			if(al1.Count != al2.Count)
			{
				return false;
			}
			foreach(String al in al1)
			{
				if (al2.Contains(al))
				{
					return true;
				}
			}
			foreach(String a in al2)
			{
				if (al1.Contains(a))
				{
					return true;
				}
			}
			return false;
		}
	}
}
