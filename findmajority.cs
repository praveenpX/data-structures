using System;
using System.Collections;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[9] {3, 3, 4, 2, 4, 4, 2, 4, 4};
        
        findMajority(arr);
    }
    
    public static void findMajority(int[] arr)
    {
        int length = arr.Length;
        
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        for(int i=0; i< length; i++)
        {
            if(map.ContainsKey(arr[i]))
            {
                int val = map[arr[i]];
                
                map[arr[i]] = val + 1;
                
                if(val + 1 > length /2)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
            else
            {
                map.Add(arr[i], 1);
            }
        }
    }
}
