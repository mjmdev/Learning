
void Main()
{
	int[] array = new int[] {-40, -20, -1, 1, 2, 3, 5, 7, 9, 12, 13 };
	int magicIndex = FindMagicIndex(array);
	
	Console.WriteLine(magicIndex);
}


public int FindMagicIndex(int[] array)
{
	if (array.Length < 1) { return -1; }
	return FindMagicIndex(0, array.Length - 1, array);
}

public int FindMagicIndex(int left, int right, int[] array)
{
	if (left > right) { return -1; }

	int mid = (left + right) / 2;
	
	if (array[mid] == mid) { return mid; }
	else if (array[mid] > mid) { return FindMagicIndex(left, mid - 1, array); }
	else { return FindMagicIndex(mid + 1, right, array); }
}

public int FindMagicIndexDuplicates(int[] array, int left, int right)
{
	if (left > right) { return -1; }
	
	int midIndex = (left + right) / 2;
	int midValue = array[midIndex];
	if (midValue == midIndex) { return midValue; }
	
	// Search Left Side
	int leftIndex = Math.Min(midValue, midIndex - 1);
	int leftValue = FindMagicIndexDuplicates(array, left, leftIndex);
	if (left >= 0) { return left; }
	
	
	
	
}