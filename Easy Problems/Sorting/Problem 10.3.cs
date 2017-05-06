

// Problem 10.3
// Search in Rotated Array: Given a sorted array of n integers that has been rotated an unknown number of times, write code to find an element in the array. 
// You may assume that the array was originally sorted in increasing order.


void Main()
{
	int[] array1 = new int[] {15, 16, 19, 20, 25, 1, 3, 4, 5, 7, 10, 14};
	int[] array2 = new int[] {10, 15, 20, 0, 5};
	int[] array3 = new int[] {50, 5, 20, 30, 40};
	int[] array4 = new int[] { 2, 2, 2, 3, 4, 2};
	
}


public int Search(int[] array, int x)
{
	int inflect = FindInflection(array);
	
	if (array[inflect] == x) { return inflect; }
	if (array[inflect] < x)  
	{ 
		return BinarySearch(array,  
	}
}

public int FindInflection(int[] a)
{
	for (int i = 0; i < a.Length; i++)
	{
		if (a[i] > a[i + 1]) { return i + 1; }
	}
	
	return 0; // Case when there is no inflecion point - array is ordered
}

public int BinarySearch(int[] a, int x, int low, int high)
{
	int mid;
	
	while (low <= high)
	{
		mid = (low + high) / 2;
		if (a[mid] < x)
		{
			low = mid + 1;
		}
		else if (a[mid] > x)
		{
			high = mid - 1;
		}
		else { return mid; }
	}
	return -1; // Error
}