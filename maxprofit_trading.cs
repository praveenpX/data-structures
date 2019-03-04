using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[5]{7, 1, 5, 3, 6};
        
        int p = maxdiff(arr);
        
        Console.WriteLine(p);
        
        maxdiffeff(arr);
    }
    
    public static void maxdiffeff(int[] arr)
    {
        int length = arr.Length;
        
        int max_diff = 0;
        
        int min_elem = arr[0];
        
        int i=0;
        
        int buy=0;
        
        int sell =0;
        
        
        for(i=0; i< length; i++)
        {
            if(arr[i] - min_elem > max_diff)
            {
                max_diff = arr[i] - min_elem;
                sell = i;
            }
            if(arr[i] < min_elem)
            {
                min_elem = arr[i];
                buy = i;
            }
        }
        
        Console.WriteLine("buy on day: " + buy + " sell on day: " + sell);
        Console.WriteLine(max_diff);
        
    }
    
    public static int maxdiff(int[] arr)
    {
        int length = arr.Length;
        int max_diff = 0;
        int buy = 0;
        int sell =0;
        int i =0;
        int j = 0;
        
        for(i=0; i< length; i++)
        {
            for(j=i+1; j<length; j++)
            {
                if(arr[j] -arr[i] > max_diff)
                {
                    max_diff = arr[j] - arr[i];
                    buy = i;
                    sell = j;
                }
            }
        }
        Console.WriteLine("buy on day: " + buy + " sell on day: " + sell);
        return max_diff;
    }
}
