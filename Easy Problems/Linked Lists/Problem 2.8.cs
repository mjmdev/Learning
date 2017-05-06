// Problem 2.8
//Loop Detection: Given a circular linked list, implement an algorithm that returns the node at the beginning of the loop. 

public LinkedListNode<T> ListHasLoop<T>(LinkedListNode<T> root)
{
	if (root == null) { return null; }

	LinkedListNode<T> slowRunner = root;
	LinkedListNode<T> fastRunner = root;
	
	while (slowRunner != null && fastRunner.Next != null)
	{
		slowRunner = slowRunner.Next;
		fastRunner = fastRunner.Next.Next;
		
		if (slowRunner == fastRunner) { break; }
	}
	
	if (fastRunner == null || fastRunner.Next == null) { return null; }
	
	slowRunner = root;
	while (slowRunner != fastRunner)
	{
		slowRunner = slowRunner.Next;
		fastRunner = fastRunner.Next;
	}
	
	return slowRunner;
}