

// Problem 10.1 - Sorted Merge: You are given two sorted arrays, A and B, where A has a large enough buffer at the end to hold B. 
// Write a method to merge B into A in sorted order. 

void Main()
{
	int[] array1 = new int[] {1, 3, 4, 12, 17, 0, 0, 0, 0};
	int[] array2 = new int[] {2, 10, 98, 100};
	
	Merge(array1, array2);
	
	string list = String.Join(", ", array1);
	
	Console.WriteLine(list);
}

// Assumption: 0 value indicates empty array index

public void Merge(int[] array1, int[] array2) 
{
	int h1 = array1.Length - 1;
	int h2 = array2.Length - 1;
	int pointer = array1.Length - 1;
	
	while (h2 >= 0)
	{
		if (array1[h1] == 0)
		{
			h1 --;
		}
		else 
		{
			if (h1 >= 0 && array1[h1] > array2[h2])
			{
				array1[pointer] = array1[h1];
				h1 --;
			}
			else 
			{
				array1[pointer] = array2[h2];
				h2 --;
			}
			pointer --;
		}
	}
}

