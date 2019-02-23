using System;
					
public class Program
{
	public static void Main()
	{
		int[] arr = new int[] {10,20,30,40,50};
		
		Console.WriteLine(max_diff(arr));
	}
	
	public static int max_diff(int[] arr)
	{
		int length = arr.Length;
		
		int max_diff = 0;
		
		for(int i =0; i< length; i++)
		{
			for(int j = i+1; j<length; j++)
			{
				if(arr[j] - arr[i] > max_diff)
				{
					max_diff = arr[j] - arr[i];
				}
			}
		}
		return max_diff;
	}
}
