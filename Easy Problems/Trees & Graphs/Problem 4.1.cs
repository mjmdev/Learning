// Problem 4.1
// Route Between Nodes: Given a directed graph, design an algorithm to find out whether there is a route between two nodes. 

void Main()
{
	Graph<int> graph = new Graph<int>();
        graph.NodeSet[1] = new List<int> {2, 3, 4};
        graph.NodeSet[2] = new List<int> {1, 3, 4};
        graph.NodeSet[3] = new List<int> {1, 2, 4};
        graph.NodeSet[4] = new List<int> {1, 2, 3, 5};
        graph.NodeSet[5] = new List<int> {4, 6};
        graph.NodeSet[6] = new List<int> {5};
}



public class Graph<T>
{
	public Dictionary<int, List<T>> NodeSet;
}

public class Node<T>
{
	public int id;
	public T data;
	public List<int> neighbors;
	public bool visited;
}

public bool BFS<T>(Node<T> root, Node<T> endNode)
{
	Queue<Node<T>> q = new Queue<Node<T>>();
	root.visited = true;
	q.Enqueue(root);
	
	while (q.Any())
	{
		Node<T> r = q.Dequeue();
		if (CheckNode(r, endNode)) { return true; };
		
		foreach(Node<T> n in r.neighbors) 
		{
			if (n.visited == false)
			{
				n.visited = true;
				q.Enqueue(n);
			}
		}
	}
	return false;
}

public bool CheckNode<T>(Node<T> currentNode, Node<T> endNode)
{
	if (currentNode == endNode) { return true; }
	
	else { return false; }
}