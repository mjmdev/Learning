// Linked List: Access O(n)
// 				Search O(n)
// 				Insert O(1)
// 				Delete O(1)

public class LinkedListNode
{
	public LinkedListNode next, prev, last;
	public int data;
	
	public LinkedListNode() { }
	
	public LinkedListNode(int d) 
	{
		data = d;
	}
	
	public void SetNext(LinkedListNode n)
	{
		next = n;
		if (this == last) 
		{ 
			last = n; 
		}
		if (n != null && n.prev != this)
		{
			n.SetPrevious(this);
		}
	}
	
	public void SetPrevious(LinkedListNode n)
	{
		prev = n;
		if (n != null && n.next != this)
		{
			n.SetNext(this);
		}
	}
}