

// Binary Search -  look for an element x in a sorted array by first comparing x to the midpoint of the array. If x is less than the midpoint, 
// then we search the left half of the array. If x is greater than the midpoint, then we search the right half of the array. We then repeat this process

void Main()
{
	
}

int binarySearch(int[] a, int x)
{
	int low = 0;
	int high = a.Length - 1;
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

// Recursive
int binarySearchRecursive(int[] a, int x, int low, int high)
{
	if (low > high) { return -1; } // Error
	
	int mid = (low + high) / 2;
	if (a[mid] < x)
	{
		return binarySearchRecursive(a, x, mid + 1, high);
	}
	else if (a[mid] > mid)
	{
		return binarySearchRecursive(a, x, low, mid - 1);
	}
	else
	{
		return mid;
	}
}