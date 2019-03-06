using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[4]{1,7,3,5}; //1,3,5,7
            
        int k = 2;
            
        kthLargest(arr, k);
        
        kthSmallest(arr, k);
    }
    
    public static void kthSmallest(int[] arr, int k)
    {
        int length = arr.Length;
        
        if(k >= length)
        {
            Console.WriteLine("the position is outside the bounds of the array");
            return;
        }
        
        Array.Sort(arr); //sort the array in ascending order, O(nlogn)
        
        int kthSmallest = arr[k-1];
        
        Console.WriteLine(k + "th smallest: " + kthSmallest);
            
    }
    
    public static void kthLargest(int[] arr, int k)
    {
        int length = arr.Length;
        
        int lastIndex = length -1;
        
        if(k >= length)
        {
            Console.WriteLine("the position is outside the bounds of the array");
            return;
        }
            
        Array.Sort(arr); //sort the array in ascending order, O(nlogn)
        
        Array.Reverse(arr); //1,3,5,7; sort the array in descending order
        
        int kthLargest = arr[lastIndex - k];
        
        Console.WriteLine(k + "th largest: " + kthLargest);
    }
}
