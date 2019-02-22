//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            int[] A = new int[6] {1, 4, 45, 6, 10, 8}; 
            int n = 16; 
            PrintPairs(A, n); 
        }
        
        public static void PrintPairs(int[] arr, int sum)
        {
            int length = arr.Length;
            
            HashSet<int> list = new HashSet<int>();
            
            for(int i =0; i < length; i++)
            {
                int temp = sum - arr[i];
                
                if(temp >= 0 && list.Contains(temp))
                {
                    Console.WriteLine("(" + arr[i] + "," + temp + "), ");
                }
                list.Add(arr[i]);
            }
        }
        
        public static void PrintPairsNegative(int[] arr, int sum)
        {
            int length = arr.Length;
            
            HashSet<int> list = new HashSet<int>();
            
            for(int i =0; i < length; i++)
            {
                int item = Math.Abs(arr[i]);
                
                int temp = sum - item;
                
                if(temp >= 0 && list.Contains(temp))
                {
                    Console.WriteLine("(" + arr[i] + "," + temp + "), ");
                }
                list.Add(item);
            }
        }
    }
}
