/*
	Merge Sort: 0(n log(n)) Runtime
				O(n) Space Complexity
	
	Merge sort divides the array in half, sorts each of those halves, and then merges them back together. 
	Each of those halves has the same sorting algorithm applied to it. Eventually, you are merging just two single element arrays. 
 */

void Main()
{
	int[] array = new int[] {1, 2, 7, 3, 1, 94, 57, 22, 1, 7, 0, -3};
	int[] sorted = MergeSort(array);
	string list = String.Join(", ", sorted);
	
	Console.WriteLine(list);
}

public int[] MergeSort(int[] array)
{
	int[] helper = new int[array.Length];
	return MergeSort(array, helper, 0, (array.Length - 1));
}

public int[] MergeSort(int[] array, int[] helper, int low, int high)
{
	if (low < high)
	{
		int middle = (high + low) / 2;
		MergeSort(array, helper, low, middle);
		MergeSort(array, helper, middle + 1, high);
		array = Merge(array, helper, low, middle, high);
	}
	
	return array;
}

public int[] Merge(int[] array, int[] helper, int low, int middle, int high) 
{
	// Copy both halves into the helper array
	for (int i = low; i <= high; i++) 
	{
		helper[i] = array[i];
	}
	
	int helperLeft = low;
	int helperRight = middle + 1;
	int current = low;
	
	// Iterate through helper array. Compare the left and right half, copying back the smaller element from the two halves into the original array.
	while (helperLeft <= middle && helperRight <= high) 
	{
		if (helper[helperLeft] <= helper[helperRight]) 
		{
			array[current] = helper[helperLeft];
			helperLeft ++;
		}
		else 
		{
			array[current] = helper[helperRight];
			helperRight ++;
		}
		current ++;
	}
	
	// Copy the rest of the left side of the array into the target array
	int remaining = middle - helperLeft;
	for (int i = 0; i <= remaining; i++)
	{
		array[current + i] = helper[helperLeft + i];
	}
	
	return array;
}