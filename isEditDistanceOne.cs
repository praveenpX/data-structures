using System;

public class Program
{
	public static void Main()
	{
		String s1 = "gfg";
		String s2 = "gf";
		if (isEditDistanceOne(s1, s2))
			Console.WriteLine("Yes");
		else
			Console.WriteLine("No");
	}

	public static bool isEditDistanceOne(string s1, string s2)
	{
		int m = s1.Length;
		int n = s2.Length;
		if (Math.Abs(m - n) > 1)
			return false;
		int countedits = 0;
		int i = 0;
		int j = 0;
		while (i < m && j < n)
		{
			if (s1[i] != s2[j])
			{
				if (m > n)
				{
					i++;
				}
				else if (m < n)
				{
					j++;
				}
				else
				{
					i++;
					j++;
				}

				countedits++;
			}
			else
			{
				i++;
				j++;
			}
		}

		if (i < m || j < n)
			countedits++;
		return countedits == 1;
	}
}
