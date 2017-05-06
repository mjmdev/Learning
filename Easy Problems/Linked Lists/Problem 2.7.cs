// Problem 2.7
// Intersection: Given two (singly) linked lists, determine if the two lists intersect. Return the
// intersecting node. Note that the intersection is defined based on reference, not value. That is, if the
// kth node of the first linked list is the exact same node (by reference) as the jth node of the second
// linked list, then they are intersecting. 7

public LinkedListNode<T> ListIntersection<T>(LinkedListNode<T> listA, LinkedListNode<T> listB)
{
	if (listA == null || listB == null) { return null; }
	
	LinkedListNode<T> listAEnd = null;
	LinkedListNode<T> listBEnd = null;
	
	int listALength = 1;
	int listBLength = 1;
	
	while (listA.Next != null)
	{
		listAEnd = listA.Next;
		listALength++;
	}
	
	while (listB.Next != null)
	{
		listBEnd = listB.Next;
		listBLength++;
	}
	
	if (listAEnd != listBEnd) { return null; }
	
	int diff = Math.Abs(listALength - listBLength);
	if (listALength > listBLength)
	{
		listA = TrimLists(listA, diff);
	}
	else if (listALength < listBLength)
	{
		listB = TrimLists(listB, diff);
	}
	
	while (listA != listB)
	{
		listA = listA.Next;
		listB = listB.Next;
	}
	
	return listA;
}

public LinkedListNode<T> TrimLists<T>(LinkedListNode<T> list, int difference)
{
	while (difference > 0)
	{
		list = list.Next;
		difference--;
	}
	
	return list;
}