// Binary Tree - Min Height
// https://leetcode.com/problems/minimum-depth-of-binary-tree/#/description

public int FindMinHeight(Node<int> root)
{
	if (root == null) { return 0; }
	int depth = 1;
	
	var q = new Queue<Node<int>>();
	q.Enqueue(root);
	
	while (q.Any())
	{
		int size = q.Count;
		for (int i = 0; i < size; i++)
		{
			Node<int> n = q.Dequeue();
			if (n.Left == null && n.Right == null) { return depth; }
			if (n.Left != null) { q.Enqueue(n.Left); }
			if (n.Right != null) { q.Enqueue(n.Right); }
		}
		depth++;
	}
	
	return depth;
}

public class Node<T>
{
	public T Data { get; set; }
	public Node Left { get; set; }
	public Node Right { get; set; }

	public Node(T data)
	{
		this.Data = data;
	}
}