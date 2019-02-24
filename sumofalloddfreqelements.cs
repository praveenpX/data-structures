using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		int[] ele = new int[7] {1, 1, 2, 2, 3, 3, 3};
		addoddfreqelements(ele);
	}
	
	public static void addoddfreqelements(int[] arr)
	{
		int length = arr.Length;
		
		Dictionary<int, int> map = new Dictionary<int, int>();
		
		for(int i =0; i < length; i++)
		{
			if(map.ContainsKey(arr[i]))
			{
				int count = map[arr[i]];
				map[arr[i]] = count + 1;
			}
			else
			{
				map.Add(arr[i], 1);
			}
		}
		
		int sum = 0;
		
		foreach(var kvp in map)
		{
			if(kvp.Value % 2 !=0)
			{
				sum = kvp.Key * kvp.Value;
				Console.WriteLine(sum + " ");
			}
		}
	}
	
	public static int countdistinct(int[] arr)
	{
		int length = arr.Length;
		
		HashSet<int> distinct = new HashSet<int>();
		
		for(int i =0; i< length; i++)
		{
			distinct.Add(arr[i]);
		}
		
		Console.Write(distinct.Count);
		return distinct.Count;
	}
	
	public static int MaxDifference(int[] arr)
	{
		int length = arr.Length;
		int max_diff = 0;
		int min = arr[0];
		int max = arr[length-1];
		
		for (int i = 1; i < length; i++)
		{
			//larger element appears after smaller elem check, so diff is always greater than equal to zero
			if (arr[i] - min > max_diff)
			{
				max_diff = arr[i] - min;
				
				if (arr[i] < min)
				{
					min = arr[i];
				}

				if (arr[i] > max)
				{
					max = arr[i];
				}
			}
			if(arr[i] < min) //update min if necessary
			{
				min = arr[i];
			}
		}

		Console.WriteLine("min:" + min);
		Console.WriteLine("max:" + max);
		
		//Console.WriteLine(max_diff);
		return max_diff;
	}
}
