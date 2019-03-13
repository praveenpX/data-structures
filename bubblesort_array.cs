using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[4]{40,30,20,10};
        
        //SelectionSort1(arr);
        
        BubbleSort(arr);
        
        for(int i=0; i<arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
    
    //big O(n^2), best case O(n)--> array is already sorted
    public static void BubbleSortEff(int[] arr)
    {
        int length = arr.Length;
        
        for(int i=0; i< length; i++)
        {
            bool swapped = false;
            
            for(int j = 0; j <length -i-1; j++)
            {
                if(arr[j] > arr[j+1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] =temp;
                    swapped = true;
                }
            }
            
            if(swapped == false)
                break;
        }
    }
    
    //big O(n^2)
    public static void BubbleSort(int[] arr)
    {
        int length = arr.Length;
        
        for(int i=0; i< length; i++)
        {
            for(int j=0; j < length-1-i; j++)
            {
                if(arr[j] > arr[j+1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j +1] = temp;
                }
            }
        }
    }
    
    //big O(n^2), on average it's O(n)
    public static void SelectionSort(int[] arr)
    {
        int length = arr.Length;
        
        int min_idx = 0;
        
        for(int i=0; i<length -1; i++)
        {
            min_idx = i;
            
            for(int j = i+1; j<length; j++)
            {
                if(arr[j] < arr[min_idx])
                {
                    min_idx = j;
                }
            }
            //swap
            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }
}
