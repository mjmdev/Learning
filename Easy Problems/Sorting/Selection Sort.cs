

// Selection Sort: O(n^2) Runtime, O(1) Memory

// Find the smallest element using a linear scan and move it to the front (swapping it with the front element). 
// Then, find the second smallest and move it, again doing a linear scan. Continue doing this until all the elements are in place. 

void Main()
{
	int[] array = new int[] {1, 2, 7, 3, 1, 94, 57, 22, 1, 7, 0, -3};
	int[] sorted = SelectionSort(array);
	string list = String.Join(", ", sorted);
	
	Console.WriteLine(list);
}


public int[] SelectionSort(int[] array) 
{
	int temp = 0;
	int n = array.Length;
	
	for (int i = 0; i < n; i++)
	{
		int min = array[i];
		
		for (int j = (i + 1); j < n; j++) 
		{
			if (array[j] < min)
			{
				array[i] = array[j];
				array[j] = min;
				min = array[i];
			}
		}
	}
	
	return array;
}