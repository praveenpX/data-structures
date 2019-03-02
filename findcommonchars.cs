using System;
using System.Collections;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        string s1 = "geeksforgeeks";
        string s2 = "geeks";
        
        //big O(m + n)
        
        findcommonchars(s1, s2);
    }
    
    public static void findcommonchars(string s1, string s2)
    {
        int m = s1.Length;
        
        int n = s2.Length;
        
        Dictionary<char, int> map = new Dictionary<char, int>();
        
        for(int i=0; i< m; i++)
        {
            char key = s1[i];
            
            if(map.ContainsKey(key))
            {
                int val = map[key];
                
                map[key] = val + 1;
            }
            else
            {
                map.Add(key, 1);
            }
        }
        
        
        for(int j=0; j<n; j++)
        {
            char key = s2[j];
            
            if(map.ContainsKey(key))
            {
                Console.Write(key + " ");
            }
        }
    }
}
