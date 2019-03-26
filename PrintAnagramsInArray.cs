using System;
using System.Collections;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        string[] words = new string[] { "cat", "dog", "tac", "god", "act" };
        
        FindAnagrams f = new FindAnagrams();
        
        f.PrintAnagrams(words);
    }
}

public class FindAnagrams
{
    public  void PrintAnagrams(string[] words)
    {
        int length = words.Length;
        
        if(length == 0)
            return;
        
        
        Dictionary<int, List<string>> map = new Dictionary<int, List<string>>();
        
        for(int i=0; i<length; i++)
        {
            string word = words[i];
            
            char[] letters = word.ToCharArray();
            
            Array.Sort(letters);
            
            string newword = new string(letters);
            
            int key = newword.GetHashCode();
            
            if(map.ContainsKey(key))
            {
                List<string> wds = map[key];
                
                wds.Add(word);
                
                map.Remove(key);
                
                map.Add(key, wds);
            }
            else
            {
                List<string> wds = new List<string>();
                
                wds.Add(word);
                map.Add(key, wds);
            }
        }
        
        foreach(var kvp in map)
        {
            foreach(var wd in kvp.Value)
            {
                Console.Write(wd + " ");
            }
        }
    }
}
