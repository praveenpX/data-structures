using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[10];
        arr[0] = 12; 
        arr[1] = 16; 
        arr[2] = 20; 
        arr[3] = 40; 
        arr[4] = 50; 
        arr[5] = 70; 
        
        //int index = binarySearch(arr, 0, arr.Length, 4);
        
        //Console.Write(index);
        
        insertSorted(arr, 6, 26, 10);
        
        for(int i=0; i<arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
    
    public static bool insertSorted(int[] arr, int index, int key, int capacity)
    {
        if(index >= capacity)
        {
            return false;
        }
        
        int i;
        
        for(i = index -1; i>=0 && arr[i] > key; i--)
        {
            arr[i+1] = arr[i];
        }
        arr[i+1] = key;
        return true;
    }
    
    public static int binarySearch(int[] arr, int low, int high, int key)
    {
        if(high < low)
            return -1;
        
        int mid = (low + high)/2;
        
        if(arr[mid] == key)
        {
            return mid; //position
        }
        if(arr[mid] > key)
        {
            return binarySearch(arr, low, mid-1, key);
        }
        else
        {
            return binarySearch(arr, mid+1, high, key);
        }
    }
    
    public static bool deleteelement(int[] arr, int key)
    {
        int index = binarySearch(arr, 0, arr.Length, key);
        
        if(index == -1)
            return false;
        
        for(int pos=index; pos<arr.Length; pos++)
        {
            arr[pos] = arr[pos+1];
        }
        return true;
    }
}
