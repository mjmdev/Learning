

void Main()
{
	
}

// Define other methods and classes here
class Graph<V>
{
	
	private Dictionary<V, List<Edge<V>>> neighbors = new Dictionary<V, List<Edge<V>>>();
	
	private class Edge<V>
	{
		private V vertex;
		private int value;
		
		public Edge(V v, int val)
		{
			vertex = v;
			value = val;
		}
		
		public V GetVertex()
		{
			return this.vertex;
		}
		
		public int GetValue()
		{
			return this.value;
		}
	}
	
	public void AddVertex(V vertex)
	{
	
	}
	
	public void AddVertex(int value)
	{
	
	}
	
	public void AddEdge
}

class Node<T>
{

}


public bool RouteExists<T>(Node<T> node1, Node<T> node2, Graph graph)
{
	
}