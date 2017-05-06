
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
 	List<Point> route = new List<Point>();
	bool isRoute = FindRoute(maze.Length-1, maze[0].Length-1, maze, route);
	
	if (isRoute) { return route; }
	
	return null;
 }
 
 public bool FindRoute(int row, int col, bool[][] maze, List<Point> path)
 {
 	if (col < 0) { return false; }
	if (row < 0) { return false; }
	if (!maze[row][col]) { return false; }
	
	bool isOrigin = (row == 0 && col == 0);
	
	if (isOrigin || FindRoute(row-1, col, maze, path) || FindRoute(row, col-1, maze, path))
	{
		Point p = new Point(row, col);
		path.Add(p);
		return true;
	}
	return false;
 }
 