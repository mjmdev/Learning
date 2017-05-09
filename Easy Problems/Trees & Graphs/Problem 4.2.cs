/*
	Problem 4.2: Minimal Tree: Given a sorted (increasing order) array with unique integer elements, write an algorithm to 
				 create a binary search tree with minimal height. 
*/

public void Main()
{
	int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	Node tree = CreateBST(array);
	
	Console.WriteLine(tree);
}

public class Node
{
	public int value { get; set; }
	public Node left { get; set; }
	public Node right { get; set; }
	
	public Node(int value)
	{
		this.value = value;
	}
}

public Node CreateBST(int[] array)
{
	return CreateBST(array, 0, array.Length - 1);
}

public Node CreateBST(int[] array, int left, int right)
{
	if (left > right) { return null; }
	
	int midIndex = (left + right) / 2;
	
	Node n = new Node(array[midIndex])
	{
		left = CreateBST(array, left, midIndex - 1),
		right = CreateBST(array, midIndex + 1, right)
	};
	
	return n;
}