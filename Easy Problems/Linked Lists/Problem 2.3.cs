// Problem 2.3
// Delete Middle Node: Implement an algorithm to delete a node in the middle (i.e., any node but the first and last node, not necessarily the exact middle) 
// of a singly linked list, given only access to that node. 

public void DeleteNode<T>(LinkedListNode<T> node)
{
	if (node == null || node.Next == null) { return; }
	
	// 1. Copy data from next node.
	LinkedListNode<T> tempNode = node.Next;
	node.Data = tempNode.Data;
	
	// 2. Delete next node.
	node.Next = tempNode.Next;
}