using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        //merge two sorted arrays
        
        int length1 = 4;
        int length2 = 4;
        int length3 = length1 + length2;
        
        int[] arr1 = new int[4]{1,2,3,4};
        int[] arr2 = new int[4]{5,6,7,8};
        
        
        int[] arr3 = new int[length3];
        
        merge(arr1, arr2, arr3);
        
        for(int k=0; k<length3; k++)
        {
            Console.Write(arr3[k] + " ");
        }
        
    }
    
    //big O, O(m + n)
    public static void merge(int[] arr1, int[] arr2, int[] arr3)
    {
        int i=0;
        int j =0;
        int k =0;
        
        int length1 = arr1.Length;
        
        int length2 = arr2.Length;
        
        while(i < length1 && j < length2)
        {
            if(arr1[i] <= arr2[j])
            {
                arr3[k] = arr1[i];
                i++;
                k++;
            }
            else if(arr1[i] > arr2[j])
            {
                arr3[k] = arr2[j];
                j++;
                k++;
            }
        }
        
        while(i < length1)
        {
           arr3[k] = arr1[i];
            k++;
            i++;
        }
        
        while(j < length2)
        {
            arr3[k] = arr2[j];
            k++;
            j++;
        }
    }
}
