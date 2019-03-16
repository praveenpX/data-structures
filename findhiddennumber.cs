using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[3] {1,2,3};
        
        findhiddennumber(arr);
        
    }
    
    public static void findhiddennumber(int[] arr)
    {
        int length = arr.Length;
        
        long sum = 0;
        
        for(int i=0; i<length; i++)
        {
            sum = sum + arr[i];
        }
        
        long x = sum / length;
        
        if(length * x == sum)
        {
            Console.Write(x);
        }
        else
        {
            Console.Write("not found);
        }
    }
}
