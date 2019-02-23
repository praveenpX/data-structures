using System;
					
public class Program
{
	public static void Main()
	{
		//int[] arr = new int[] {10,20,30,40,50};
		
		int[] arr = new int[] {1,2,90,10,110};
		
		Console.WriteLine(max_diff(arr));
	}
	
	public static int max_diff(int[] arr)
	{
		int length = arr.Length;
		
		int max_diff = 0;
		
		int min_elem = arr[0];
		
		for(int i =0; i < length; i++)
		{
			if(arr[i] - min_elem > max_diff)
			{
				max_diff = arr[i] - min_elem;
			}
			if(arr[i] < min_elem)
			{
				min_elem = arr[i];
			}
		}
		
		return max_diff;
	}
}
