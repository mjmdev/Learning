

// Problem 4.12
// Paths with Sum: You are given a binary tree in which each node contains an integer value (which might be positive or negative). 
// Design an algorithm to count the number of paths that sum to a given value. The path does not need to start or end at the root or a leaf, 
// but it must go downwards (traveling only from parent nodes to child nodes).

void Main()
{
	
}

public int FindSums(Node<int> root, int targetSum)
{
	if (root == null) { return 0; }
	
	int pathsFromRoot = CountPathsFromNode(root, targetSum, 0);
	
	int leftPaths = FindSums(root.Left, targetSum);
	int rightPaths = FindSums(root.Right, targetSum);
	
	return pathsFromRoot + leftPaths + rightPaths;
}

public int CountPathsFromNode(Node<int> root, int targetSum, int currentSum)
{
	if (root == null) { return 0; }
	
	currentSum += root.Data;
	
	int totalPaths = 0;
	if (currentSum == targetSum)
	{
		totalPaths++;
	}
	
	totalPaths += CountPathsFromNode(root.Left, targetSum, currentSum);
	totalPaths += CountPathsFromNode(root.Right, targetSum, currentSum);
	
	return totalPaths;
}

