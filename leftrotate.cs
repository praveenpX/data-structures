using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[7] { 1, 2, 3, 4, 5, 6, 7 }; 
        
        leftrotate(arr, 2); 
        
        //big O(n * d)
        
        for(int k=0; k<arr.Length; k++)
        {
            Console.Write(arr[k] + " ");
        }
    }
    
    public static void leftrotate(int[] arr, int d)
    {
        for(int i=0; i<d; i++)
        {
            lrotate(arr);
        }
    }
    
    private static void lrotate(int[] arr)
    {
        int length = arr.Length;
        
        int temp = arr[0];
        
        int i=0;
        
        for(i=0; i<length-1; i++)
        {
            arr[i] = arr[i+1];
        }
        
        //last element
        arr[i] = temp;
    }
}
