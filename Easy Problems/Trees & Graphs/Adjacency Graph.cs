

void Main()
{
	
}

// Graphs - Adjacency List

class Graph<T>
{
	int numVertices;
	Dictionary<int, List<Node<T>>> adjList;
	
	Graph(int numVertices)
	{
		this.numVertices = numVertices;
		adjList = new Dictionary<int, List<Node<T>>>(numVertices);
		
		for (int i = 0; i < numVertices; i++)
		{
			adjList.Add(i, new List<Node<T>>());
		}
	}
	
	public void AddEdge(int source, Node<T> destination)
	{
		List<Node<T>> sourceNeighbors = this.adjList[source];
		sourceNeighbors.Add(destination);
	}
}

class Node<T>
{
	T data;
}


