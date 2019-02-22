using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		int[] arr = new int[]{2, 3, 5, 4, 5, 2, 4, 3, 5, 2, 4, 4, 2};
		getOddOccurrence(arr);
	}

	public static void getOddOccurrence(int[] arr)
	{
		int length = arr.Length;
		Dictionary<int, int> keyfreqmap = new Dictionary<int, int>();
		for (int i = 0; i < length - 1; i++)
		{
			if (!keyfreqmap.ContainsKey(arr[i]))
			{
				keyfreqmap.Add(arr[i], 1); //add it to dictionary
			}
			else
			{
				int count = keyfreqmap[arr[i]];
				keyfreqmap[arr[i]] = count + 1;
			}
		}

		Console.Write("numbers with odd frequency: ");
		foreach (var kvp in keyfreqmap)
		{
			if (kvp.Value % 2 != 0)
			{
				Console.Write(kvp.Key + " ");
			}
		}
	}
}
