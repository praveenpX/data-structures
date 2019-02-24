using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		int[] arr = new int[5] {0, -1, 2, -3, 1}; 
		findtriplets(arr);
		
		findtripletsoptimized(arr);
	}
	
	public static void findtripletsoptimized(int[] arr)
	{
		int length = arr.Length;
		
		for(int i =0; i < length; i++)
		{
			HashSet<int> sum = new HashSet<int>();
			
			for(int j = i+1; j < length; j++)
			{
				int z = -(arr[i] + arr[j]);
				
				if(sum.Contains(z))
				{
					//found triplet
					Console.WriteLine(arr[i] + " " + arr[j] + " " + z);
				}
				else
				{
					sum.Add(arr[j]);
				}
			}
		}
	}
	
	public static void findtriplets(int[] arr)
	{
		int length = arr.Length;
		
		for(int i =0; i < length; i++)
		{
			for(int j = i+1; j <length; j++)
			{
				for(int k = j+1; k < length; k++)
				{
					if(arr[i] + arr[j] + arr[k] == 0)
					{
						Console.WriteLine("triplets: " + arr[i] + "," + arr[j] + "," + arr[k]);
					}
				}
			}
		}
	}
}
