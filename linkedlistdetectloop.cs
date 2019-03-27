using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        
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
    public Node Root {get; set;}
    
    public LinkedList()
    {
        Root = null;
    }
    
    public void DetectAndRemoveLoop(Node node)
    {
        Node slow_p = node;
        Node fast_p = node;
        
        if(node == null || node.Next == null)
            return;
        
        slow_p = node.Next;
        fast_p = node.Next.Next;
        
        while(fast != null && fast.Next != null)
        {
            if(slow == fast)
            {
                break;
            }
            
            slow_p = slow_p.Next;
            fast_p = fast_p.Next.Next;
        }
        
        
        if(slow_p == fast_p)
        {
            slow_p = node;
            
            while(slow_p.Next != fast_p.Next)
            {
                slow_p = slow_p.Next;
                fast_p = fast_p.Next;
            }
            
            fast_p.Next = null;
        }
    }
    
    public bool DetectLoop(Node node)
    {
        Node slow_p = node;
        Node fast_p = node;
        
        while(slow_p != null && fast_p != null && fast_p.Next != null)
        {
            slow_p = slow_p.Next;
            
            fast_p = fast_p.Next.Next;
            
            if(slow_p == fast_p)
            {
                return true;
            }
        }
        return false;
    }
}
