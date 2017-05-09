/* 
	Problem 4.3: List of Depths: Given a binary tree, design an algorithm which creates a linked list of all the nodes at each depth 
				 (e.g., if you have a tree with depth D, you'll have D linked lists). 
*/

public void Main()
{
	int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	Node tree = CreateBST(array);
	
	List<List<Node>> nodeList1 = NodeListBFS(tree);
	WriteListToConsole(nodeList1);
	
	Console.WriteLine(" ");
	
	List<List<Node>> nodeList2 = BuildList(tree);
	WriteListToConsole(nodeList2);
}

public class Node
{
	public int value { get; set; }
	public Node left { get; set; }
	public Node right { get; set; }
	
	public Node (int value)
	{
		this.value = value;
	}
}


// Approach 1 - Modified BFS
public List<List<Node>> NodeListBFS(Node root)
{
	var nodeList = new List<List<Node>>();
	var levelList = new List<Node>();

	if (root != null)
	{
		levelList.Add(root);
	}
	
	while (levelList.Count > 0)
	{
		nodeList.Add(levelList);
		List<Node> parents = levelList;
		levelList = new List<Node>();
		
		foreach (Node parent in parents)
		{
			if (parent.left != null) 
			{
				levelList.Add(parent.left);
			}
			
			if (parent.right != null)
			{
				levelList.Add(parent.right);
			}
		}
	}
	return nodeList;
}


// Approach 2 - Pre-Order Transversal
public List<List<Node>> BuildList(Node root)
{
	var lists = new List<List<Node>>();
	BuildList(root, lists, 0);
	
	return lists;
}

public void BuildList(Node root, List<List<Node>> lists, int level)
{
	if (root == null) { return; }
	
	List<Node> list = null;
	
	if (lists.Count == level) // Case when level not contained in List
	{
		list = new List<Node>();
		lists.Add(list);
	}
	else
	{
		list = GetListByLevel(lists, level);
	}
	
	list.Add(root);
	BuildList(root.left, lists, level + 1);
	BuildList(root.right, lists, level + 1);
}

public List<Node> GetListByLevel(List<List<Node>> lists, int level)
{
	return lists[level];
}


// ---------------------------------------------------------------- //
// 							DEBUGGING								//
// ---------------------------------------------------------------- //

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

private void WriteListToConsole(List<List<Node>> nodeList)
{
	foreach (List<Node> list in nodeList)
	{
		StringBuilder sb = new StringBuilder();
		
		foreach(Node node in list)
		{
			sb.Append(String.Format("{0}, ", node.value.ToString()));
		}
		
		Console.WriteLine(sb.ToString());
	}
}