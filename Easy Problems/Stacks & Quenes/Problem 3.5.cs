

// Problem 3.5
// Sort Stack: Write a program to sort a stack such that the smallest items are on the top. You can use an additional temporary stack, 
// but you may not copy the elements into any other data structure (such as an array). The stack supports the following operations: push, pop, peek, and is Empty. 

void Main()
{
	Stack<int> s = new Stack<int>();
	int[] ints = new int[] {4, 5, 8, 1, 4, 3, 1, 12, 8, 0, 9, 10, 2};
	
	foreach (int i in ints) 
	{
		s.Push(i);
	}
	
	Stack<int> sortedStack = SortStack(s);
	
	StringBuilder sb = new StringBuilder();
	foreach (int i in sortedStack)
	{
		sb.Append(String.Format("{0}, ", i.ToString()));
	}
	
	Console.WriteLine(sb.ToString());
}

public Stack<int> SortStack(Stack<int> stack)
{
	Stack<int> tempStack = new Stack<int>();
	
	while (stack.Count > 0)
	{
		CompareAndSwap(stack, tempStack, stack.Pop());
	}
	
	return tempStack;
}

public void CompareAndSwap(Stack<int> sourceStack, Stack<int> targetStack, int val) 
{
	if (targetStack.Count == 0) 
	{ 
		targetStack.Push(val); 
	}
	else 
	{
		while (targetStack.Count > 0 && val > targetStack.Peek())
		{
			sourceStack.Push(targetStack.Pop());
		}
		targetStack.Push(val);
	}
}