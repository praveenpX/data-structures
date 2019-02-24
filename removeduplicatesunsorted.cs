using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public class Program
{
	public static void Main()
	{
		int[] dups = new int[8]{1, 2, 5, 1, 7, 2, 4, 2};
		removeduplicates(dups);
	}

	public static void removeduplicates(int[] arr)
	{
		int length = arr.Length;
		HashSet<int> distinct = new HashSet<int>();
		for (int i = 0; i < length; i++)
		{
			if (!distinct.Contains(arr[i]))
			{
				distinct.Add(arr[i]);
			}
		}

		int[] results = distinct.ToArray();
		for (int i = 0; i < results.Length; i++)
		{
			Console.WriteLine(results[i]);
		}
	}
}
