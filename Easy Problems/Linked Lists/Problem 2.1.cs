/*
	Remove Dups: Write code to remove duplicates from an unsorted linked list. 
				 FOLLOW UP - How would you solve this problem if a temporary buffer is not allowed? 
*/

// Approach 1 - Dictionary/Hashtable
public void RemoveDuplicates<T>(LinkedListNode<T> root)
{
	HashSet<T> hash = new HashSet<T>();
	hash.Add(root.Data);
	
	while (root.Next != null)
	{
		if (hash.Contains(root.Next.Data))
		{
			root.Next = root.Next.Next;
		}
		else
		{
			hash.Add(root.Next.Data);
		}
		
		root = root.Next;
	}
}

// Approach 2 - No Buffer
public void RemoveDups<T>(LinkedListNode<T> root)
{
	LinkedListNode<T> current = root;

	while (current != null)
	{
		LinkedListNode<T> runner = current;
		while (runner.Next != null)
		{
			if (runner.Next.Data.Equals(current.Data))
			{
				runner.Next = runner.Next.Next;
			}
			else 
			{
				runner = runner.Next;
			}
		}
		current = current.Next;
	}
}