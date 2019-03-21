using System;
using System.Collections;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[4] {1,1,3,2};
        
        removedups(arr);
    }
    
    public static void removedups(int[] arr)
    {
        int length = arr.Length;
        
        HashSet<int> list = new HashSet<int>();
        
        int k=0;
        
        for(int i=0; i<length; i++)
        {
            if(list.Contains(arr[i]))
            {
                
            }
            else
            {
                list.Add(arr[i]);
                
                arr[k] = arr[i];
                k++;
            }
        }
        
        for(int j=0; j<k; j++)
        {
            Console.Write(arr[j] + " ");
        }
    }
        
}
