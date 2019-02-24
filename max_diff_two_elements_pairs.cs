using System;

public class Program
{
	public static void Main()
	{
		int[] arr = new int[5] {80, 2, 6, 3, 100};
		Console.WriteLine(MaxDifference(arr));
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
