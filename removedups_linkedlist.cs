using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        
    }
    
    public static void kthSmallest(int[] arr, int k)
    {
        int length = arr.Length;
        
        if(k >= length)
        {
            Console.Write("k is outside the bounds for the array");
            return;       
        }
        
        Array.Sort(arr);
        
        Array.Reverse(arr);
        
        int kthelement = arr[k];
        
        Console.Write(arr[k]);
    }
}

public class Node
{
    public int Data {get; set;}
    
    public Node Next {get; set;}
    
    public Node(int newdata)
    {
        Data = newdata;
        Next = null;
    }
}

public class LinkedList
{
    public Node Head {get; set;}
    
    public LinkedList()
    {
        Head = null;
    }
    
    public void Reverse()
    {
        if(Head == null)
            return;
        
        Node current = Head;
        Node prev = null;
        Node next = null;
        
        while(current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
        Head = prev;
    }
    
    public void RemoveDuplicatesUnsorted()
    {
        Node current = Head;
        
        Node prev = null;
        
        HashSet<int> map = new HashSet<int>();
        
        while(current != null)
        {
            int val = current.Data;
            
            if(map.Contains(val))
            {
                prev.Next = current.Next;
            }
            else
            {
                map.Add(val);
                prev = current;
            }
            current = current.Next;
        }
    }
    
    public void RemoveDuplicatesSorted()
    {
        if(Head == null)
            return;
        
        if(Head.Next == null)
            return;
        
        Node current = Head;
        
        Node next = null;
        
        while(current.Next != null)
        {
            if(current.Data == current.Next.Data) //check for duplicates
            {
                next = current.Next.Next; //get a ref to next node
                current.Next = null; //unlink, remove
                current.Next = next; //link to next node
            }
            else //if not, keep moving forward
            {
                current = current.Next;   
            }
        }
    }
}
