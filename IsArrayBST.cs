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
    
    public Node Left {get; set;}
    
    public Node Right {get; set;}
    
    public Node(int newdata)
    {
        Data = newdata;
        
        Left = Right = null;
    }
}

public class BinaryTree
{
    public Node Root {get; set;}
    
    public BinaryTree()
    {
        Root = null;
    }
    
    public bool IsBST()
    {
        return IsBSTUtil(Root, Int32.MinValue, Int32.MaxValue);
    }
    
    private bool IsBSTUtil(Node node, int min, int max)
    {
        if(node == null)
            return true;
        
        if((node.Data < min) || (node.Data > max))
        {
            return false;
        }
        
        return (IsBSTUtil(node, min, node.Data -1) && IsBSTUtil(node.Right, node.Data +1, max));
    }
}
