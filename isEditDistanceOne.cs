/*
Let the input strings be s1 and s2 and lengths of input 
strings be m and n respectively.

1) If difference between m an n is more than 1, 
     return false.
2) Initialize count of edits as 0.
3) Start traversing both strings from first character.
    a) If current characters don't match, then
       (i)   Increment count of edits
       (ii)  If count becomes more than 1, return false
       (iii) If length of one string is more, then only
             possible  edit is to remove a character.
             Therefore, move ahead in larger string.
       (iv)  If length is same, then only possible edit
             is to  change a character. Therefore, move
             ahead in both strings. 
    b) Else, move ahead in both strings. 
*/

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
