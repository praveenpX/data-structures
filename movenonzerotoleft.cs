using System;

public class Program
{
	public static void Main()
	{
		LinkedList list = new LinkedList();
		list.Add(85);
		list.Add(15);
		list.Add(4);
		list.Add(20);
		list.PrintList();
		Console.WriteLine();
		list.Reverse();
		list.PrintList();
		int[] arr = new int[8]{4, -1, -2, 0, -3, -2, 0, -7};
		int[] results = movenonzerotoleft(arr);
		for (int i = 0; i < results.Length; i++)
		{
			Console.Write(results[i] + " ");
		}
	}
	
	
    
    public static void moveNonZeroToLeft(int[] arr)
    {
        int length = arr.Length;
        
        int k=0;
        
        for(int i=0; i<length; i++)
        {
            if(arr[i] != 0)
            {
                arr[k] = arr[i];
                k++;
            }
        }
        
        while(k < length)
        {
            arr[k] = 0;
            k++;
        }
        
        for(int j=0; j<length; j++)
        {
            Console.Write(arr[j] + " ");
        }
        
    }

	public static int[] movenonzerotoleft(int[] arr)
	{
		int length = arr.Length;
		int lastIndex = arr.Length - 1;
		for (int i = 0; i < length; i++)
		{
			if (i == lastIndex)
				break;
			if (arr[i] == 0)
			{
				//swap to last index
				int temp = arr[lastIndex];
				arr[lastIndex] = arr[i];
				arr[i] = temp;
				lastIndex--;
			}
		}

		return arr;
	}
}

public class Node
{
	public int Data
	{
		get;
		set;
	}

	public Node Next
	{
		get;
		set;
	}

	public Node(int newData)
	{
		Data = newData;
		Next = null;
	}
}

public class LinkedList
{
	public Node Head
	{
		get;
		set;
	}

	public LinkedList()
	{
		Head = null;
	}

	public void Add(int newData)
	{
		Node newNode = new Node(newData);
		if (Head == null)
		{
			Head = newNode;
		}
		else
		{
			Node temp = Head;
			while (temp != null) //iterate until the last node
			{
				if (temp.Next != null)
				{
					temp = temp.Next;
				}
				else
				{
					temp.Next = newNode;
					break;
				}
			}

			temp.Next = newNode;
		}
	}

	public void PrintList()
	{
		Node temp = Head;
		while (temp != null)
		{
			Console.Write(temp.Data + " ");
			temp = temp.Next;
		}
	}

	public void Reverse()
	{
		Node prev = null;
		Node current = Head;
		Node next = null;
		while (current != null)
		{
			next = current.Next;
			current.Next = prev;
			prev = current;
			current = next;
		}

		Head = prev;
	}
}
