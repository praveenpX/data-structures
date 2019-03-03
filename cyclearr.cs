using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[7] {1,2,3,4,5,6,7};
        
        int d = 2;
        
        int length = arr.Length;
        
        cyclearr(arr, d);
        
        for(int i=0; i<length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
    
    public static void cyclearr(int[] arr, int d)
    {
        for(int i=0; i<d; i++)
        {
            cyclearrbyOne(arr);
        }
    }
    
    public static void cyclearrbyOne(int[] arr)
    {
        int length = arr.Length;
        
        int temp = arr[length -1];
        int i = length -1;
        
        for(i = length -1; i>0; i--)
        {
            arr[i] = arr[i-1];
        }
        arr[0] = temp;
    }
}
