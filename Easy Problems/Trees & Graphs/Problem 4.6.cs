

// Problem 4.6
// Successor: Write an algorithm to find the "next" node (i.e., in-order successor) of a given node in a binary search tree. 
// You may assume that each node has a link to its parent.


void Main()
{
		BinaryTree tree = new BinaryTree();
        Node<int> root = null;
		Node<int> temp = null;
        
		root = tree.Insert(root, 20);
        root = tree.Insert(root, 8);
        root = tree.Insert(root, 22);
        root = tree.Insert(root, 4);
        root = tree.Insert(root, 12);
        root = tree.Insert(root, 10);
        root = tree.Insert(root, 14);
        temp = root.Left.Right.Right;
		
		Node<int> selected = root.Left.Right;
		Node<int> successor = InOrderSuccessor<int>(selected);
		
		Console.WriteLine(successor);
}

public Node<T> InOrderSuccessor<T>(Node<T> node)
{
	if (node == null) { return null; }
	
	if (node.Right != null)
	{
		return LeftMostNode(node.Right);
	}
	else
	{
		Node<T> n = node;
		Node<T> p = n.Parent;
		
		while (p != null && p.Left != n)
		{
			n = p;
			p = n.Parent;
		}
		
		return p;
	}
}

public Node<T> LeftMostNode<T>(Node<T> node)
{
	if (node == null) { return null; }
	
	while (node.Left != null)
	{
		node = node.Left;
	}
	
	return node;
}


// ---------------------------------------------------------------- //
// 							DEBUGGING								//
// ---------------------------------------------------------------- //

public class Node<T> 
{
    public T Data;
    public Node<T> Left;
	public Node<T> Right;
	public Node<T> Parent;
 
    public Node(T data) 
	{
        this.Data = data;
		this.Left = null;
		this.Right = null;
		this.Parent = null;
    }
}


// Tree from: http://www.geeksforgeeks.org/inorder-successor-in-binary-search-tree/
 
class BinaryTree
{
    public Node<int> Insert(Node<int> node, int data) 
	{
        /* 1. If the tree is empty, return a new, single node */
        if (node == null) 
		{
            return (new Node<int>(data));
        } 
		else 
		{
            Node<int> temp = null;
             
            /* 2. Otherwise, recurse down the tree */
            if (data <= node.Data) {
                temp = Insert(node.Left, data);
                node.Left = temp;
                temp.Parent = node;
            } 
			else 
			{
                temp = Insert(node.Right, data);
                node.Right = temp;
                temp.Parent = node;
            }
 
            /* return the (unchanged) node pointer */
            return node;
        }
    }
}