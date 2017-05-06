

// Problem 10.4

void Main()
{
	
}

public int Search(Listy list, int value)
{
	int index = 1;
	while (list.ElementAt(index) != -1 && list.ElementAt(index) < value)
	{
		index *= 2;
	}
	
	return BinarySearch(list, value, index/2, index);
}

public int BinarySearch(Listy list, int value, int low, int high)
{
	int mid;
	
	while (low <= high)
	{
		mid = (low + high) / 2;
		int middle = list.ElementAt(mid);
		if (middle > value || middle == -1)
		{
			high = mid - 1;
		}
		else if (middle < value)
		{
			low = mid + 1;
		}
		else 
		{
			return mid;
		}
	}
	return -1;
}


public class Listy
{
	private int[] List;
	
	public Listy(int[] list)
	{
		this.List = list;
	}
	
	public int ElementAt(int index)
	{
		int element = List[index] != 0
			? List[index]
			: -1;

		return element;
	}
}