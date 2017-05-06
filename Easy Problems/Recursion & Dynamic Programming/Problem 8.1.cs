

void Main()
{
	var steps = 3;
	var paths = CountPathsMemo(steps);
	Console.WriteLine(paths);
}

// Brute Force
public int CountPaths(int steps)
{
	if (steps < 0) { return 0; } // Error
	if (steps == 0) { return 1; }
	
	return CountPaths(steps - 1) + CountPaths(steps - 2) + CountPaths(steps - 3);
}

// Memotized
public int CountPathsMemo(int steps)
{
	int[] memo = new int[steps+1];
	return GetMemo(steps, memo);
}

public int GetMemo(int steps, int[] memo)
{
	if (steps < 0) { return 0; }
	if (steps == 0) { return 1; }
	
	if (memo[steps] == 0)
	{
		memo[steps] = GetMemo(steps - 1, memo) + GetMemo(steps - 2, memo) + GetMemo(steps - 3, memo);
		return memo[steps];
	}
	else
	{
		return memo[steps];
	}
}