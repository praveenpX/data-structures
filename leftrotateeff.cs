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
        
        leftrotate(arr, d);
        
        for(int i=0; i<length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
    
    public static void leftrotate(int[] arr, int d)
    {
        int n = arr.Length;
        
        reverse(arr, 0, d-1); //ar
        reverse(arr, d, n-1); //arbr
        reverse(arr, 0, n-1); //r(arbr)
    }
    
    public static void reverse(int[] arr, int start, int end)
    {
        
        while(start < end)
        {
            int temp = arr[start];
            
            arr[start] = arr[end];
            arr[end] = temp;
            
            start++;
            end--;
        }
    }
}
