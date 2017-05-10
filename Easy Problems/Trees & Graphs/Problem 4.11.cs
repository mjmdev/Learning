/*
	Random Node:	You are implementing a binary tree class from scratch which, in addition to insert, find, and delete, 
					has a method getRandomNode() which returns a random node from the tree. All nodes should be equally likely 
					to be chosen. Design and implement an algorithm for getRandomNode, and explain how you would implement the rest
					of the methods.

	REFERENCE: http://quiz.geeksforgeeks.org/binary-search-tree-set-2-delete/
 */

public class BinarySearchTree
{
	private Node<int> root;
	
	public void Insert(int data)
	{
		Insert(data, this.root);
	}
	
	private Node<int> Insert(int data, Node<int> root)
	{
		if (root == null)
		{
			root = new Node<int>(data);
			return root;
		}
		
		if (data < root.Data)
		{
			root.Left = Insert(data, root.Left);
		}
		
		else if (data > root.Data)
		{
			root.Right = Insert(data, root.Right);
		}
		
		root.size++;
		
		return root;
	}
	
	public void Delete(int data)
	{
		Delete(data, this.root);
	}
	
	private Node<int> Delete(int data, Node<int> root)
	{
		if (root == null) { return null; }
		
		if (data < root.Data)
		{
			root.Left = Delete(data, root.Left);
		}
		
		else if (data > root.Data)
		{
			root.Right = Delete(data, root.Right);
		}
		
		else
		{
			// CASE: Node is a leaf
			// Remove leaf from tree
			
			// CASE: Node has only one child
			// Copy child to node to be deleted, then remove child
			if (root.Left == null) 
			{ 
				return root.Right; 
			}
			else if (root.Right == null) 
			{
				return root.Left; 
			}
			
			// CASE: Node has two children
			// Find in-order successor of node to be deleted. Copy contents of the in-order successor to the node and delete the inorder successor.
			root.Data = GetInOrderSuccessor(root.Right);
			
			root.Right = Delete(root.Data, root.Right);
		}
		return root;
	}
	
	private int GetInOrderSuccessor(Node<int> node)
	{
		Node<int> minNode = node;
		while (minNode.Left != null)
		{
			minNode = minNode.Left;
		}
		
		return minNode.Data;
	}
	
	public Node<int> Find(int data)
	{
		return Find(data, this.root);
	}
	
	private Node<int> Find(int data, Node<int> root)
	{
		if (root == null || root.Data == data) { return root; }
		
		if (data < root.Data) { Find(data, root.Left); }
		
		return Find(data, root.Right);
	}
	
	public Node<int> GetRandomNode(Node<int> root)
	{
		int leftSize = root.Left == null ? 0 : root.Left.GetSize();
		Random random = new Random();
		
		int index = random.Next(root.GetSize());
		if (index < leftSize)
		{
			return GetRandomNode(root.Left);
		}
		else if (index == leftSize)
		{
			return root;
		}
		else
		{
			return GetRandomNode(root.Right);
		}
	}
}

public class Node<T>
{
	public T Data { get; set; }
	public Node<T> { get; set; }
	public Node<T> { get; set; }
	
	private int Size = 0;
	
	public Node(T data)
	{
		this.Data = data;
		this.Left = null;
		this.Right = null;
		this.Size = 1;
	}
	
	public int GetSize()
	{
		return this.Size;
	}
}