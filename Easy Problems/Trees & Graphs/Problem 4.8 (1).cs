

// Problem 4.8
// First Common Ancestor: Design an algorithm and write code to find the first common ancestor of two nodes in a binary tree. Avoid storing additional 
// nodes in a data structure. NOTE: This is not necessarily a binary search tree. 

void Main()
{
	
}

// Define other methods and classes here

public Node<T> FindFirstCommonAncestor<T>(Node<T> node1, Node<T> node2)
{
	int delta = FindDepth(node1) - FindDepth(node2);
	Node<T> first = delta > 0 ? node1 : node2;
	Node<T> second = delta > 0 ? node2 : node1;
	
	second = GoUpBy(delta, second);
	
	while ((first != null) && (second != null) && (first != second))
	{
		first = first.parent;
		second = second.parent;
	}
	
	return (first == null || second == null) 
		? null 
		: first;
}

public int FindDepth<T>(Node<T> node)
{
	int depth = 0;
	while (node.parent != null)
	{
		node = node.parent;
		depth++;
	}
	
	return depth;
}



public Node<T> GoUpBy<T>(int delta, Node<T> node)
{
	while (delta > 0 && node != null)
	{
		node = node.parent;
		delta--;
	}
	
	return node;
}

public class Node<T>
{
	public T data;
	public Node<T> parent;
	public List<Node<T>> children;
}