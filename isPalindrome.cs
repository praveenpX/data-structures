using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        isPalindrome("abba"); 
        isPalindrome("abbccbba"); 
        isPalindrome("geeks");
    }
    
    public static void isPalindrome(string str)
    {
        int start = 0;
        int end = str.Length-1;
        
        while(start < end)
        {
            if(str[start] != str[end])
            {
                Console.WriteLine(str + "--> is not a palindrome");
                return;
            }
            
            start++;
            end--;
        }
        Console.WriteLine(str + "--> is a palindrome");
    }
}
