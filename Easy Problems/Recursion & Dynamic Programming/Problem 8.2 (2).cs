

void Main()
{
	bool[][] maze = new bool[4][];
	maze[0] = new bool[5] {true, true, true, true, false};
	maze[1] = new bool[5] {true, false, false, true, false};
	maze[2] = new bool[5] {true, false, true, true, false};
	maze[3] = new bool[5] {true, false, true, true, true};
	
	List<Point> route = GetRoute(maze);
	
	if (route == null) { Console.WriteLine("No Path!"); }
	
	else 
	{
		foreach(Point point in route)
		{
			string coordinates = String.Format("{0},{1}", point.r, point.c);
			Console.WriteLine(coordinates);
		}
	}

	// Visual Map Representation
	for (int i = 0; i < maze.Length; i++)
	{
		StringBuilder line = new StringBuilder();
		bool[] innerArray = maze[i];
		foreach (bool val in innerArray)
		{
			if (!val)
			line.Append("X ");
			
			else
			line.Append("-  ");
		}
		
		Console.WriteLine(line.ToString());
	}
}

public class Point
{
	public Point(int x, int y)
	{
		this.r = x;
		this.c = y;
	}

	public int r { get; set; }
	public int c { get; set; }
}

public List<Point> GetRoute(bool[][] maze)
{
	if (maze == null || maze.Length == 0) { return null; }
	
	List<Point> path = new List<Point>();
	HashSet<Point> failedPoints = new HashSet<Point>();
	
	if (FindPath(maze.Length - 1, maze[0].Length - 1, maze, path, failedPoints))
	{
		return path;
	}
	return null;
}

public bool FindPath(int row, int col, bool[][] maze, List<Point> path, HashSet<Point> failedPoints)
{
	if (row < 0) { return false; }
	if (col < 0) { return false; }
	if (!maze[row][col]) { return false; }
	
	Point p = new Point(col, row);
	
	if (failedPoints.Contains(p)) { return false; }
	
	bool isOrigin = (row == 0 && col == 0);
	
	if (isOrigin || FindPath(row - 1, col, maze, path, failedPoints) || FindPath(row, col - 1, maze, path, failedPoints))
	{
		path.Add(p);
		return true;
	}

	failedPoints.Add(p);
	return false;
}