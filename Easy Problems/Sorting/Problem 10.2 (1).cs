

void Main()
{
	string[] array = new string[] {"racecar", "dog", "uppy", "race", "god", "acre", "care", "ypppu", "taco", "puppy", "racecar", "ocat", "bob", "tim","obb"};
	array = OrderAnagrams(array);
	
	Console.WriteLine(array);
}

public string[] OrderAnagrams(string[] array)
{    
	if (array.Length < 3) { return array; } // Case when array already ordered
	
	for (int i = 0; i < array.Length - 1; i++) 
	{
		for (int j = (i + 1); j < array.Length; j++)
		{
			if (isAnagram(array[i], array[j])) 
			{
				Swap(array, (i + 1), j);
			}
		}
	}
	return array;
}


public bool isAnagram(string a, string b)
{
	bool isAnagram = true;
	int[] count = new int[128];
	
	if (a.Length != b.Length) { return false; }
	
	foreach (char s in a) {
		count[s]++;
	}
	
	foreach (char s in b) {
		count[s]--;
		if (count[s] < 0) { return false; }
	}
	
	return isAnagram;
}

public void Swap(string[] array, int a, int b)
{
	if (a == b) { return; }
	
	string stringA = array[a];
	array[a] = array[b];
	array[b] = stringA;
}