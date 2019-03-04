using System;
using System.Collections;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[] {4, 2, -1, 1, -5, 6, -4};
        
        //findtriplet(arr, 0);
        
        //findtripleteff(arr, 0);
        
        int[] A = new int[6] {1, 4, 45, 6, 10, 8}; 
            int n = 16; 
            //findpairs(A, n); 
        
        int[] arr3 = new int[8] {15, 2, 4, 8, 9, 5, 10, 23}; 
        
        int sum = 23;
        
        contsum(arr3, sum);
    }
    
    public static void contsumeff(int[] arr, int sum)
    {
        int length = arr.Length;
        
        int curr_sum =0;
        int i = 0;
        int j = 0;
        
        for(i=0; i<length; i++)
        {
            while(j < length && curr_sum < sum)
            {
                curr_sum = curr_sum + arr[j];
                j++;
            }
            if(curr_sum == sum)
            {
                Console.WriteLine("found sum");
            }
            curr_sum = curr_sum - arr[i]; //start over from next element
        }
        Console.WriteLine("not found sum");
    }
    
    
    public static void contsum(int[] arr, int sum)
    {
        int length = arr.Length;
        
        int curr_sum = 0;
        int i=0;
        int j=0;
        
        for(i=0; i<length; i++)
        {
            curr_sum = arr[i];
            
            for(j=i+1; j<length; j++)
            {
                if(curr_sum == sum)
                {
                    Console.WriteLine("index: " + i + "-" + (j-1));
                }
                if(curr_sum > sum)
                {
                    break;
                }
                curr_sum = curr_sum + arr[j];
            }
        }
    }
    
    public static void findpairseff(int[] arr, int sum)
    {
        int length = arr.Length;
        
        HashSet<int> hset = new HashSet<int>();
        
        for(int i=0; i<length; i++)
        {
            int z = sum - arr[i];
            
            if(hset.Contains(z))
            {
                Console.Write(arr[i] + "," + z + " ");
            }
            else
            {
                hset.Add(arr[i]);
            }
        }
    }
    
    public static void findpairs(int[] arr, int sum)
    {
        int length = arr.Length;
        
        for(int i=0; i<length; i++)
        {
            for(int j=i+1; j<length; j++)
            {
                if(arr[i] + arr[j] == sum)
                {
                    Console.Write("(" + arr[i] + "," + arr[j] + ")");
                }
            }
        }
    }
    
    public static int fib(int n)
    {
        int[] f = new int[n+2];
        
        f[0] = 0;
        f[1] = 1;
        
        for(int i=2; i<=n; i++)
        {
            f[i] = f[i-1] + f[i-2];
        }
        
        return f[n];
    }
    
    public static int[] fibo(int n)
    {
        int[] f = new int[n+2];
        
        f[0] = 0;
        f[1] = 1;
        
        for(int i=2; i<=n; i++)
        {
            f[i] = f[i-1] + f[i-2];
        }
        return f;
    }
    
    public static void findtripleteff(int[] arr, int sum)
    {
        int length = arr.Length;
        
        for(int i=0; i<length; i++)
        {
            HashSet<int> missing_elem_col = new HashSet<int>();
            
            for(int j=i+1; j<length; j++)
            {
                int missing_elem = sum -(arr[i] + arr[j]);
                
                if(missing_elem_col.Contains(missing_elem))
                {
                    Console.WriteLine(arr[i] + " " + arr[j] + " " + missing_elem);
                }
                else
                {
                    missing_elem_col.Add(arr[j]);
                }
            }
        }
    }
    
    public static void findtriplet(int[] arr, int val)
    {
        int length = arr.Length;
        
        for(int i=0; i<length; i++)
        {
            for(int j=i+1; j<length; j++)
            {
                for(int k = j+1; k<length; k++)
                {
                    if(arr[i] + arr[j] + arr[k] == val)
                    {
                        Console.WriteLine(arr[i] + " " + arr[j] + " " + arr[k]);
                    }
                }
            }
        }
    }
}
