/*
	Check Subtree: 	Tl and T2 are two very large binary trees, with Tl much bigger than T2. Create an algorithm to determine if
					T2 is a subtree of Tl. A tree T2 is a subtree of Tl if there exists a node n in Tl such that the subtree of n 
					is identical to T2. That is, if you cut off the tree at node n, the two trees would be identical. 
 */

public void Main()
{
	Node<int> tree = new Node<int>(1);
	
	tree.Left = new Node<int>(1);
    tree.Left.Left = new Node<int>(2);
    tree.Left.Right = new Node<int>(3);
    tree.Left.Left.Left = new Node<int>(4);
    tree.Left.Left.Right = new Node<int>(5);
  
    tree.Right = new Node<int>(1);
    tree.Right.Left = new Node<int>(2);
    tree.Right.Right = new Node<int>(3);
    tree.Right.Left.Left = new Node<int>(4);
    tree.Right.Left.Right = new Node<int>(5);

	Node<int> smallTree = new Node<int>(2);
	smallTree.Left = new Node<int>(4);
	smallTree.Right = new Node<int>(5);
	
	bool isSubTree = IsSubTree(tree, smallTree);
	Console.WriteLine(isSubTree);
}

public bool IsSubTree(Node<int> primaryTreeRoot, Node<int> smallerTreeRoot)
{
	if (smallerTreeRoot == null) { return true; } // Empty tree is always a subset of a bigger tree
	if (primaryTreeRoot == null) { return false; }
	
	if (AreIdenticalTrees(primaryTreeRoot, smallerTreeRoot)) 
	{
		return true;
	}
	
	return IsSubTree(primaryTreeRoot.Left, smallerTreeRoot) || IsSubTree(primaryTreeRoot.Right, smallerTreeRoot);
}

// Determine if two trees are identical
public bool AreIdenticalTrees(Node<int> node1, Node<int> node2)
{
	if (node1 == null && node2 == null) { return true; }
	
	if (node1 != null && node2 != null)
	{
		return (node1.Data == node2.Data &&
				AreIdenticalTrees(node1.Left, node2.Left) &&
				AreIdenticalTrees(node1.Right, node2.Right));
	}
	
	return false;
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
