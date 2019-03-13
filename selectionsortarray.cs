using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[4]{40,30,20,10};
        
        SelectionSort(arr);
        
        for(int i=0; i<arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
    
    //big O(n^2), on average it's O(n)
    public static void SelectionSort(int[] arr)
    {
        int length = arr.Length;
        
        int min_idx = 0;
        
        for(int i=0; i<length -1; i++)
        {
            min_idx = i;
            
            for(int j = i+1; j<length; j++)
            {
                if(arr[j] < arr[min_idx])
                {
                    min_idx = j;
                }
            }
            //swap
            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }
}
