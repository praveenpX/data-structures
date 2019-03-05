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
    
    public int Height(Nod node)
    {
        if(node == null)
            return 0;
        
        int ldepth = Height(node.Left);
        
        int rdepth = Height(node.Right);
        
        if(ldepth > rdepth)
        {
            return ldepth + 1;
        }
        else
        {
            return rdepth + 1;
        }
    }
}
