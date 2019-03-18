using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[10] {10,9,8,7,6,5,4,3,2,1};
        
        MergeSort m = new MergeSort();
        
        m.Sort(arr, 0, arr.Length-1);
        
        for(int i=0; i<arr.Length;i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

public class MergeSort
{
    public void Sort(int[] arr, int left, int right)
    {
        if(left < right)
        {
            
            int middle = (left + right) /2;

            Sort(arr, left, middle);

            Sort(arr, middle +1, right);

            Merge(arr, left, middle, right);
        }
    }
    
    public void Merge(int[] arr, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;
        
        
        int[] L = new int[n1];
        
        int[] R = new int[n2];
        
        for(int m=0; m<n1; ++m)
        {
            L[m] = arr[left + m];
        }
        
        for(int n=0; n<n2; ++n)
        {
            R[n] = arr[middle + 1 + n];
        }
        
        int i=0;
        int j =0;
        int k = left;
        
        while(i < n1 && j < n2)
        {
            if(L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            else
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        
        while(i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }
        
        while(j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }
}
