// Problem 2.2
// Return Kth to Last: Implement an algorithm to find the kth to last element of a singly linked list. 

// Iterative
public LinkedListNode<T> FindKToLastNode<T>(LinkedListNode<T> root, int k)
{
	LinkedListNode<T> current = root;
	LinkedListNode<T> runner = root;
	
	for (int i = 0; i < k; i++)
	{
		if (runner.Next == null) 
		{ 
			return null; 
		}
		
		runner = runner.Next;
	}
	
	while (runner != null)
	{
		current = current.Next;
		runner = runner.Next;
	}
	
	return current;
}

// Recursive
public class Index
{
	public int Value = 0;
}

public LinkedListNode<T> FindKToLast<T>(LinkedListNode<T> root, int k)
{
	Index index = new Index();
	return FindKToLast<T>(root, k, index);
}

public LinkedListNode<T> FindKToLast<T>(LinkedListNode<T> root, int k, Index index)
{
	if (root == null) { return null; }
	
	LinkedListNode<T> node = FindKToLast<T>(root.Next, k, index);
	index.Value = index.Value + 1;
	
	if (index.Value == k)
	{
		return root;
	}
	
	return root;
}