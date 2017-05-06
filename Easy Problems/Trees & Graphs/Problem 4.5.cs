

// Problem 4.5
// Validate BST: Implement a function to check if a binary tree is a binary search tree. 

// NOTE: A binary search tree is a binary tree in which every node fits a specific ordering property: all left descendents <= n < all right descendents.

void Main()
{
	
}

public bool ValidateBST(Node<int> root)
{
	return CheckBST(root, null, null);	
}

public bool CheckBST(Node<int> n, Int32? min, Int32? max)
{
	if (n == null) { return true; }
	
	if ((min != null && n.Data <= min) || (max != null && n.Data > max))
	{
		return false;
	}
	
	if (!CheckBST(n.Left, min, n.Data) || !CheckBST(n.Right, n.Data, max))
	{
		return false;
	}
	
	return true;
}

public class Node<T>
{
	public T Data;
	public Node<T> Left;
	public Node<T> Right;
	
	public Node(T data)
	{
		this.Data = data;
	}
}