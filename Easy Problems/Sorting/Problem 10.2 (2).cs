

void Main()
{
	string[] array = new string[] {"racecar", "dog", "uppy", "race", "god", "acre", "care", "ypppu", "taco", "puppy", "racecar", "ocat", "bob", "tim","obb"};
	array = OrderAnagrams(array);
	
	Console.WriteLine(array);
}

public string[] OrderAnagrams(string[] array)
{

	// NOT YET WORKING

	Hashtable map = new Hashtable();
	
	foreach (string s in array)
	{
		string key = sortChars(s);
		map.Add(key, s);
	}
	
	int index = 0;
	foreach (string key in map.Keys)
	{
		List<string> list = map[key] as List<string>;
		foreach (string t in list)
		{
			array[index] = t;
			index++;
		}
	}
	
	return array;
}

string sortChars(string s)
{
	char[] content = s.ToArray();
	Array.Sort(content);
	return new String(content);
}



