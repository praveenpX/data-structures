using System;
using System.Collections;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        String str = "23";
        
        List<string> results = PhoneWordGenerator.PrintKeywords(str);
        
        
        foreach(string res in results)
        {
            Console.Write(res + " ");
        }
    }
}

public class PhoneWordGenerator
{
    public static string[] codes = new string[] {"", "ABC", "DEF", "GHI",
                                                "JKL", "MNO", "PQR", "STU",
                                                "VWX", "YZ"};
    
    public static List<string> PrintKeywords(string str)
    {
        if(str.Length == 0)
        {
            List<string> baseRes = new List<string>();
            
            baseRes.Add(" ");
            return baseRes;
        }
        
        char ch = str[0];
        
        string restStr = str.Substring(1);
        
        List<string> prevRes = PrintKeywords(restStr);
        
        List<string> res = new List<string>();
        
        string code = codes[ch - '0'];
        
        foreach(string s in prevRes)
        {
            for(int i=0; i<code.Length; i++)
            {
                res.Add(code[i] + s);
            }
        }
        
        return res;
    }
}
