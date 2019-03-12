using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[4] {70,20,30,40};
        
        threelargestelements(arr);
    }
    
    public static void threelargestelements(int[] arr)
    {
        int length = arr.Length;
        
        int first = 0;
        int second = 0;
        int third = 0;
        
        for(int i=0; i<length; i++)
        {
            if(arr[i] > first)
            {
                third = second;
                second = first;
                first = arr[i];
            }
            else if(arr[i] > second)
            {
                third = second;
                second = arr[i];
            }
            else if(arr[i] > third)
            {
                third = arr[i];
            }
        }
        
        Console.WriteLine("first-second-third: " + first + " " + second + " " + third);
    }
}
