using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[8] {15, 2, 4, 8, 9, 5, 10, 23}; 
        
        int sum = 23;
        
        contiguoussum(arr, sum);
        
        findcontinuoussum(arr, sum);
    }
    
    public static bool findcontinuoussum(int[] arr, int sum)
    {
        int length = arr.Length;
        
        int calcsum = 0;
        int j =0;
        
        for(int i=0; i<length; i++)
        {
            while(j < length && calcsum < sum)
            {
                calcsum = calcsum + arr[j];
                j++;
            }
            if(calcsum == sum)
            {
                Console.WriteLine("found sum");
                return true;
                
            }
            calcsum = calcsum - arr[i];
        }
        return false;
    }
    
    public static void contiguoussum(int[] arr, int sum)
    {
        int length = arr.Length;
        
        int curr_sum =0;
        int i = 0;
        int j = 0;
        
        int ix=0;
        int iy=0;
        
        for(i=0; i<length; i++)
        {
            curr_sum = arr[i];
            
            for(j=i+1; j<length; j++)
            {
                if(curr_sum == sum)
                {
                    ix=i;
                    iy= j-1;
                    
                    Console.WriteLine("SubArray from: " + ix + " and " + iy);
                    return;
                }
                if(curr_sum > sum)
                {
                    break;
                }
                else
                {
                    curr_sum = curr_sum + arr[j];
                }
            }
        }
    }
}
