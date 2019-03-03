using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int capacity = 10;
        
        
        int[] arr = new int[capacity];
        arr[0] = 1;
        arr[1] = 2;
        arr[2] = 3;
        arr[3] = 4;
        
        int size = 4;
        int key = 5;
        
        for(int i=0; i<arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        
        insertelement(arr, size, key, capacity);
        
        Console.WriteLine();
        
        for(int i=0; i<arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        
        
        deleteelement(arr, 1);
        
        Console.WriteLine();
        
        for(int i=0; i<arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
    
    public static int insertelement(int[] arr, int n, int key, int capacity)
    {
        if(n >= capacity)
            return n;
        
        arr[n] = key;
        
        return n+1; //return new size
    }
    
    public static int findelement(int[] arr, int key)
    {
        int length = arr.Length;
        
        for(int pos=0; pos<length; pos++)
        {
            if(arr[pos] == key)
            {
                return pos;
            }
        }
        return -1;
    }
    
    public static int deleteelement(int[] arr, int key)
    {
        int length = arr.Length;
        
        int position = findelement(arr, key);
        
        if(position == -1)
            return length;
        
        
        for(int i = position; i<length-1; i++)
        {
            arr[i] = arr[i+1];
        }
        return length -1;
    }
}
