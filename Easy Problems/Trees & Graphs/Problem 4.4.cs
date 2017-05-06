

// Problem 4.4
// Check Balanced: Implement a function to check if a binary tree is balanced. For the purposes of this question, a balanced tree is defined 
// to be a tree such that the heights of the two subtrees of any node never differ by more than one.

void Main()
{
	
}

public class Node<T>
{
	public T data;
	public Node<T> left;
	public Node<T> right;
}

// Approach 1 - Brute Force Recursion
public bool IsTreeBalanced<T>(Node<T> root) 
{
	if (root == null) { return true; }
	
	int heightDiff = GetHeight(root.left) - GetHeight(root.right);
	if (Math.Abs(heightDiff) > 1) 
	{ 
		return false; 
	}
	else
	{
		return IsTreeBalanced(root.left) && IsTreeBalanced(root.right);
	}
}

public int GetHeight<T>(Node<T> node)
{
	if (node == null) { return -1; }
	
	return
		Math.Max(GetHeight(node.left), GetHeight(node.right)) + 1;
}

// Approach 2 - Check Height Difference when Calculating Height
public bool IsTreeBalanced2<T>(Node<T> root)
{
	if (CheckHeight(root) == Int32.MinValue) { return false; }
	
	else 
	{
		return true;
	}
}

public int CheckHeight<T>(Node<T> node)
{
	if (node == null) { return -1; }
	
	int leftHeight = CheckHeight(node.left);
	if (leftHeight == Int32.MinValue) { return Int32.MinValue; }
	
	int rightHeight = CheckHeight(node.right);
	if (rightHeight == Int32.MinValue) { return Int32.MinValue; }
	
	int heightDiff = leftHeight - rightHeight;
	if (Math.Abs(heightDiff) > 1) { return Int32.MinValue; }
	else
	{
		return Math.Max(leftHeight, rightHeight) + 1;
	}
}