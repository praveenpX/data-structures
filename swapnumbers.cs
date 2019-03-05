using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int x = 10;
        int y = 5;
        
        Console.WriteLine("Before: (a, b)->(" + x +"," + y + ")");
        
        Swap(x,y);
    }
    
    public static void Swap(int x, int y)
    {
        x = x + y;
        y = x - y;
        x = x - y;
        
        Console.WriteLine("After: (a, b)->(" + x +"," + y + ")");
    }
}
