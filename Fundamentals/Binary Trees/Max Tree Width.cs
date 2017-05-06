// Maximum width tree

void Main()
{
	        /*
        Constructed binary tree is:
              1
            /  \
           2    3
         /  \    \
        4   5     8 
                 /  \
                6   7
         */
	Node<int> tree = new Node<int>(1);
    tree.Left = new Node<int>(2);
    tree.Right = new Node<int>(3);
    tree.Left.Left = new Node<int>(4);
    tree.Left.Right = new Node<int>(5);
    tree.Right.Right = new Node<int>(8);
    tree.Right.Right.Left = new Node<int>(6);
    tree.Right.Right.Right = new Node<int>(7);
	
	int maxWidth = FindMaxTreeWidth(tree);
	Console.WriteLine(maxWidth);
}

public int FindMaxTreeWidth<T>(Node<T> root)
{
	if (root == null) {return 0; }
		
	int maxWidth = 0;
	
	Queue<Node<T>> q = new Queue<Node<T>>();
	q.Enqueue(root);
	
	while (q.Any())
	{
		int levelWidth = q.Count;
		maxWidth = Math.Max(maxWidth, levelWidth);
		
		for (int i = 0; i < levelWidth; i++)
		{
			Node<T> n = q.Dequeue();
			if (n.Left != null) { q.Enqueue(n.Left); }
			if (n.Right != null) { q.Enqueue(n.Right); }
		}
	}
	
	return maxWidth;
}