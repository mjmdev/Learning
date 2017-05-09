/*
	Problem 4.5: Validate BST: Implement a function to check if a binary tree is a binary search tree.
				 NOTE: A binary search tree is a binary tree in which every node fits a specific ordering property: 
				 all Left Descendents <= n < all Right Descendents.
*/

public void Main()
{
	
}

public bool ValidateBST(Node<int> root)
{
	return CheckBST(root, null, null);	
}

public bool CheckBST(Node<int> node, Int32? min, Int32? max)
{
	if (node == null) { return true; }
	
	if ((min != null && node.Data <= min) || (max != null && node.Data > max))
	{
		return false;
	}
	
	if (!CheckBST(node.Left, min, node.Data) || !CheckBST(node.Right, node.Data, max))
	{
		return false;
	}
	
	return true;
}

public class Node<T>
{
	public T Data { get; set; }
	public Node<T> Left { get; set; }
	public Node<T> Right { get; set; }
	
	public Node(T data)
	{
		this.Data = data;
	}
}