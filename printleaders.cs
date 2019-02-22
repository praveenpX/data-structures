using System;

public class Program
{
	public static void Main()
	{
		int[] arr = new int[]{1, 1, 2, 1, 3, 5, 1};
		// Function calling  
		printLeaders(arr);
	}

	public static void printLeaders(int[] arr)
	{
		int length = arr.Length;
		int right_most = arr[length - 1];
		Console.WriteLine(right_most + " ");
		for (int i = length - 2; i >= 0; i--)
		{
			if (right_most < arr[i])
			{
				right_most = arr[i];
				Console.WriteLine(right_most + " ");
			}
		}
	}
}
