using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[10] {1,2,3,4,5,0,0,0,0,0};
        
        //calcavg(arr);
        
        pushZerosToLeft(arr);
    }
    
    //avg of n- natural numbers
    public static void calcavg(int[] arr)
    {
        int length = arr.Length;
        
        int lastIndex = length -1;
        
        int n = arr[lastIndex];
        
        double avg = (n + 1.0) / 2;
        
        Console.WriteLine(avg);
    }
    
    public static void pushZerosToLeft(int[] arr)
    {
        int length = arr.Length;
        
        int k =0;
        
        for(int i=0; i<length; i++)
        {
            if(arr[i] == 0)
            {
                int temp = arr[i];
                arr[i] = arr[k];
                arr[k] = temp;
                k++;
            }
        }
        
        
        for(int i=0; i<length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        
    }

        
    public static void pushZerosToEnd(int[] arr)
    {
        int length = arr.Length;
        
        int count = 0;
        
        for(int i=0; i<length; i++)
        {
            if(arr[i] != 0)
            {
                arr[count++] = arr[i];
            }
        }
        
        while(count < length)
        {
            arr[count++] = 0;
        }
    }
}
