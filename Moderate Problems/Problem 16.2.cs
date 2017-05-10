// Problem 16.2
// Word Frequencies: Design a method to find the frequency of occurrences of any given word in a book. What if we were running this algorithm multiple times? 

void Main()
{
	
}

// Case 1 - Single call to method O(N)
public int FindWordCount(string[] book, string searchWord)
{
	int count = 0;
	string compareWord = searchWord.Trim().ToLower();
	foreach (string word in book)
	{
		if (word.Trim().ToLower() == compareWord)
		{
			count++;
		}
	}
	return count;
}

// Case 2 - Multiple calls to method O(N) first time + O(N) space, O(1) lookup
public Dictionary<string, int> BuildDictionary(string[] book)
{
	Dictionary<string, int> dictionary = new Dictionary<string, int>();
	foreach (string w in book)
	{
		string word = w.Trim().ToLower();
	
		if (dictionary.ContainsKey(word))
		{
			dictionary[word] = dictionary[word] + 1;
		}
		else
		{
			dictionary.Add(word, 1);
		}
	}
	return dictionary;
}

public int FindWordCount(Dictionary<string, int> lookupDictionary, string word)
{
	if (lookupDictionary == null || word == null) { return -1; }
	
	int count = 0;
	word = word.Trim().ToLower();
	
	if (lookupDictionary.ContainsKey(word))
	{
		count = lookupDictionary[word];
	}
	
	return count;
}
