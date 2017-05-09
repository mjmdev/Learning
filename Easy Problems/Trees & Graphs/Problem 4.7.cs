/*
Problem 4.7: Build Order: You are given a list of projects and a list of dependencies (which is a list of pairs of projects,
			 where the second project is dependent on the first project). All of a project's dependencies must be built before the 
			 project is. Find a build order that will allow the projects to be built. If there is no valid build order, return an error. 

EXAMPLE 	 Input: projects: a, b, c, d, e, f 
					dependencies: (a, d), (f, b), (b, d), (f, a), (d, c) 
			 Output: f, e, a, b, d, c 
 */

public void Main()
{
	String[] projects = new String[] { "a", "b", "c", "d", "e", "f", "g" };
	String[][] c = new String[7][];
	
	c[0] = new String[] {"c", "f"};
	c[1] = new String[] {"b", "f"};
	c[2] = new String[] {"a", "f"};
	c[3] = new String[] {"a", "c"};
	c[4] = new String[] {"a", "b"};
	c[5] = new String[] {"e", "a"};
	c[6] = new String[] {"g", "d"};
	
	var order = FindBuildOrder(projects, c);
	
	StringBuilder sb = new StringBuilder();
	foreach (var project in order)
	{
		sb.Append(String.Format("{0}, ", project.GetName()));
	}
	
	Console.WriteLine(sb.ToString());
}

public Project[] FindBuildOrder(String[] projects, String[][] dependencies)
{
	Graph graph = BuildGraph(projects, dependencies);
	return OrderProjects(graph.GetNodes());
}

public Graph BuildGraph(String[] projects, String[][] dependencies)
{
	Graph g = new Graph();
	
	foreach (var project in projects)
	{
		var n = g.GetOrCreateNode(project);
	}
	
	foreach (var dependency in dependencies)
	{
		string first = dependency[0];
		string second = dependency[1];
		g.AddEdge(first, second);
	}
	
	return g;
}

public Project[] OrderProjects(List<Project> projects)
{
	Project[] order = new Project[projects.Count];
	
	int endOfList = AddNonDependent(order, projects, 0);
	
	int toBeProcessed = 0;
	while (toBeProcessed < order.Length)
	{
		Project currentProject = order[toBeProcessed];
		
		if (currentProject == null) { return null; }
		
		List<Project> dependents = currentProject.GetDependents();
		foreach (var dependent in dependents)
		{
			dependent.DecrementDepedencies();
		}
	
		endOfList = AddNonDependent(order, dependents, endOfList);
		toBeProcessed++;
	}
	
	return order;
}

public int AddNonDependent(Project[] order, List<Project> projects, int offset)
{
	foreach (var project in projects)
	{
		if (project.GetNumberDependencies() == 0) 
		{ 
			order[offset] = project; 
			offset++;
		}
	}
	return offset;
}

public class Graph
{
	private List<Project> Nodes = new List<Project>();
	private Hashtable Map = new Hashtable();
	
	public Project GetOrCreateNode(string name)
	{
		if (!Map.ContainsKey(name))
		{
			Project node = new Project(name);
			Nodes.Add(node);
			Map.Add(name, node);
		}
		
		return Map[name] as Project;
	}
	
	public void AddEdge(String startNodeName, String endNodeName)
	{
		Project start = GetOrCreateNode(startNodeName);
		Project end = GetOrCreateNode(endNodeName);
		start.AddDependent(end);
	}
	
	public List<Project> GetNodes() { return Nodes; }
}

public class Project
{
	private List<Project> Dependents = new List<Project>();
	private Hashtable Map = new Hashtable();
	
	private String Name;
	private int Dependencies = 0;
	
	
	public void IncrementDepedencies() { Dependencies++; }
	public void DecrementDepedencies() { Dependencies--; }
	
	public Project(String n) { Name = n; }
	
	public void AddDependent(Project node)
	{
		if (!Map.ContainsKey(node.GetName()))
		{
			Dependents.Add(node);
			Map.Add(node.GetName(), node);
			node.IncrementDepedencies();
		}
	}
	
	public string GetName() { return this.Name; }
	public List<Project> GetDependents() { return this.Dependents; }
	public int GetNumberDependencies() { return Dependencies; }
}