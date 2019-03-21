using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        string a = "11";
        string b = "1";
        
        binarySum(a,b);
    }
    
    public static void binarySum(string a, string b)
    {
        int i = a.Length-1;
        int j = b.Length-1;
        
        int sum = 0;
        string result = "";
        
        while(i>=0 || j>=0 || sum ==1)
        {
            if(i>=0)
            {
                sum = sum + (a[i] - '0');
            }
            if(j>=0)
            {
                sum = sum + (b[j] - '0'); //convrting char to int, shortcut
            }
            
            result = (char)(sum % 2 + '0') + result;
            
            sum = sum/2;
            
            i--;
            j--;
        }
        
        Console.WriteLine(result);
    }
}
