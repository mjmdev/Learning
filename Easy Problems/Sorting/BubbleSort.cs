

// Bubble Sort: O(n^2) runtime, O(1) Memory

// Start at the beginning of the array and swap the first two elements if the first is greater than the second. 
// Then, we go to the next pair, and so on, continuously making sweeps of the array until it is sorted.

void Main()
{
	int[] array = new int[] {1, 2, 7, 3, 1, 94, 57, 22, 1, 7, 0, -3};
	int[] sorted = BubbleSort(array);
	string list = String.Join(", ", sorted);
	
	Console.WriteLine(list);
}

public int[] BubbleSort(int[] array) 
{
	int n = array.Length;
	int temp = 0;
	
	for(int i = 0; i < n; i++)
	{ 
		for(int j = 1; j < (n-i); j++)	
		{
			if (array[j] < array[j - 1]) {
				temp = array[j - 1];
				array[j - 1] = array[j];
				array[j] = temp;
			}
		}
	}
	return array;
}