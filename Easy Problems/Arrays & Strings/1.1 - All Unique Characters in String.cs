// Problem 1.1
// Is Unique: Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures?

public bool isUnique(string str)
{
    if (str.Length > 128) { return false; }

    bool[] asciSet = new bool[128];
    for (int i = 0; i < str.Length; i++)
    {
        int val = str[i];
        if (asciSet[val])
        {
            return false;
        }

        asciSet[val] = true;
    }

    return true;
}