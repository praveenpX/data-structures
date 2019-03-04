using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[5]{50, 40, 70, 60, 90}; 
        int[] index = new int[5]{3,  0,  4,  1,  2}; 
        
        reorder(arr, index);
        
        for(int i=0; i<arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
    
    public static int[] reorder(int[] arr, int[] index)
    {
        int length = arr.Length;
        
        int[] temp = new int[length];
        
        for(int i=0; i<length; i++)
        {
            temp[index[i]] = arr[i];
        }
        
        //copy
        for(int i=0; i<length; i++)
        {
            arr[i] = temp[i];
        }
        
        return arr;
    }
}
