void Main()
{
	BinarySearchTree tree = new BinarySearchTree();
 
        /* Create BST
              50
           /     \
          30      70
         /  \    /  \
       20   40  60   80 */
	   
    tree.Insert(50);
    tree.Insert(30);
    tree.Insert(20);
    tree.Insert(40);
    tree.Insert(70);
    tree.Insert(60);
    tree.Insert(80);
	
	Console.WriteLine("Pre-Order Traversal");
	tree.PreOrderTraversal();
	Console.WriteLine(Environment.NewLine);
	
	Console.WriteLine("In-Order Traversal");
	tree.InOrderTraversal();
	Console.WriteLine(Environment.NewLine);
	
	Console.WriteLine("Post-Order Traversal");
	tree.PostOrderTraversal();
}

class BinarySearchTree
{
	Node<int> root;
	
	public BinarySearchTree()
	{
		root = null;
	}
	
	public Node<int> Search(int n)
	{
		return BSTSearch(root, n);
	}
	
	public void Insert(int key)
	{
		root = Insert(key, root);
	}
	
	public Node<int> BSTSearch(Node<int> root, int key)
	{
		if (root == null || root.Data == key) { return root; }
		
		if (root.Data > key) { return BSTSearch(root.Left, key); }
		
		return BSTSearch(root.Right, key);
	}
	
	private Node<int> Insert(int key, Node<int> root)
	{
		if (root == null) {
			root = new Node<int>(key);
			return root;
		}
		
		if (root.Data > key) {
			root.Left = Insert(key, root.Left);
		}
		
		else if (root.Data < key) {
			root.Right = Insert(key, root.Right);
		}
		
		return root;
	}
	
	public void PreOrderTraversal()
	{
		PreOrderTraversal(root);
	}
	
	public void InOrderTraversal()
	{
		InOrderTraversal(root);
	}
	
	public void PostOrderTraversal()
	{
		PostOrderTraversal(root);
	}
	
	private void PreOrderTraversal(Node<int> node)
	{
		if (node != null)
		{
			Console.WriteLine(node.Data);
			PreOrderTraversal(node.Left);
			PreOrderTraversal(node.Right);
		}
	}
	
	private void InOrderTraversal(Node<int> node)
	{
		if (node != null)
		{
			InOrderTraversal(node.Left);
			Console.WriteLine(node.Data);
			InOrderTraversal(node.Right);
		}
	}
	
	private void PostOrderTraversal(Node<int> node)
	{
		if (node != null)
		{
			PostOrderTraversal(node.Left);
			PostOrderTraversal(node.Right);
			Console.WriteLine(node.Data);
		}
	}
}

public Node<int> BSTSearch(Node<int> root, int key)
{
	if (root == null || root.Data == key) { return root; }
	
	if (root.Data > key) { return BSTSearch(root.Left, key); }
	
	return BSTSearch(root.Right, key);
}

public class Node<T> 
{
	public T Data { get; set; }
	public Node<T> Left { get; set; }
	public Node<T> Right { get; set; }
	
	public Node(T data)
	{
		Data = data;
		Left = null;
		Right = null;
	}
}
