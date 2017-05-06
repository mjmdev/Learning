

// Quick Sort:  pick a random element and partition the array, such that all numbers that are less than the partitioning 
// element come before all elements that are greater than it. If we repeatedly partition the array (and its sub-arrays) around an element, 
// the array will eventually become sorted. 

// Runtime: O(n log(n)) average, O(n^2) worst case. Memory: 0(log(n)). 

void Main()
{
	int[] array = new int[] {1, 2, 7, 3, 1, 94, 57, 22, 1, 7, 0, -3};
	int[] sorted = QuickSort(array);
	string list = String.Join(", ", sorted);
	
	Console.WriteLine(list);
}

public int[] QuickSort(int[] array) 
{
	QuickSort(array, 0, array.Length - 1);
	return array;
}


public void QuickSort(int[] array, int left, int right)
{
	int index = Partition(array, left, right);
	if (left < index -1)
	{
		QuickSort(array, left, index - 1);
	}
	if (index < right)
	{
		QuickSort(array, index, right);
	}
}

public int Partition(int[] array, int left, int right) 
{
	int middle = (left + right) / 2;
	int pivot = array[middle];
	
	while (left <= right) 
	{
		while (array[left] < pivot)  { left ++; }
		while (array[right] > pivot) { right --; }
		
		if (left <= right) 
		{
			Swap(array, left, right);
			left ++;
			right --;
		}
	}
	
	return left;
}


public void Swap(int[] array, int index1, int index2)
{
	int val1 = array[index1];
	array[index1] = array[index2];
	array[index2] = val1;
}