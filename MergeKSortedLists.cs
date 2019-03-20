using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int k = 3; // Number of linked lists  
        int n = 4; // Number of elements in each list  
    
        // an array of pointers storing the head nodes  
        // of the linked lists  
        Node[]  arr =new Node[k];  
    
        arr[0] = new Node(1);  
        arr[0].Next = new Node(3);  
        arr[0].Next.Next = new Node(5);  
        arr[0].Next.Next.Next = new Node(7);  
    
        arr[1] = new Node(2);  
        arr[1].Next = new Node(4);  
        arr[1].Next.Next = new Node(6);  
        arr[1].Next.Next.Next = new Node(8);  
    
        arr[2] = new Node(0);  
        arr[2].Next = new Node(9);  
        arr[2].Next.Next = new Node(10);  
        arr[2].Next.Next.Next = new Node(11);  
        
        MergeSort m = new MergeSort();
    
        // Merge all lists  O(nklogk)
        Node head = m.mergeKLists(arr, k - 1);
    }
}

public class Node
{
    public int Data {get; set;}
    
    public Node Next {get; set;}
    
    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class MergeSort
{
    public Node mergeKLists(Node[] arr, int last)
    {
        
        while(last != 0)
        {
            int i=0;
            int j= last;
            
            while(i < j)
            {
                arr[i] = SortedMerge(arr[i], arr[j]);
                
                i++;
                j--;
                
                if(i >= j)
                {
                    last = j;
                }
            }
        }
        
        return arr[0];
    }
    
    public Node SortedMerge(Node a, Node b)
    {
        Node result = null;
        
        if(a == null)
            return b;
        
        if(b == null)
            return a;
        
        if(a.Data <= b.Data)
        {
            result = a;
            
            result.Next = SortedMerge(a.Next, b);
        }
        else
        {
            result = b;
            result.Next = SortedMerge(a, b.Next);
        }
        
        return result;
    }
}
