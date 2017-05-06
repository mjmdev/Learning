// Problem 2.4

void Main()
{
	LinkedListNode<int> list = new LinkedListNode<int>(3);
	list.AppendToTail(5);
	list.AppendToTail(8);
	list.AppendToTail(5);
	list.AppendToTail(10);
	list.AppendToTail(2);
	list.AppendToTail(1);
	
	var partitionedList = PartitionList(list, 5);
	Console.WriteLine(partitionedList);
}

public LinkedListNode<int> PartitionList(LinkedListNode<int> node, int partitionValue)
{
	if (node == null) { return null; }
	
	LinkedListNode<int> beforeStart = null;
	LinkedListNode<int> beforeEnd = null;
	
	LinkedListNode<int> afterStart = null;
	LinkedListNode<int> afterEnd = null;
	
	while (node != null)
	{
		LinkedListNode<int> next = node.Next;
		node.Next = null;
	
		if (node.Data < partitionValue)
		{
			if (beforeStart == null)
			{
				beforeStart = node;
				beforeEnd = beforeStart;
			}
			else
			{
				beforeEnd.Next = node;
				beforeEnd = node;
			}
		}
		else
		{
			if (afterStart == null)
			{
				afterStart = node;
				afterEnd = afterStart;
			}
			else
			{
				afterEnd.Next = node;
				afterEnd = node;
			}
		}
		
		node = next;
	}
	
	if (beforeStart == null) { return afterStart; }
	
	beforeEnd.Next = afterStart;
	return beforeStart;
}